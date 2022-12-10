namespace Code_Checker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TabEditor = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.editorCodeCheck = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.editorAccepted = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.editorTest = new FastColoredTextBoxNS.FastColoredTextBox();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.position = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importCodeCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importAcceptedCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importTestGeratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildAndRunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCodeCheckTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAcceptedCodeTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTestGeneratorTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutCodeCheckerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importCodeCheck = new System.Windows.Forms.OpenFileDialog();
            this.importAccepted = new System.Windows.Forms.OpenFileDialog();
            this.importTest = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.TabEditor.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editorCodeCheck)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editorAccepted)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editorTest)).BeginInit();
            this.statusBar.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabEditor
            // 
            this.TabEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabEditor.Controls.Add(this.tabPage1);
            this.TabEditor.Controls.Add(this.tabPage2);
            this.TabEditor.Controls.Add(this.tabPage3);
            this.TabEditor.Cursor = System.Windows.Forms.Cursors.Default;
            this.TabEditor.ItemSize = new System.Drawing.Size(73, 18);
            this.TabEditor.Location = new System.Drawing.Point(0, 27);
            this.TabEditor.Name = "TabEditor";
            this.TabEditor.SelectedIndex = 0;
            this.TabEditor.Size = new System.Drawing.Size(1264, 635);
            this.TabEditor.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.editorCodeCheck);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1256, 609);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Code Check";
            // 
            // editorCodeCheck
            // 
            this.editorCodeCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editorCodeCheck.AutoCompleteBrackets = true;
            this.editorCodeCheck.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.editorCodeCheck.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:" +
    "]*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.editorCodeCheck.AutoScrollMinSize = new System.Drawing.Size(35, 15);
            this.editorCodeCheck.BackBrush = null;
            this.editorCodeCheck.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.editorCodeCheck.CharHeight = 15;
            this.editorCodeCheck.CharWidth = 7;
            this.editorCodeCheck.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editorCodeCheck.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.editorCodeCheck.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.editorCodeCheck.IsReplaceMode = false;
            this.editorCodeCheck.Language = FastColoredTextBoxNS.Language.CSharp;
            this.editorCodeCheck.LeftBracket = '(';
            this.editorCodeCheck.LeftBracket2 = '{';
            this.editorCodeCheck.LeftPadding = 10;
            this.editorCodeCheck.Location = new System.Drawing.Point(0, 0);
            this.editorCodeCheck.Name = "editorCodeCheck";
            this.editorCodeCheck.Paddings = new System.Windows.Forms.Padding(0);
            this.editorCodeCheck.RightBracket = ')';
            this.editorCodeCheck.RightBracket2 = '}';
            this.editorCodeCheck.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.editorCodeCheck.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("editorCodeCheck.ServiceColors")));
            this.editorCodeCheck.ShowFoldingLines = true;
            this.editorCodeCheck.Size = new System.Drawing.Size(1256, 609);
            this.editorCodeCheck.TabIndex = 0;
            this.editorCodeCheck.Zoom = 100;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.editorAccepted);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1256, 609);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Accepted Code";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // editorAccepted
            // 
            this.editorAccepted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editorAccepted.AutoCompleteBrackets = true;
            this.editorAccepted.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.editorAccepted.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:" +
    "]*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.editorAccepted.AutoScrollMinSize = new System.Drawing.Size(12, 15);
            this.editorAccepted.BackBrush = null;
            this.editorAccepted.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.editorAccepted.CharHeight = 15;
            this.editorAccepted.CharWidth = 7;
            this.editorAccepted.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editorAccepted.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.editorAccepted.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.editorAccepted.IsReplaceMode = false;
            this.editorAccepted.Language = FastColoredTextBoxNS.Language.CSharp;
            this.editorAccepted.LeftBracket = '(';
            this.editorAccepted.LeftBracket2 = '{';
            this.editorAccepted.LeftPadding = 10;
            this.editorAccepted.Location = new System.Drawing.Point(0, 0);
            this.editorAccepted.Name = "editorAccepted";
            this.editorAccepted.Paddings = new System.Windows.Forms.Padding(0);
            this.editorAccepted.RightBracket = ')';
            this.editorAccepted.RightBracket2 = '}';
            this.editorAccepted.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.editorAccepted.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("editorAccepted.ServiceColors")));
            this.editorAccepted.ShowFoldingLines = true;
            this.editorAccepted.Size = new System.Drawing.Size(1256, 609);
            this.editorAccepted.TabIndex = 1;
            this.editorAccepted.Zoom = 100;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.editorTest);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1256, 609);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Test Generator";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // editorTest
            // 
            this.editorTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editorTest.AutoCompleteBrackets = true;
            this.editorTest.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.editorTest.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:" +
    "]*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.editorTest.AutoScrollMinSize = new System.Drawing.Size(12, 15);
            this.editorTest.BackBrush = null;
            this.editorTest.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.editorTest.CharHeight = 15;
            this.editorTest.CharWidth = 7;
            this.editorTest.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editorTest.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.editorTest.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.editorTest.IsReplaceMode = false;
            this.editorTest.Language = FastColoredTextBoxNS.Language.CSharp;
            this.editorTest.LeftBracket = '(';
            this.editorTest.LeftBracket2 = '{';
            this.editorTest.LeftPadding = 10;
            this.editorTest.Location = new System.Drawing.Point(0, 0);
            this.editorTest.Name = "editorTest";
            this.editorTest.Paddings = new System.Windows.Forms.Padding(0);
            this.editorTest.RightBracket = ')';
            this.editorTest.RightBracket2 = '}';
            this.editorTest.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.editorTest.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("editorTest.ServiceColors")));
            this.editorTest.ShowFoldingLines = true;
            this.editorTest.Size = new System.Drawing.Size(1256, 609);
            this.editorTest.TabIndex = 1;
            this.editorTest.Zoom = 100;
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.position,
            this.toolStripStatusLabel2});
            this.statusBar.Location = new System.Drawing.Point(0, 657);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1264, 24);
            this.statusBar.TabIndex = 4;
            this.statusBar.Text = "statusBar";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(789, 19);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "GNU C++14 Compiler";
            // 
            // position
            // 
            this.position.AutoSize = false;
            this.position.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.position.Name = "position";
            this.position.Padding = new System.Windows.Forms.Padding(200, 0, 0, 0);
            this.position.Size = new System.Drawing.Size(237, 19);
            this.position.Text = "Pos: -";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(223, 19);
            this.toolStripStatusLabel2.Text = "Code Checker by Pye";
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.buildToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(0);
            this.menuBar.Size = new System.Drawing.Size(1264, 24);
            this.menuBar.TabIndex = 5;
            this.menuBar.Text = "menuBar";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importCodeCheckToolStripMenuItem,
            this.importAcceptedCodeToolStripMenuItem,
            this.importTestGeratorToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importCodeCheckToolStripMenuItem
            // 
            this.importCodeCheckToolStripMenuItem.Name = "importCodeCheckToolStripMenuItem";
            this.importCodeCheckToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.X)));
            this.importCodeCheckToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.importCodeCheckToolStripMenuItem.Text = "Import Code Check...";
            this.importCodeCheckToolStripMenuItem.Click += new System.EventHandler(this.importCodeCheckToolStripMenuItem_Click);
            // 
            // importAcceptedCodeToolStripMenuItem
            // 
            this.importAcceptedCodeToolStripMenuItem.Name = "importAcceptedCodeToolStripMenuItem";
            this.importAcceptedCodeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.importAcceptedCodeToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.importAcceptedCodeToolStripMenuItem.Text = "Import Accepted Code...";
            this.importAcceptedCodeToolStripMenuItem.Click += new System.EventHandler(this.importAcceptedCodeToolStripMenuItem_Click);
            // 
            // importTestGeratorToolStripMenuItem
            // 
            this.importTestGeratorToolStripMenuItem.Name = "importTestGeratorToolStripMenuItem";
            this.importTestGeratorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.V)));
            this.importTestGeratorToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.importTestGeratorToolStripMenuItem.Text = "Import Test Generator...";
            this.importTestGeratorToolStripMenuItem.Click += new System.EventHandler(this.importTestGeratorToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.saveFileToolStripMenuItem.Text = "Export file...";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(274, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildAndRunToolStripMenuItem});
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.buildToolStripMenuItem.Text = "Build";
            // 
            // buildAndRunToolStripMenuItem
            // 
            this.buildAndRunToolStripMenuItem.Name = "buildAndRunToolStripMenuItem";
            this.buildAndRunToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.buildAndRunToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.buildAndRunToolStripMenuItem.Text = "Build and Run...";
            this.buildAndRunToolStripMenuItem.Click += new System.EventHandler(this.buildAndRunToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showCodeCheckTabToolStripMenuItem,
            this.showAcceptedCodeTabToolStripMenuItem,
            this.showTestGeneratorTabToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // showCodeCheckTabToolStripMenuItem
            // 
            this.showCodeCheckTabToolStripMenuItem.Name = "showCodeCheckTabToolStripMenuItem";
            this.showCodeCheckTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.showCodeCheckTabToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.showCodeCheckTabToolStripMenuItem.Text = "Show Code Check";
            this.showCodeCheckTabToolStripMenuItem.Click += new System.EventHandler(this.showCodeCheckTabToolStripMenuItem_Click);
            // 
            // showAcceptedCodeTabToolStripMenuItem
            // 
            this.showAcceptedCodeTabToolStripMenuItem.Name = "showAcceptedCodeTabToolStripMenuItem";
            this.showAcceptedCodeTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2)));
            this.showAcceptedCodeTabToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.showAcceptedCodeTabToolStripMenuItem.Text = "Show Accepted Code";
            this.showAcceptedCodeTabToolStripMenuItem.Click += new System.EventHandler(this.showAcceptedCodeTabToolStripMenuItem_Click);
            // 
            // showTestGeneratorTabToolStripMenuItem
            // 
            this.showTestGeneratorTabToolStripMenuItem.Name = "showTestGeneratorTabToolStripMenuItem";
            this.showTestGeneratorTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D3)));
            this.showTestGeneratorTabToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.showTestGeneratorTabToolStripMenuItem.Text = "Show Test Generator";
            this.showTestGeneratorTabToolStripMenuItem.Click += new System.EventHandler(this.showTestGeneratorTabToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutCodeCheckerToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutCodeCheckerToolStripMenuItem
            // 
            this.aboutCodeCheckerToolStripMenuItem.Name = "aboutCodeCheckerToolStripMenuItem";
            this.aboutCodeCheckerToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutCodeCheckerToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.aboutCodeCheckerToolStripMenuItem.Text = "About Code Checker...";
            this.aboutCodeCheckerToolStripMenuItem.Click += new System.EventHandler(this.aboutCodeCheckerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.TabEditor);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.Name = "Form1";
            this.Text = "Code Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabEditor.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editorCodeCheck)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editorAccepted)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editorTest)).EndInit();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl TabEditor;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private FastColoredTextBoxNS.FastColoredTextBox editorCodeCheck;
        private FastColoredTextBoxNS.FastColoredTextBox editorAccepted;
        private FastColoredTextBoxNS.FastColoredTextBox editorTest;
        private System.Windows.Forms.ToolStripMenuItem importCodeCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importAcceptedCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importTestGeratorToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog importCodeCheck;
        private System.Windows.Forms.OpenFileDialog importAccepted;
        private System.Windows.Forms.OpenFileDialog importTest;
        private System.Windows.Forms.ToolStripMenuItem buildAndRunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCodeCheckTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAcceptedCodeTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTestGeneratorTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutCodeCheckerToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel position;
    }
}

