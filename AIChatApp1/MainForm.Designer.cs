namespace AIChatApp1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            ddbMenu = new ToolStripDropDownButton();
            开启新对话ToolStripMenuItem = new ToolStripMenuItem();
            ddbOptions = new ToolStripDropDownButton();
            aPIKeyToolStripMenuItem = new ToolStripMenuItem();
            tsmiLocal = new ToolStripMenuItem();
            tsmiRemote = new ToolStripMenuItem();
            panel1 = new Panel();
            panel3 = new Panel();
            groupBox2 = new GroupBox();
            btnRestart = new Button();
            btnClear = new Button();
            wbvAnswerOutput = new Microsoft.Web.WebView2.WinForms.WebView2();
            lblAnswerOutput = new Label();
            splitter1 = new Splitter();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            cboUnitTest = new ComboBox();
            btnChatTest = new Button();
            btnSend = new Button();
            txtQuestionInput = new Label();
            rtbQuestionInput = new RichTextBox();
            btnStreamingTest = new Button();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)wbvAnswerOutput).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, ddbMenu, ddbOptions });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.favicon;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Margin = new Padding(1);
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 23);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // ddbMenu
            // 
            ddbMenu.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ddbMenu.DropDownItems.AddRange(new ToolStripItem[] { 开启新对话ToolStripMenuItem });
            ddbMenu.Image = (Image)resources.GetObject("ddbMenu.Image");
            ddbMenu.ImageTransparentColor = Color.Magenta;
            ddbMenu.Margin = new Padding(2, 1, 0, 2);
            ddbMenu.Name = "ddbMenu";
            ddbMenu.ShowDropDownArrow = false;
            ddbMenu.Size = new Size(56, 22);
            ddbMenu.Text = "菜单(M)";
            // 
            // 开启新对话ToolStripMenuItem
            // 
            开启新对话ToolStripMenuItem.Name = "开启新对话ToolStripMenuItem";
            开启新对话ToolStripMenuItem.Size = new Size(136, 22);
            开启新对话ToolStripMenuItem.Text = "开启新对话";
            // 
            // ddbOptions
            // 
            ddbOptions.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ddbOptions.DropDownItems.AddRange(new ToolStripItem[] { aPIKeyToolStripMenuItem });
            ddbOptions.Image = (Image)resources.GetObject("ddbOptions.Image");
            ddbOptions.ImageTransparentColor = Color.Magenta;
            ddbOptions.Margin = new Padding(2, 1, 0, 2);
            ddbOptions.Name = "ddbOptions";
            ddbOptions.ShowDropDownArrow = false;
            ddbOptions.Size = new Size(54, 22);
            ddbOptions.Text = "设置(O)";
            // 
            // aPIKeyToolStripMenuItem
            // 
            aPIKeyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiLocal, tsmiRemote });
            aPIKeyToolStripMenuItem.Name = "aPIKeyToolStripMenuItem";
            aPIKeyToolStripMenuItem.Size = new Size(120, 22);
            aPIKeyToolStripMenuItem.Text = "API Key";
            // 
            // tsmiLocal
            // 
            tsmiLocal.Checked = true;
            tsmiLocal.CheckState = CheckState.Checked;
            tsmiLocal.Name = "tsmiLocal";
            tsmiLocal.Size = new Size(100, 22);
            tsmiLocal.Text = "本地";
            // 
            // tsmiRemote
            // 
            tsmiRemote.Name = "tsmiRemote";
            tsmiRemote.Size = new Size(100, 22);
            tsmiRemote.Text = "远程";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(splitter1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 425);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox2);
            panel3.Controls.Add(wbvAnswerOutput);
            panel3.Controls.Add(lblAnswerOutput);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 210);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 215);
            panel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox2.Controls.Add(btnRestart);
            groupBox2.Controls.Add(btnClear);
            groupBox2.Location = new Point(648, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(140, 197);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // btnRestart
            // 
            btnRestart.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRestart.Location = new Point(6, 51);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(128, 23);
            btnRestart.TabIndex = 2;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnClear.Location = new Point(6, 22);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(128, 23);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // wbvAnswerOutput
            // 
            wbvAnswerOutput.AllowExternalDrop = true;
            wbvAnswerOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            wbvAnswerOutput.CreationProperties = null;
            wbvAnswerOutput.DefaultBackgroundColor = Color.White;
            wbvAnswerOutput.Location = new Point(12, 32);
            wbvAnswerOutput.Name = "wbvAnswerOutput";
            wbvAnswerOutput.Size = new Size(630, 171);
            wbvAnswerOutput.TabIndex = 3;
            wbvAnswerOutput.ZoomFactor = 1D;
            // 
            // lblAnswerOutput
            // 
            lblAnswerOutput.Location = new Point(12, 6);
            lblAnswerOutput.Name = "lblAnswerOutput";
            lblAnswerOutput.Size = new Size(100, 23);
            lblAnswerOutput.TabIndex = 2;
            lblAnswerOutput.Text = "输入";
            lblAnswerOutput.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Top;
            splitter1.Location = new Point(0, 207);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(800, 3);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(txtQuestionInput);
            panel2.Controls.Add(rtbQuestionInput);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 207);
            panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1.Controls.Add(btnStreamingTest);
            groupBox1.Controls.Add(cboUnitTest);
            groupBox1.Controls.Add(btnChatTest);
            groupBox1.Controls.Add(btnSend);
            groupBox1.Location = new Point(648, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(140, 191);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // cboUnitTest
            // 
            cboUnitTest.FormattingEnabled = true;
            cboUnitTest.Location = new Point(6, 49);
            cboUnitTest.Name = "cboUnitTest";
            cboUnitTest.Size = new Size(128, 25);
            cboUnitTest.TabIndex = 2;
            // 
            // btnChatTest
            // 
            btnChatTest.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnChatTest.Location = new Point(6, 80);
            btnChatTest.Name = "btnChatTest";
            btnChatTest.Size = new Size(128, 23);
            btnChatTest.TabIndex = 1;
            btnChatTest.Text = "Chat Test";
            btnChatTest.UseVisualStyleBackColor = true;
            btnChatTest.Click += btnChatTest_Click;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSend.Location = new Point(6, 22);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(128, 23);
            btnSend.TabIndex = 0;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtQuestionInput
            // 
            txtQuestionInput.Location = new Point(12, 6);
            txtQuestionInput.Name = "txtQuestionInput";
            txtQuestionInput.Size = new Size(100, 23);
            txtQuestionInput.TabIndex = 1;
            txtQuestionInput.Text = "输入";
            txtQuestionInput.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rtbQuestionInput
            // 
            rtbQuestionInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbQuestionInput.Location = new Point(12, 32);
            rtbQuestionInput.Name = "rtbQuestionInput";
            rtbQuestionInput.Size = new Size(630, 165);
            rtbQuestionInput.TabIndex = 0;
            rtbQuestionInput.Text = "";
            // 
            // btnStreamingTest
            // 
            btnStreamingTest.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnStreamingTest.Location = new Point(6, 109);
            btnStreamingTest.Name = "btnStreamingTest";
            btnStreamingTest.Size = new Size(128, 23);
            btnStreamingTest.TabIndex = 3;
            btnStreamingTest.Text = "Streaming Test";
            btnStreamingTest.UseVisualStyleBackColor = true;
            btnStreamingTest.Click += btnStreamingTest_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)wbvAnswerOutput).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton ddbOptions;
        private ToolStripMenuItem aPIKeyToolStripMenuItem;
        private ToolStripMenuItem tsmiLocal;
        private ToolStripMenuItem tsmiRemote;
        private ToolStripDropDownButton ddbMenu;
        private ToolStripMenuItem 开启新对话ToolStripMenuItem;
        private ToolStripButton toolStripButton1;
        private Panel panel1;
        private Panel panel3;
        private Splitter splitter1;
        private Panel panel2;
        private Label txtQuestionInput;
        private RichTextBox rtbQuestionInput;
        private Label lblAnswerOutput;
        private Microsoft.Web.WebView2.WinForms.WebView2 wbvAnswerOutput;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button btnRestart;
        private Button btnClear;
        private Button btnChatTest;
        private Button btnSend;
        private ComboBox cboUnitTest;
        private Button btnStreamingTest;
    }
}
