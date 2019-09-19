namespace TicTacToe
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startNewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.B1button = new System.Windows.Forms.Button();
            this.B2button = new System.Windows.Forms.Button();
            this.B3button = new System.Windows.Forms.Button();
            this.B4button = new System.Windows.Forms.Button();
            this.B5button = new System.Windows.Forms.Button();
            this.B6button = new System.Windows.Forms.Button();
            this.B7button = new System.Windows.Forms.Button();
            this.B8button = new System.Windows.Forms.Button();
            this.B9button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.plyrnamesgroupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.selectXgrpbox = new System.Windows.Forms.GroupBox();
            this.playerTwoXrdbtn = new System.Windows.Forms.RadioButton();
            this.playerOneXrdbtn = new System.Windows.Forms.RadioButton();
            this.selectStartgrpbox = new System.Windows.Forms.GroupBox();
            this.playerTwoStartrdbtn = new System.Windows.Forms.RadioButton();
            this.playerOneStartrdbtn = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.plyrnamesgroupBox1.SuspendLayout();
            this.selectXgrpbox.SuspendLayout();
            this.selectStartgrpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(532, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startNewGameToolStripMenuItem,
            this.resetGameToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "&Game";
            // 
            // startNewGameToolStripMenuItem
            // 
            this.startNewGameToolStripMenuItem.Name = "startNewGameToolStripMenuItem";
            this.startNewGameToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.startNewGameToolStripMenuItem.Text = "&Start New Game";
            this.startNewGameToolStripMenuItem.Click += new System.EventHandler(this.startNewGameToolStripMenuItem_Click);
            // 
            // resetGameToolStripMenuItem
            // 
            this.resetGameToolStripMenuItem.Name = "resetGameToolStripMenuItem";
            this.resetGameToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.resetGameToolStripMenuItem.Text = "&Reset Game";
            this.resetGameToolStripMenuItem.Click += new System.EventHandler(this.resetGameToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // B1button
            // 
            this.B1button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1button.Location = new System.Drawing.Point(13, 42);
            this.B1button.Name = "B1button";
            this.B1button.Size = new System.Drawing.Size(72, 55);
            this.B1button.TabIndex = 1;
            this.B1button.UseVisualStyleBackColor = true;
            this.B1button.Click += new System.EventHandler(this.button_click);
            // 
            // B2button
            // 
            this.B2button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2button.Location = new System.Drawing.Point(91, 42);
            this.B2button.Name = "B2button";
            this.B2button.Size = new System.Drawing.Size(72, 55);
            this.B2button.TabIndex = 1;
            this.B2button.UseVisualStyleBackColor = true;
            this.B2button.Click += new System.EventHandler(this.button_click);
            // 
            // B3button
            // 
            this.B3button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3button.Location = new System.Drawing.Point(169, 42);
            this.B3button.Name = "B3button";
            this.B3button.Size = new System.Drawing.Size(72, 55);
            this.B3button.TabIndex = 1;
            this.B3button.UseVisualStyleBackColor = true;
            this.B3button.Click += new System.EventHandler(this.button_click);
            // 
            // B4button
            // 
            this.B4button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B4button.Location = new System.Drawing.Point(13, 112);
            this.B4button.Name = "B4button";
            this.B4button.Size = new System.Drawing.Size(72, 55);
            this.B4button.TabIndex = 1;
            this.B4button.UseVisualStyleBackColor = true;
            this.B4button.Click += new System.EventHandler(this.button_click);
            // 
            // B5button
            // 
            this.B5button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B5button.Location = new System.Drawing.Point(91, 112);
            this.B5button.Name = "B5button";
            this.B5button.Size = new System.Drawing.Size(72, 55);
            this.B5button.TabIndex = 1;
            this.B5button.UseVisualStyleBackColor = true;
            this.B5button.Click += new System.EventHandler(this.button_click);
            // 
            // B6button
            // 
            this.B6button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B6button.Location = new System.Drawing.Point(169, 112);
            this.B6button.Name = "B6button";
            this.B6button.Size = new System.Drawing.Size(72, 55);
            this.B6button.TabIndex = 1;
            this.B6button.UseVisualStyleBackColor = true;
            this.B6button.Click += new System.EventHandler(this.button_click);
            // 
            // B7button
            // 
            this.B7button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B7button.Location = new System.Drawing.Point(13, 184);
            this.B7button.Name = "B7button";
            this.B7button.Size = new System.Drawing.Size(72, 55);
            this.B7button.TabIndex = 1;
            this.B7button.UseVisualStyleBackColor = true;
            this.B7button.Click += new System.EventHandler(this.button_click);
            // 
            // B8button
            // 
            this.B8button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B8button.Location = new System.Drawing.Point(91, 184);
            this.B8button.Name = "B8button";
            this.B8button.Size = new System.Drawing.Size(72, 55);
            this.B8button.TabIndex = 1;
            this.B8button.UseVisualStyleBackColor = true;
            this.B8button.Click += new System.EventHandler(this.button_click);
            // 
            // B9button
            // 
            this.B9button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B9button.Location = new System.Drawing.Point(169, 184);
            this.B9button.Name = "B9button";
            this.B9button.Size = new System.Drawing.Size(72, 55);
            this.B9button.TabIndex = 1;
            this.B9button.UseVisualStyleBackColor = true;
            this.B9button.Click += new System.EventHandler(this.button_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(290, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Copy Right";
            // 
            // plyrnamesgroupBox1
            // 
            this.plyrnamesgroupBox1.Controls.Add(this.textBox2);
            this.plyrnamesgroupBox1.Controls.Add(this.label2);
            this.plyrnamesgroupBox1.Controls.Add(this.label3);
            this.plyrnamesgroupBox1.Controls.Add(this.textBox1);
            this.plyrnamesgroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plyrnamesgroupBox1.Location = new System.Drawing.Point(283, 34);
            this.plyrnamesgroupBox1.Name = "plyrnamesgroupBox1";
            this.plyrnamesgroupBox1.Size = new System.Drawing.Size(225, 75);
            this.plyrnamesgroupBox1.TabIndex = 3;
            this.plyrnamesgroupBox1.TabStop = false;
            this.plyrnamesgroupBox1.Text = "Players  Name";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(111, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Player Two";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Player One Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Player Two Name:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(111, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Player One";
            // 
            // selectXgrpbox
            // 
            this.selectXgrpbox.Controls.Add(this.playerTwoXrdbtn);
            this.selectXgrpbox.Controls.Add(this.playerOneXrdbtn);
            this.selectXgrpbox.Location = new System.Drawing.Point(283, 119);
            this.selectXgrpbox.Name = "selectXgrpbox";
            this.selectXgrpbox.Size = new System.Drawing.Size(225, 48);
            this.selectXgrpbox.TabIndex = 4;
            this.selectXgrpbox.TabStop = false;
            this.selectXgrpbox.Text = "X for Player";
            // 
            // playerTwoXrdbtn
            // 
            this.playerTwoXrdbtn.AutoSize = true;
            this.playerTwoXrdbtn.Location = new System.Drawing.Point(91, 22);
            this.playerTwoXrdbtn.Name = "playerTwoXrdbtn";
            this.playerTwoXrdbtn.Size = new System.Drawing.Size(74, 17);
            this.playerTwoXrdbtn.TabIndex = 0;
            this.playerTwoXrdbtn.Text = "Player two";
            this.playerTwoXrdbtn.UseVisualStyleBackColor = true;
            // 
            // playerOneXrdbtn
            // 
            this.playerOneXrdbtn.AutoSize = true;
            this.playerOneXrdbtn.Checked = true;
            this.playerOneXrdbtn.Location = new System.Drawing.Point(10, 22);
            this.playerOneXrdbtn.Name = "playerOneXrdbtn";
            this.playerOneXrdbtn.Size = new System.Drawing.Size(75, 17);
            this.playerOneXrdbtn.TabIndex = 0;
            this.playerOneXrdbtn.TabStop = true;
            this.playerOneXrdbtn.Text = "Player one";
            this.playerOneXrdbtn.UseVisualStyleBackColor = true;
            // 
            // selectStartgrpbox
            // 
            this.selectStartgrpbox.Controls.Add(this.playerTwoStartrdbtn);
            this.selectStartgrpbox.Controls.Add(this.playerOneStartrdbtn);
            this.selectStartgrpbox.Location = new System.Drawing.Point(283, 184);
            this.selectStartgrpbox.Name = "selectStartgrpbox";
            this.selectStartgrpbox.Size = new System.Drawing.Size(225, 48);
            this.selectStartgrpbox.TabIndex = 4;
            this.selectStartgrpbox.TabStop = false;
            this.selectStartgrpbox.Text = "Start Player";
            // 
            // playerTwoStartrdbtn
            // 
            this.playerTwoStartrdbtn.AutoSize = true;
            this.playerTwoStartrdbtn.Checked = true;
            this.playerTwoStartrdbtn.Location = new System.Drawing.Point(11, 25);
            this.playerTwoStartrdbtn.Name = "playerTwoStartrdbtn";
            this.playerTwoStartrdbtn.Size = new System.Drawing.Size(75, 17);
            this.playerTwoStartrdbtn.TabIndex = 0;
            this.playerTwoStartrdbtn.TabStop = true;
            this.playerTwoStartrdbtn.Text = "Player one";
            this.playerTwoStartrdbtn.UseVisualStyleBackColor = true;
            // 
            // playerOneStartrdbtn
            // 
            this.playerOneStartrdbtn.AutoSize = true;
            this.playerOneStartrdbtn.Location = new System.Drawing.Point(111, 25);
            this.playerOneStartrdbtn.Name = "playerOneStartrdbtn";
            this.playerOneStartrdbtn.Size = new System.Drawing.Size(74, 17);
            this.playerOneStartrdbtn.TabIndex = 0;
            this.playerOneStartrdbtn.Text = "Player two";
            this.playerOneStartrdbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 274);
            this.Controls.Add(this.selectStartgrpbox);
            this.Controls.Add(this.selectXgrpbox);
            this.Controls.Add(this.plyrnamesgroupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B9button);
            this.Controls.Add(this.B6button);
            this.Controls.Add(this.B3button);
            this.Controls.Add(this.B8button);
            this.Controls.Add(this.B5button);
            this.Controls.Add(this.B2button);
            this.Controls.Add(this.B7button);
            this.Controls.Add(this.B4button);
            this.Controls.Add(this.B1button);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.plyrnamesgroupBox1.ResumeLayout(false);
            this.plyrnamesgroupBox1.PerformLayout();
            this.selectXgrpbox.ResumeLayout(false);
            this.selectXgrpbox.PerformLayout();
            this.selectStartgrpbox.ResumeLayout(false);
            this.selectStartgrpbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startNewGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button B1button;
        private System.Windows.Forms.Button B2button;
        private System.Windows.Forms.Button B3button;
        private System.Windows.Forms.Button B4button;
        private System.Windows.Forms.Button B5button;
        private System.Windows.Forms.Button B6button;
        private System.Windows.Forms.Button B7button;
        private System.Windows.Forms.Button B8button;
        private System.Windows.Forms.Button B9button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox plyrnamesgroupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox selectXgrpbox;
        private System.Windows.Forms.RadioButton playerTwoXrdbtn;
        private System.Windows.Forms.RadioButton playerOneXrdbtn;
        private System.Windows.Forms.GroupBox selectStartgrpbox;
        private System.Windows.Forms.RadioButton playerTwoStartrdbtn;
        private System.Windows.Forms.RadioButton playerOneStartrdbtn;
        private System.Windows.Forms.ToolStripMenuItem resetGameToolStripMenuItem;
    }
}

