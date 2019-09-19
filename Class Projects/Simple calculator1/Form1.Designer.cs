namespace Simple_calculator1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.substraction = new System.Windows.Forms.RadioButton();
            this.addition = new System.Windows.Forms.RadioButton();
            this.clear = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ans = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.substraction);
            this.groupBox1.Controls.Add(this.addition);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(259, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 135);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // substraction
            // 
            this.substraction.AutoSize = true;
            this.substraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.substraction.Location = new System.Drawing.Point(6, 83);
            this.substraction.Name = "substraction";
            this.substraction.Size = new System.Drawing.Size(109, 22);
            this.substraction.TabIndex = 4;
            this.substraction.Text = "Substraction";
            this.substraction.UseVisualStyleBackColor = true;
            // 
            // addition
            // 
            this.addition.AutoSize = true;
            this.addition.Checked = true;
            this.addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addition.Location = new System.Drawing.Point(6, 36);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(78, 22);
            this.addition.TabIndex = 4;
            this.addition.TabStop = true;
            this.addition.Text = "Addition";
            this.addition.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(129, 270);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 36);
            this.clear.TabIndex = 12;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(12, 270);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(86, 36);
            this.calculate.TabIndex = 11;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter Second Number";
            // 
            // ans
            // 
            this.ans.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ans.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans.Location = new System.Drawing.Point(12, 207);
            this.ans.Name = "ans";
            this.ans.ReadOnly = true;
            this.ans.Size = new System.Drawing.Size(192, 24);
            this.ans.TabIndex = 5;
            this.ans.TabStop = false;
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(12, 109);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(192, 24);
            this.num2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter First Number";
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(12, 36);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(192, 24);
            this.num1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 335);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calcukator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton substraction;
        private System.Windows.Forms.RadioButton addition;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ans;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num1;
    }
}

