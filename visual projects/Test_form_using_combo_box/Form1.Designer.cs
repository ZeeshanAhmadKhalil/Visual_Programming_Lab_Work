namespace Test_form_using_combo_box
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
            this.label1 = new System.Windows.Forms.Label();
            this.Subject = new System.Windows.Forms.ComboBox();
            this.Begin = new System.Windows.Forms.Button();
            this.Questions = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Q3O2 = new System.Windows.Forms.RadioButton();
            this.Q3O3 = new System.Windows.Forms.RadioButton();
            this.Q3O1 = new System.Windows.Forms.RadioButton();
            this.Q3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Q2O2 = new System.Windows.Forms.RadioButton();
            this.Q2O3 = new System.Windows.Forms.RadioButton();
            this.Q2O1 = new System.Windows.Forms.RadioButton();
            this.Q2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Q1O2 = new System.Windows.Forms.RadioButton();
            this.Q1O3 = new System.Windows.Forms.RadioButton();
            this.Q1O1 = new System.Windows.Forms.RadioButton();
            this.Q1 = new System.Windows.Forms.Label();
            this.Selection = new System.Windows.Forms.GroupBox();
            this.Score = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.marks1 = new System.Windows.Forms.Label();
            this.Questions.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Selection.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select A Subject For Test :";
            // 
            // Subject
            // 
            this.Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject.FormattingEnabled = true;
            this.Subject.Items.AddRange(new object[] {
            "Maths",
            "Computer"});
            this.Subject.Location = new System.Drawing.Point(232, 15);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(134, 21);
            this.Subject.TabIndex = 1;
            // 
            // Begin
            // 
            this.Begin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Begin.Location = new System.Drawing.Point(119, 65);
            this.Begin.Name = "Begin";
            this.Begin.Size = new System.Drawing.Size(141, 30);
            this.Begin.TabIndex = 2;
            this.Begin.Text = "* Begin Test *";
            this.Begin.UseVisualStyleBackColor = true;
            this.Begin.Click += new System.EventHandler(this.Begin_Click);
            // 
            // Questions
            // 
            this.Questions.Controls.Add(this.groupBox5);
            this.Questions.Controls.Add(this.Q3);
            this.Questions.Controls.Add(this.groupBox4);
            this.Questions.Controls.Add(this.Q2);
            this.Questions.Controls.Add(this.groupBox3);
            this.Questions.Controls.Add(this.Q1);
            this.Questions.Enabled = false;
            this.Questions.Location = new System.Drawing.Point(12, 120);
            this.Questions.Name = "Questions";
            this.Questions.Size = new System.Drawing.Size(392, 227);
            this.Questions.TabIndex = 3;
            this.Questions.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Q3O2);
            this.groupBox5.Controls.Add(this.Q3O3);
            this.groupBox5.Controls.Add(this.Q3O1);
            this.groupBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox5.Location = new System.Drawing.Point(6, 183);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(380, 38);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // Q3O2
            // 
            this.Q3O2.AutoSize = true;
            this.Q3O2.Location = new System.Drawing.Point(135, 15);
            this.Q3O2.Name = "Q3O2";
            this.Q3O2.Size = new System.Drawing.Size(57, 17);
            this.Q3O2.TabIndex = 1;
            this.Q3O2.TabStop = true;
            this.Q3O2.Text = "Q3O2";
            this.Q3O2.UseVisualStyleBackColor = true;
            // 
            // Q3O3
            // 
            this.Q3O3.AutoSize = true;
            this.Q3O3.Location = new System.Drawing.Point(275, 15);
            this.Q3O3.Name = "Q3O3";
            this.Q3O3.Size = new System.Drawing.Size(57, 17);
            this.Q3O3.TabIndex = 1;
            this.Q3O3.TabStop = true;
            this.Q3O3.Text = "Q3O3";
            this.Q3O3.UseVisualStyleBackColor = true;
            // 
            // Q3O1
            // 
            this.Q3O1.AutoSize = true;
            this.Q3O1.Location = new System.Drawing.Point(6, 15);
            this.Q3O1.Name = "Q3O1";
            this.Q3O1.Size = new System.Drawing.Size(57, 17);
            this.Q3O1.TabIndex = 1;
            this.Q3O1.TabStop = true;
            this.Q3O1.Text = "Q3O1";
            this.Q3O1.UseVisualStyleBackColor = true;
            // 
            // Q3
            // 
            this.Q3.AutoSize = true;
            this.Q3.Location = new System.Drawing.Point(6, 167);
            this.Q3.Name = "Q3";
            this.Q3.Size = new System.Drawing.Size(23, 13);
            this.Q3.TabIndex = 0;
            this.Q3.Text = "Q3";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Q2O2);
            this.groupBox4.Controls.Add(this.Q2O3);
            this.groupBox4.Controls.Add(this.Q2O1);
            this.groupBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox4.Location = new System.Drawing.Point(9, 103);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(380, 38);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // Q2O2
            // 
            this.Q2O2.AutoSize = true;
            this.Q2O2.Location = new System.Drawing.Point(135, 15);
            this.Q2O2.Name = "Q2O2";
            this.Q2O2.Size = new System.Drawing.Size(57, 17);
            this.Q2O2.TabIndex = 1;
            this.Q2O2.TabStop = true;
            this.Q2O2.Text = "Q2O2";
            this.Q2O2.UseVisualStyleBackColor = true;
            // 
            // Q2O3
            // 
            this.Q2O3.AutoSize = true;
            this.Q2O3.Location = new System.Drawing.Point(275, 15);
            this.Q2O3.Name = "Q2O3";
            this.Q2O3.Size = new System.Drawing.Size(57, 17);
            this.Q2O3.TabIndex = 1;
            this.Q2O3.TabStop = true;
            this.Q2O3.Text = "Q2O3";
            this.Q2O3.UseVisualStyleBackColor = true;
            // 
            // Q2O1
            // 
            this.Q2O1.AutoSize = true;
            this.Q2O1.Location = new System.Drawing.Point(6, 15);
            this.Q2O1.Name = "Q2O1";
            this.Q2O1.Size = new System.Drawing.Size(57, 17);
            this.Q2O1.TabIndex = 1;
            this.Q2O1.TabStop = true;
            this.Q2O1.Text = "Q2O1";
            this.Q2O1.UseVisualStyleBackColor = true;
            // 
            // Q2
            // 
            this.Q2.AutoSize = true;
            this.Q2.Location = new System.Drawing.Point(9, 87);
            this.Q2.Name = "Q2";
            this.Q2.Size = new System.Drawing.Size(23, 13);
            this.Q2.TabIndex = 0;
            this.Q2.Text = "Q2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Q1O2);
            this.groupBox3.Controls.Add(this.Q1O3);
            this.groupBox3.Controls.Add(this.Q1O1);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox3.Location = new System.Drawing.Point(6, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 38);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // Q1O2
            // 
            this.Q1O2.AutoSize = true;
            this.Q1O2.Location = new System.Drawing.Point(135, 15);
            this.Q1O2.Name = "Q1O2";
            this.Q1O2.Size = new System.Drawing.Size(57, 17);
            this.Q1O2.TabIndex = 1;
            this.Q1O2.TabStop = true;
            this.Q1O2.Text = "Q1O2";
            this.Q1O2.UseVisualStyleBackColor = true;
            // 
            // Q1O3
            // 
            this.Q1O3.AutoSize = true;
            this.Q1O3.Location = new System.Drawing.Point(275, 15);
            this.Q1O3.Name = "Q1O3";
            this.Q1O3.Size = new System.Drawing.Size(57, 17);
            this.Q1O3.TabIndex = 1;
            this.Q1O3.TabStop = true;
            this.Q1O3.Text = "Q1O3";
            this.Q1O3.UseVisualStyleBackColor = true;
            // 
            // Q1O1
            // 
            this.Q1O1.AutoSize = true;
            this.Q1O1.Location = new System.Drawing.Point(6, 15);
            this.Q1O1.Name = "Q1O1";
            this.Q1O1.Size = new System.Drawing.Size(57, 17);
            this.Q1O1.TabIndex = 1;
            this.Q1O1.TabStop = true;
            this.Q1O1.Text = "Q1O1";
            this.Q1O1.UseVisualStyleBackColor = true;
            // 
            // Q1
            // 
            this.Q1.AutoSize = true;
            this.Q1.Location = new System.Drawing.Point(6, 15);
            this.Q1.Name = "Q1";
            this.Q1.Size = new System.Drawing.Size(23, 13);
            this.Q1.TabIndex = 0;
            this.Q1.Text = "Q1";
            // 
            // Selection
            // 
            this.Selection.Controls.Add(this.label1);
            this.Selection.Controls.Add(this.Begin);
            this.Selection.Controls.Add(this.Subject);
            this.Selection.Location = new System.Drawing.Point(12, 12);
            this.Selection.Name = "Selection";
            this.Selection.Size = new System.Drawing.Size(392, 102);
            this.Selection.TabIndex = 4;
            this.Selection.TabStop = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(306, 364);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(47, 13);
            this.Score.TabIndex = 5;
            this.Score.Text = "Score=";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(14, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // marks1
            // 
            this.marks1.AutoSize = true;
            this.marks1.Location = new System.Drawing.Point(355, 365);
            this.marks1.Name = "marks1";
            this.marks1.Size = new System.Drawing.Size(0, 13);
            this.marks1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 386);
            this.Controls.Add(this.marks1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Selection);
            this.Controls.Add(this.Questions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Form";
            this.Questions.ResumeLayout(false);
            this.Questions.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Selection.ResumeLayout(false);
            this.Selection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Subject;
        private System.Windows.Forms.Button Begin;
        private System.Windows.Forms.GroupBox Questions;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton Q1O2;
        private System.Windows.Forms.RadioButton Q1O3;
        private System.Windows.Forms.RadioButton Q1O1;
        private System.Windows.Forms.Label Q1;
        private System.Windows.Forms.GroupBox Selection;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton Q3O2;
        private System.Windows.Forms.RadioButton Q3O3;
        private System.Windows.Forms.RadioButton Q3O1;
        private System.Windows.Forms.Label Q3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton Q2O2;
        private System.Windows.Forms.RadioButton Q2O3;
        private System.Windows.Forms.RadioButton Q2O1;
        private System.Windows.Forms.Label Q2;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label marks1;
    }
}

