namespace NTS_test_form
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
            this.label_select = new System.Windows.Forms.Label();
            this.CCN = new System.Windows.Forms.RadioButton();
            this.DIP = new System.Windows.Forms.RadioButton();
            this.SProb = new System.Windows.Forms.RadioButton();
            this.VP = new System.Windows.Forms.RadioButton();
            this.next = new System.Windows.Forms.Button();
            this.Q1 = new System.Windows.Forms.Label();
            this.Q2 = new System.Windows.Forms.Label();
            this.Q3 = new System.Windows.Forms.Label();
            this.Q4 = new System.Windows.Forms.Label();
            this.Q5 = new System.Windows.Forms.Label();
            this.Q1O1 = new System.Windows.Forms.RadioButton();
            this.Q1O2 = new System.Windows.Forms.RadioButton();
            this.Q1O3 = new System.Windows.Forms.RadioButton();
            this.Q2O1 = new System.Windows.Forms.RadioButton();
            this.Q2O2 = new System.Windows.Forms.RadioButton();
            this.Q2O3 = new System.Windows.Forms.RadioButton();
            this.Q3O1 = new System.Windows.Forms.RadioButton();
            this.Q3O2 = new System.Windows.Forms.RadioButton();
            this.Q3O3 = new System.Windows.Forms.RadioButton();
            this.Q4O1 = new System.Windows.Forms.RadioButton();
            this.Q4O2 = new System.Windows.Forms.RadioButton();
            this.Q4O3 = new System.Windows.Forms.RadioButton();
            this.Q5O1 = new System.Windows.Forms.RadioButton();
            this.Q5O2 = new System.Windows.Forms.RadioButton();
            this.Q5O3 = new System.Windows.Forms.RadioButton();
            this.Questions = new System.Windows.Forms.GroupBox();
            this.Options3 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Options4 = new System.Windows.Forms.GroupBox();
            this.Options2 = new System.Windows.Forms.GroupBox();
            this.Options1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.Questions.SuspendLayout();
            this.Options3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Options4.SuspendLayout();
            this.Options2.SuspendLayout();
            this.Options1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_select
            // 
            this.label_select.AutoSize = true;
            this.label_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_select.Location = new System.Drawing.Point(7, 9);
            this.label_select.Name = "label_select";
            this.label_select.Size = new System.Drawing.Size(327, 25);
            this.label_select.TabIndex = 0;
            this.label_select.Text = "Select Any Option to Begin Test.";
            // 
            // CCN
            // 
            this.CCN.AutoSize = true;
            this.CCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCN.Location = new System.Drawing.Point(126, 64);
            this.CCN.Name = "CCN";
            this.CCN.Size = new System.Drawing.Size(345, 24);
            this.CCN.TabIndex = 1;
            this.CCN.Text = "Computer Communication and networks";
            this.CCN.UseVisualStyleBackColor = true;
            this.CCN.CheckedChanged += new System.EventHandler(this.CCN_CheckedChanged);
            // 
            // DIP
            // 
            this.DIP.AutoSize = true;
            this.DIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIP.Location = new System.Drawing.Point(126, 145);
            this.DIP.Name = "DIP";
            this.DIP.Size = new System.Drawing.Size(226, 24);
            this.DIP.TabIndex = 1;
            this.DIP.Text = "Digital Image Processing";
            this.DIP.UseVisualStyleBackColor = true;
            this.DIP.CheckedChanged += new System.EventHandler(this.DIP_CheckedChanged);
            // 
            // SProb
            // 
            this.SProb.AutoSize = true;
            this.SProb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SProb.Location = new System.Drawing.Point(126, 224);
            this.SProb.Name = "SProb";
            this.SProb.Size = new System.Drawing.Size(265, 24);
            this.SProb.TabIndex = 1;
            this.SProb.Text = "Statics and Probability Theory";
            this.SProb.UseVisualStyleBackColor = true;
            this.SProb.CheckedChanged += new System.EventHandler(this.SProb_CheckedChanged);
            // 
            // VP
            // 
            this.VP.AutoSize = true;
            this.VP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VP.Location = new System.Drawing.Point(126, 311);
            this.VP.Name = "VP";
            this.VP.Size = new System.Drawing.Size(186, 24);
            this.VP.TabIndex = 1;
            this.VP.Text = "Visual Programming";
            this.VP.UseVisualStyleBackColor = true;
            this.VP.CheckedChanged += new System.EventHandler(this.VP_CheckedChanged);
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(172, 398);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(140, 41);
            this.next.TabIndex = 2;
            this.next.Text = "N E X T";
            this.next.UseVisualStyleBackColor = true;
            this.next.Visible = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // Q1
            // 
            this.Q1.AutoSize = true;
            this.Q1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q1.Location = new System.Drawing.Point(-3, 7);
            this.Q1.Name = "Q1";
            this.Q1.Size = new System.Drawing.Size(27, 17);
            this.Q1.TabIndex = 3;
            this.Q1.Text = "Q1";
            // 
            // Q2
            // 
            this.Q2.AutoSize = true;
            this.Q2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q2.Location = new System.Drawing.Point(-3, 57);
            this.Q2.Name = "Q2";
            this.Q2.Size = new System.Drawing.Size(27, 17);
            this.Q2.TabIndex = 3;
            this.Q2.Text = "Q2";
            // 
            // Q3
            // 
            this.Q3.AutoSize = true;
            this.Q3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q3.Location = new System.Drawing.Point(-3, 107);
            this.Q3.Name = "Q3";
            this.Q3.Size = new System.Drawing.Size(27, 17);
            this.Q3.TabIndex = 3;
            this.Q3.Text = "Q3";
            // 
            // Q4
            // 
            this.Q4.AutoSize = true;
            this.Q4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q4.Location = new System.Drawing.Point(0, 157);
            this.Q4.Name = "Q4";
            this.Q4.Size = new System.Drawing.Size(27, 17);
            this.Q4.TabIndex = 3;
            this.Q4.Text = "Q4";
            // 
            // Q5
            // 
            this.Q5.AutoSize = true;
            this.Q5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q5.Location = new System.Drawing.Point(-3, 207);
            this.Q5.Name = "Q5";
            this.Q5.Size = new System.Drawing.Size(27, 17);
            this.Q5.TabIndex = 3;
            this.Q5.Text = "Q5";
            // 
            // Q1O1
            // 
            this.Q1O1.Location = new System.Drawing.Point(28, 10);
            this.Q1O1.Name = "Q1O1";
            this.Q1O1.Size = new System.Drawing.Size(137, 17);
            this.Q1O1.TabIndex = 0;
            this.Q1O1.TabStop = true;
            this.Q1O1.Text = "Q1O1";
            this.Q1O1.UseVisualStyleBackColor = true;
            // 
            // Q1O2
            // 
            this.Q1O2.Location = new System.Drawing.Point(209, 10);
            this.Q1O2.Name = "Q1O2";
            this.Q1O2.Size = new System.Drawing.Size(164, 17);
            this.Q1O2.TabIndex = 0;
            this.Q1O2.TabStop = true;
            this.Q1O2.Text = "Q1O2";
            this.Q1O2.UseVisualStyleBackColor = true;
            // 
            // Q1O3
            // 
            this.Q1O3.Location = new System.Drawing.Point(387, 10);
            this.Q1O3.Name = "Q1O3";
            this.Q1O3.Size = new System.Drawing.Size(120, 17);
            this.Q1O3.TabIndex = 0;
            this.Q1O3.TabStop = true;
            this.Q1O3.Text = "Q1O3";
            this.Q1O3.UseVisualStyleBackColor = true;
            // 
            // Q2O1
            // 
            this.Q2O1.Location = new System.Drawing.Point(34, 4);
            this.Q2O1.Name = "Q2O1";
            this.Q2O1.Size = new System.Drawing.Size(155, 17);
            this.Q2O1.TabIndex = 0;
            this.Q2O1.TabStop = true;
            this.Q2O1.Text = "Q2O1";
            this.Q2O1.UseVisualStyleBackColor = true;
            // 
            // Q2O2
            // 
            this.Q2O2.Location = new System.Drawing.Point(215, 8);
            this.Q2O2.Name = "Q2O2";
            this.Q2O2.Size = new System.Drawing.Size(164, 17);
            this.Q2O2.TabIndex = 0;
            this.Q2O2.TabStop = true;
            this.Q2O2.Text = "Q2O2";
            this.Q2O2.UseVisualStyleBackColor = true;
            // 
            // Q2O3
            // 
            this.Q2O3.Location = new System.Drawing.Point(393, 8);
            this.Q2O3.Name = "Q2O3";
            this.Q2O3.Size = new System.Drawing.Size(133, 17);
            this.Q2O3.TabIndex = 0;
            this.Q2O3.TabStop = true;
            this.Q2O3.Text = "Q2O3";
            this.Q2O3.UseVisualStyleBackColor = true;
            // 
            // Q3O1
            // 
            this.Q3O1.Location = new System.Drawing.Point(31, 10);
            this.Q3O1.Name = "Q3O1";
            this.Q3O1.Size = new System.Drawing.Size(155, 17);
            this.Q3O1.TabIndex = 0;
            this.Q3O1.TabStop = true;
            this.Q3O1.Text = "Q3O1";
            this.Q3O1.UseVisualStyleBackColor = true;
            // 
            // Q3O2
            // 
            this.Q3O2.Location = new System.Drawing.Point(212, 10);
            this.Q3O2.Name = "Q3O2";
            this.Q3O2.Size = new System.Drawing.Size(164, 17);
            this.Q3O2.TabIndex = 0;
            this.Q3O2.TabStop = true;
            this.Q3O2.Text = "Q3O2";
            this.Q3O2.UseVisualStyleBackColor = true;
            // 
            // Q3O3
            // 
            this.Q3O3.Location = new System.Drawing.Point(390, 10);
            this.Q3O3.Name = "Q3O3";
            this.Q3O3.Size = new System.Drawing.Size(133, 17);
            this.Q3O3.TabIndex = 0;
            this.Q3O3.TabStop = true;
            this.Q3O3.Text = "Q3O3";
            this.Q3O3.UseVisualStyleBackColor = true;
            // 
            // Q4O1
            // 
            this.Q4O1.Location = new System.Drawing.Point(34, 10);
            this.Q4O1.Name = "Q4O1";
            this.Q4O1.Size = new System.Drawing.Size(113, 17);
            this.Q4O1.TabIndex = 0;
            this.Q4O1.TabStop = true;
            this.Q4O1.Text = "Q4O1";
            this.Q4O1.UseVisualStyleBackColor = true;
            // 
            // Q4O2
            // 
            this.Q4O2.Location = new System.Drawing.Point(215, 10);
            this.Q4O2.Name = "Q4O2";
            this.Q4O2.Size = new System.Drawing.Size(113, 17);
            this.Q4O2.TabIndex = 0;
            this.Q4O2.TabStop = true;
            this.Q4O2.Text = "Q4O2";
            this.Q4O2.UseVisualStyleBackColor = true;
            // 
            // Q4O3
            // 
            this.Q4O3.Location = new System.Drawing.Point(393, 10);
            this.Q4O3.Name = "Q4O3";
            this.Q4O3.Size = new System.Drawing.Size(113, 17);
            this.Q4O3.TabIndex = 0;
            this.Q4O3.TabStop = true;
            this.Q4O3.Text = "Q4O3";
            this.Q4O3.UseVisualStyleBackColor = true;
            // 
            // Q5O1
            // 
            this.Q5O1.Location = new System.Drawing.Point(34, 7);
            this.Q5O1.Name = "Q5O1";
            this.Q5O1.Size = new System.Drawing.Size(113, 17);
            this.Q5O1.TabIndex = 0;
            this.Q5O1.TabStop = true;
            this.Q5O1.Text = "Q5O1";
            this.Q5O1.UseVisualStyleBackColor = true;
            // 
            // Q5O2
            // 
            this.Q5O2.Location = new System.Drawing.Point(215, 10);
            this.Q5O2.Name = "Q5O2";
            this.Q5O2.Size = new System.Drawing.Size(113, 17);
            this.Q5O2.TabIndex = 0;
            this.Q5O2.TabStop = true;
            this.Q5O2.Text = "Q5O2";
            this.Q5O2.UseVisualStyleBackColor = true;
            // 
            // Q5O3
            // 
            this.Q5O3.Location = new System.Drawing.Point(393, 5);
            this.Q5O3.Name = "Q5O3";
            this.Q5O3.Size = new System.Drawing.Size(113, 17);
            this.Q5O3.TabIndex = 0;
            this.Q5O3.TabStop = true;
            this.Q5O3.Text = "Q5O3";
            this.Q5O3.UseVisualStyleBackColor = true;
            // 
            // Questions
            // 
            this.Questions.Controls.Add(this.Options3);
            this.Questions.Controls.Add(this.Q2);
            this.Questions.Controls.Add(this.groupBox3);
            this.Questions.Controls.Add(this.Q1);
            this.Questions.Controls.Add(this.Options4);
            this.Questions.Controls.Add(this.Q3);
            this.Questions.Controls.Add(this.Options2);
            this.Questions.Controls.Add(this.Q4);
            this.Questions.Controls.Add(this.Options1);
            this.Questions.Controls.Add(this.Q5);
            this.Questions.Location = new System.Drawing.Point(12, 64);
            this.Questions.Name = "Questions";
            this.Questions.Size = new System.Drawing.Size(515, 308);
            this.Questions.TabIndex = 4;
            this.Questions.TabStop = false;
            this.Questions.Visible = false;
            // 
            // Options3
            // 
            this.Options3.Controls.Add(this.Q3O1);
            this.Options3.Controls.Add(this.Q3O2);
            this.Options3.Controls.Add(this.Q3O3);
            this.Options3.Location = new System.Drawing.Point(3, 127);
            this.Options3.Name = "Options3";
            this.Options3.Size = new System.Drawing.Size(529, 27);
            this.Options3.TabIndex = 5;
            this.Options3.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Q5O1);
            this.groupBox3.Controls.Add(this.Q5O2);
            this.groupBox3.Controls.Add(this.Q5O3);
            this.groupBox3.Location = new System.Drawing.Point(0, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(532, 27);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // Options4
            // 
            this.Options4.Controls.Add(this.Q4O1);
            this.Options4.Controls.Add(this.Q4O2);
            this.Options4.Controls.Add(this.Q4O3);
            this.Options4.Location = new System.Drawing.Point(0, 177);
            this.Options4.Name = "Options4";
            this.Options4.Size = new System.Drawing.Size(532, 27);
            this.Options4.TabIndex = 5;
            this.Options4.TabStop = false;
            // 
            // Options2
            // 
            this.Options2.Controls.Add(this.Q2O1);
            this.Options2.Controls.Add(this.Q2O2);
            this.Options2.Controls.Add(this.Q2O3);
            this.Options2.Location = new System.Drawing.Point(0, 77);
            this.Options2.Name = "Options2";
            this.Options2.Size = new System.Drawing.Size(532, 27);
            this.Options2.TabIndex = 5;
            this.Options2.TabStop = false;
            // 
            // Options1
            // 
            this.Options1.Controls.Add(this.Q1O1);
            this.Options1.Controls.Add(this.Q1O2);
            this.Options1.Controls.Add(this.Q1O3);
            this.Options1.Location = new System.Drawing.Point(6, 27);
            this.Options1.Name = "Options1";
            this.Options1.Size = new System.Drawing.Size(526, 27);
            this.Options1.TabIndex = 5;
            this.Options1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // Score
            // 
            this.Score.Enabled = false;
            this.Score.Location = new System.Drawing.Point(437, 24);
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.Size = new System.Drawing.Size(113, 20);
            this.Score.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Score";
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(410, 398);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(140, 41);
            this.reset.TabIndex = 2;
            this.reset.Text = "R E S E T";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Visible = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 451);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Questions);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.next);
            this.Controls.Add(this.VP);
            this.Controls.Add(this.SProb);
            this.Controls.Add(this.DIP);
            this.Controls.Add(this.CCN);
            this.Controls.Add(this.label_select);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "National Testing Service";
            this.Questions.ResumeLayout(false);
            this.Questions.PerformLayout();
            this.Options3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.Options4.ResumeLayout(false);
            this.Options2.ResumeLayout(false);
            this.Options1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_select;
        private System.Windows.Forms.RadioButton CCN;
        private System.Windows.Forms.RadioButton DIP;
        private System.Windows.Forms.RadioButton SProb;
        private System.Windows.Forms.RadioButton VP;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label Q1;
        private System.Windows.Forms.Label Q2;
        private System.Windows.Forms.Label Q3;
        private System.Windows.Forms.Label Q4;
        private System.Windows.Forms.Label Q5;
        private System.Windows.Forms.RadioButton Q1O1;
        private System.Windows.Forms.RadioButton Q1O2;
        private System.Windows.Forms.RadioButton Q1O3;
        private System.Windows.Forms.RadioButton Q2O1;
        private System.Windows.Forms.RadioButton Q2O2;
        private System.Windows.Forms.RadioButton Q2O3;
        private System.Windows.Forms.RadioButton Q3O1;
        private System.Windows.Forms.RadioButton Q3O2;
        private System.Windows.Forms.RadioButton Q3O3;
        private System.Windows.Forms.RadioButton Q4O1;
        private System.Windows.Forms.RadioButton Q4O2;
        private System.Windows.Forms.RadioButton Q4O3;
        private System.Windows.Forms.RadioButton Q5O1;
        private System.Windows.Forms.RadioButton Q5O2;
        private System.Windows.Forms.RadioButton Q5O3;
        private System.Windows.Forms.GroupBox Questions;
        private System.Windows.Forms.GroupBox Options1;
        private System.Windows.Forms.GroupBox Options2;
        private System.Windows.Forms.GroupBox Options4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox Options3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Score;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button reset;
    }
}

