namespace Code_Checker
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.Run = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.failedInput = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.label2 = new System.Windows.Forms.Label();
            this.timeInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.testInput = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.failedOutput = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Verdict = new System.Windows.Forms.TextBox();
            this.exportInput = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkName = new System.Windows.Forms.Label();
            this.exportOutput = new System.Windows.Forms.Button();
            this.saveInput = new System.Windows.Forms.SaveFileDialog();
            this.saveOutput = new System.Windows.Forms.SaveFileDialog();
            this.openChecker = new System.Windows.Forms.OpenFileDialog();
            this.tabPage4.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test(s)";
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(249, 89);
            this.Run.Margin = new System.Windows.Forms.Padding(0);
            this.Run.Name = "Run";
            this.Run.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Run.Size = new System.Drawing.Size(75, 23);
            this.Run.TabIndex = 0;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.failedInput);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(268, 229);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Failed Input";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // failedInput
            // 
            this.failedInput.AcceptsReturn = true;
            this.failedInput.AcceptsTab = true;
            this.failedInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.failedInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.failedInput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failedInput.Location = new System.Drawing.Point(0, 0);
            this.failedInput.MaxLength = 100000000;
            this.failedInput.Multiline = true;
            this.failedInput.Name = "failedInput";
            this.failedInput.ReadOnly = true;
            this.failedInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.failedInput.Size = new System.Drawing.Size(268, 229);
            this.failedInput.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(12, 261);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(276, 255);
            this.tabControl2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Time limit";
            // 
            // timeInput
            // 
            this.timeInput.Location = new System.Drawing.Point(151, 52);
            this.timeInput.MaxLength = 5;
            this.timeInput.Name = "timeInput";
            this.timeInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timeInput.Size = new System.Drawing.Size(49, 22);
            this.timeInput.TabIndex = 8;
            this.timeInput.Text = "1000";
            this.timeInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeInput.TextChanged += new System.EventHandler(this.timeInput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ms";
            // 
            // testInput
            // 
            this.testInput.Location = new System.Drawing.Point(151, 12);
            this.testInput.MaxLength = 3;
            this.testInput.Name = "testInput";
            this.testInput.Size = new System.Drawing.Size(75, 22);
            this.testInput.TabIndex = 10;
            this.testInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.testInput.TextChanged += new System.EventHandler(this.testInput_TextChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.failedOutput);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(268, 229);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Failed Output";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // failedOutput
            // 
            this.failedOutput.AcceptsReturn = true;
            this.failedOutput.AcceptsTab = true;
            this.failedOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.failedOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.failedOutput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failedOutput.Location = new System.Drawing.Point(0, 0);
            this.failedOutput.MaxLength = 100000000;
            this.failedOutput.Multiline = true;
            this.failedOutput.Name = "failedOutput";
            this.failedOutput.ReadOnly = true;
            this.failedOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.failedOutput.Size = new System.Drawing.Size(268, 229);
            this.failedOutput.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(296, 261);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(276, 255);
            this.tabControl1.TabIndex = 5;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage2);
            this.tabControl3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl3.Location = new System.Drawing.Point(12, 116);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(560, 128);
            this.tabControl3.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Verdict);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(552, 102);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Verdict";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Verdict
            // 
            this.Verdict.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Verdict.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Verdict.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Verdict.Location = new System.Drawing.Point(0, 0);
            this.Verdict.MaxLength = 100000000;
            this.Verdict.Multiline = true;
            this.Verdict.Name = "Verdict";
            this.Verdict.ReadOnly = true;
            this.Verdict.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Verdict.Size = new System.Drawing.Size(552, 102);
            this.Verdict.TabIndex = 0;
            // 
            // exportInput
            // 
            this.exportInput.Location = new System.Drawing.Point(86, 526);
            this.exportInput.Name = "exportInput";
            this.exportInput.Size = new System.Drawing.Size(118, 23);
            this.exportInput.TabIndex = 12;
            this.exportInput.Text = "Export Input...";
            this.exportInput.UseVisualStyleBackColor = true;
            this.exportInput.Click += new System.EventHandler(this.exportInput_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(250, 55);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Use External Judger";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Import External Judger...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkName
            // 
            this.checkName.AutoSize = true;
            this.checkName.Location = new System.Drawing.Point(406, 16);
            this.checkName.Name = "checkName";
            this.checkName.Size = new System.Drawing.Size(118, 13);
            this.checkName.TabIndex = 15;
            this.checkName.Text = "No Program Imported";
            // 
            // exportOutput
            // 
            this.exportOutput.Location = new System.Drawing.Point(376, 526);
            this.exportOutput.Name = "exportOutput";
            this.exportOutput.Size = new System.Drawing.Size(118, 23);
            this.exportOutput.TabIndex = 16;
            this.exportOutput.Text = "Export Output...";
            this.exportOutput.UseVisualStyleBackColor = true;
            this.exportOutput.Click += new System.EventHandler(this.exportOutput_Click);
            // 
            // openChecker
            // 
            this.openChecker.FileName = "openChecker";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.exportOutput);
            this.Controls.Add(this.checkName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.exportInput);
            this.Controls.Add(this.tabControl3);
            this.Controls.Add(this.testInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timeInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Build And Run";
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox timeInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox testInput;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TextBox failedInput;
        public System.Windows.Forms.TextBox failedOutput;
        public System.Windows.Forms.TextBox Verdict;
        private System.Windows.Forms.Button exportInput;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label checkName;
        public string opentest = "";
        public string opentime = "";
        private System.Windows.Forms.Button exportOutput;
        private System.Windows.Forms.SaveFileDialog saveInput;
        private System.Windows.Forms.SaveFileDialog saveOutput;
        private System.Windows.Forms.OpenFileDialog openChecker;
    }
}