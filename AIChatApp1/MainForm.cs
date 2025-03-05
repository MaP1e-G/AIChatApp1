using Markdig;
using OpenAI;
using OpenAI.Chat;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Reflection;
using System.Text;
using System.Text.Json;

namespace AIChatApp1
{
    public partial class MainForm : Form
    {
        private ChatClient _chatClient;
        private ApiKeyCredential _apiKeyCredential;
        private OpenAIClientOptions _openAIClientOptions;
        private readonly string _modelName = "deepseek-r1-distill-qwen-32b";
        private List<ChatMessage> _historyMessages = new List<ChatMessage>();
        private string _prompt = "";

        public MainForm()
        {
            InitializeComponent();
            InitializeCustomComponent();
            InitializeChatClient();
        }

        #region Events
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Task.Run(() => GivePrompt());
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            string question = rtbQuestionInput.Text;
            Task.Run(() => Chat(question));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not ready yet!");
        }

        private void btnChatTest_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ExecuteUnitTest(cboUnitTest.SelectedItem.ToString());
            Cursor = Cursors.Default;
        }

        private void btnStreamingTest_Click(object sender, EventArgs e)
        {
            Task.Run(() => StreamingTest());
        }
        #endregion

        #region Initialize Methods
        private async void InitializeCustomComponent()
        {
            // 初始化 WebView2 环境
            await wbvAnswerOutput.EnsureCoreWebView2Async(null);

            // 设置初始 HTML 内容
            wbvAnswerOutput.CoreWebView2.NavigateToString("<html><body><h3>Loading...</h3></body></html>");

            // 初始化 ComboBox
            var unitTestMethods = this.GetType()
                .GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                .Where(m => m.Name.StartsWith("UnitTest", StringComparison.OrdinalIgnoreCase))
                .OrderBy(m => m.Name)
                .ToList();

            foreach (var method in unitTestMethods)
            {
                cboUnitTest.Items.Add(method.Name);
            }

            cboUnitTest.SelectedIndex = 0;
        }

        private void InitializeChatClient()
        {
            string? apiKey = Environment.GetEnvironmentVariable("BAILIAN_API_KEY");
            if (string.IsNullOrEmpty(apiKey))
            {
                MessageBox.Show("Can not get the api key!");
                return;
            }

            _apiKeyCredential = new ApiKeyCredential(apiKey);
            _openAIClientOptions = new OpenAIClientOptions();
            _openAIClientOptions.Endpoint = new Uri("https://dashscope.aliyuncs.com/compatible-mode/v1");
            _openAIClientOptions.UserAgentApplicationId = "Centaurea";
            _openAIClientOptions.ProjectId = "deepseek-test";
            _openAIClientOptions.RetryPolicy = ClientRetryPolicy.Default;
            _chatClient = new(model: _modelName, credential: _apiKeyCredential, options: _openAIClientOptions);
        }

        private async void GivePrompt()
        {
            btnSend.BeginInvoke(new Action(() =>
            {
                btnSend.Enabled = false;
            }));

            // System messages represent instructions or other guidance about how the assistant should behave
            _historyMessages.Add(new SystemChatMessage("你是一只乐于助人的猫娘。"));
            ChatCompletion completion = await _chatClient.CompleteChatAsync(_historyMessages);

            btnSend.BeginInvoke(new Action(() =>
            {
                btnSend.Enabled = true;
            }));
        }
        #endregion

        #region Test Methods
        private void ExecuteUnitTest(string methodName) => this.GetType().InvokeMember(methodName, BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.NonPublic, null, this, null);

        private void UnitTest1()
        {
            ChatCompletion completion = _chatClient.CompleteChat("请帮我用C#写一个程序，循环输出1到100。");
            string markdownText = completion.Content[0].Text;
            string htmlContent = Markdown.ToHtml(markdownText);

            // 添加自定义 CSS 样式
            string styledHtml = $@"
            <html>
                <head>
                    <style>
                        body {{ font-family: Arial, sans-serif; }}
                        h1 {{ color: #0078d7; }}
                        a {{ color: #ff5722; text-decoration: none; }}
                        a:hover {{ text-decoration: underline; }}
                        pre {{ background: #f4f4f4; padding: 10px; border-radius: 5px; }}
                        code {{ font-family: Consolas, monospace; }}
                    </style>
                </head>
                <body>
                    {htmlContent}
                </body>
            </html>";

            // 将 HTML 加载到 WebView2 控件中
            wbvAnswerOutput.CoreWebView2.NavigateToString(styledHtml);
        }

        private void UnitTest2()
        {
            BinaryData input = BinaryData.FromBytes("""
                {
                  "model": "deepseek-r1-distill-qwen-32b",
                  "messages": [
                    {
                      "role": "user",
                      "content": "下午好啊~"
                    }
                  ]
                }
                """u8.ToArray());

            using BinaryContent content = BinaryContent.Create(input);
            ClientResult result = _chatClient.CompleteChat(content);
            BinaryData output = result.GetRawResponse().Content;

            using JsonDocument outputAsJson = JsonDocument.Parse(output.ToString());
            string? message = outputAsJson.RootElement
                .GetProperty("choices"u8)[0]
                .GetProperty("message"u8)
                .GetProperty("content"u8)
                .GetString();
            if (message != null)
            {
                string markdownText = message;
                string htmlContent = Markdown.ToHtml(markdownText);
                string styledHtml = $@"
                <html>
                    <body>
                        {htmlContent}
                    </body>
                </html>";

                // 将 HTML 加载到 WebView2 控件中
                wbvAnswerOutput.CoreWebView2.NavigateToString(styledHtml);
            }
            else
            {
                wbvAnswerOutput.CoreWebView2.NavigateToString("<html><body><h3>Oops, Something went wrong! :(</h3></body></html>");
            }
        }

        private async void StreamingTest()
        {
            StringBuilder contents = new StringBuilder("");
            string htmlContent = "";
            string styledHtmlStart = $@"
                    <html>
                        <body>";
            string styledHtmlEnd = $@"
                        </body>
                    </html>";

            AsyncCollectionResult<StreamingChatCompletionUpdate> completionUpdates = _chatClient.CompleteChatStreamingAsync("介绍一下C#中的async与await，最好可以给出一个实用的例子。");
            
            await foreach (StreamingChatCompletionUpdate completionUpdate in completionUpdates)
            {
                if (completionUpdate.ContentUpdate.Count > 0)
                {
                    string currentText = completionUpdate.ContentUpdate[0].Text;
                    contents.Append(currentText);
                    wbvAnswerOutput.BeginInvoke(new Action(() =>
                    {
                        wbvAnswerOutput.CoreWebView2.NavigateToString(styledHtmlStart + Markdown.ToHtml(contents.ToString()) + styledHtmlEnd);
                    }));
                }
            }
        }
        #endregion

        private async Task Chat(string message)
        {
            try
            {
                _historyMessages.Add(new UserChatMessage(message));  // 加入本次用户提问至历史记录
                ClientResult<ChatCompletion> result = await _chatClient.CompleteChatAsync(_historyMessages);
                if (result != null)
                {
                    string markdownText = result.Value.Content[0].Text;
                    // BinaryData output = result.GetRawResponse().Content;  // 获取 RawResponse，可以拿到思考过程("reasoning_content")
                    _historyMessages.Add(new AssistantChatMessage(markdownText));  // 加入本次语言模型回答至历史记录
                    string htmlContent = Markdown.ToHtml(markdownText);

                    // 添加自定义 CSS 样式
                    string styledHtml = $@"
                    <html>
                        <head>
                            <style>
                                body {{ font-family: Arial, sans-serif; }}
                                h1 {{ color: #0078d7; }}
                                a {{ color: #ff5722; text-decoration: none; }}
                                a:hover {{ text-decoration: underline; }}
                                pre {{ background: #f4f4f4; padding: 10px; border-radius: 5px; }}
                                code {{ font-family: Consolas, monospace; }}
                            </style>
                        </head>
                        <body>
                            {htmlContent}
                        </body>
                    </html>";

                    // Ensure the WebView2 control is initialized
                    //if (wbvAnswerOutput.CoreWebView2 == null)
                    //{
                    //    await wbvAnswerOutput.EnsureCoreWebView2Async();
                    //}

                    // Use BeginInvoke to update the UI thread
                    wbvAnswerOutput.BeginInvoke(new Action(() =>
                    {
                        wbvAnswerOutput.CoreWebView2.NavigateToString(styledHtml);
                    }));
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log them or show a message to the user)
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Re-enable the button on the UI thread
                btnSend.BeginInvoke(new Action(() =>
                {
                    btnSend.Enabled = true;
                }));
            }
        }

        
    }
}
