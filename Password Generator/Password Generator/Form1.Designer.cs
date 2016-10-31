namespace Password_Generator
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tclGenerator = new System.Windows.Forms.TabControl();
            this.tbpGenerator = new System.Windows.Forms.TabPage();
            this.tclNotepad = new System.Windows.Forms.TabPage();
            this.chlbGenerator = new System.Windows.Forms.CheckedListBox();
            this.nudLength = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerates = new System.Windows.Forms.Button();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tclGenerator.SuspendLayout();
            this.tbpGenerator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.notepadToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSave,
            this.tsmiLoad});
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.notepadToolStripMenuItem.Text = "Notepad";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(152, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(152, 22);
            this.tsmiSave.Text = "Save";
            // 
            // tsmiLoad
            // 
            this.tsmiLoad.Name = "tsmiLoad";
            this.tsmiLoad.Size = new System.Drawing.Size(152, 22);
            this.tsmiLoad.Text = "Load";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(152, 22);
            this.tsmiAbout.Text = "About";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tclGenerator
            // 
            this.tclGenerator.Controls.Add(this.tbpGenerator);
            this.tclGenerator.Controls.Add(this.tclNotepad);
            this.tclGenerator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tclGenerator.Location = new System.Drawing.Point(0, 24);
            this.tclGenerator.Name = "tclGenerator";
            this.tclGenerator.SelectedIndex = 0;
            this.tclGenerator.Size = new System.Drawing.Size(292, 249);
            this.tclGenerator.TabIndex = 1;
            // 
            // tbpGenerator
            // 
            this.tbpGenerator.Controls.Add(this.txbPassword);
            this.tbpGenerator.Controls.Add(this.btnGenerates);
            this.tbpGenerator.Controls.Add(this.label1);
            this.tbpGenerator.Controls.Add(this.nudLength);
            this.tbpGenerator.Controls.Add(this.chlbGenerator);
            this.tbpGenerator.Location = new System.Drawing.Point(4, 22);
            this.tbpGenerator.Name = "tbpGenerator";
            this.tbpGenerator.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGenerator.Size = new System.Drawing.Size(284, 223);
            this.tbpGenerator.TabIndex = 0;
            this.tbpGenerator.Text = "Generator";
            this.tbpGenerator.UseVisualStyleBackColor = true;
            // 
            // tclNotepad
            // 
            this.tclNotepad.Location = new System.Drawing.Point(4, 22);
            this.tclNotepad.Name = "tclNotepad";
            this.tclNotepad.Padding = new System.Windows.Forms.Padding(3);
            this.tclNotepad.Size = new System.Drawing.Size(284, 223);
            this.tclNotepad.TabIndex = 1;
            this.tclNotepad.Text = "Notepad";
            this.tclNotepad.UseVisualStyleBackColor = true;
            // 
            // chlbGenerator
            // 
            this.chlbGenerator.CheckOnClick = true;
            this.chlbGenerator.FormattingEnabled = true;
            this.chlbGenerator.Items.AddRange(new object[] {
            "Lowercase",
            "Uppercase",
            "Numbers",
            "Special symbols"});
            this.chlbGenerator.Location = new System.Drawing.Point(8, 6);
            this.chlbGenerator.Name = "chlbGenerator";
            this.chlbGenerator.Size = new System.Drawing.Size(268, 64);
            this.chlbGenerator.TabIndex = 0;
            // 
            // nudLength
            // 
            this.nudLength.Location = new System.Drawing.Point(97, 81);
            this.nudLength.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudLength.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudLength.Name = "nudLength";
            this.nudLength.Size = new System.Drawing.Size(54, 20);
            this.nudLength.TabIndex = 1;
            this.nudLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password length";
            // 
            // btnGenerates
            // 
            this.btnGenerates.Location = new System.Drawing.Point(11, 111);
            this.btnGenerates.Name = "btnGenerates";
            this.btnGenerates.Size = new System.Drawing.Size(140, 23);
            this.btnGenerates.TabIndex = 3;
            this.btnGenerates.Text = "Genarates password";
            this.btnGenerates.UseVisualStyleBackColor = true;
            this.btnGenerates.Click += new System.EventHandler(this.btnGenerates_Click);
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(11, 140);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(265, 20);
            this.txbPassword.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.tclGenerator);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "tab";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tclGenerator.ResumeLayout(false);
            this.tbpGenerator.ResumeLayout(false);
            this.tbpGenerator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoad;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.TabControl tclGenerator;
        private System.Windows.Forms.TabPage tbpGenerator;
        private System.Windows.Forms.CheckedListBox chlbGenerator;
        private System.Windows.Forms.TabPage tclNotepad;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Button btnGenerates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudLength;
    }
}

