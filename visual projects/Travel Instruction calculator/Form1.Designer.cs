namespace Travel_Instruction_calculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pi_1 = new System.Windows.Forms.RadioButton();
            this.pi_2 = new System.Windows.Forms.RadioButton();
            this.country = new System.Windows.Forms.ComboBox();
            this.ncd_1 = new System.Windows.Forms.RadioButton();
            this.ncd_2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sc_1 = new System.Windows.Forms.RadioButton();
            this.sc_2 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Age:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Countary:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Premium Insurance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "No Claim Discount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sick Cover:";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(22, 268);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(109, 23);
            this.calculate.TabIndex = 1;
            this.calculate.Text = "Calculate Insurance";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(199, 268);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 1;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(333, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Your Insurance Premium:";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(444, 53);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(74, 18);
            this.total.TabIndex = 0;
            this.total.Text = "XXXXXX";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(93, 7);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(59, 20);
            this.age.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pi_2);
            this.groupBox1.Controls.Add(this.pi_1);
            this.groupBox1.Location = new System.Drawing.Point(158, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 18);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // pi_1
            // 
            this.pi_1.AutoSize = true;
            this.pi_1.Location = new System.Drawing.Point(6, 0);
            this.pi_1.Name = "pi_1";
            this.pi_1.Size = new System.Drawing.Size(43, 17);
            this.pi_1.TabIndex = 0;
            this.pi_1.Text = "Yes";
            this.pi_1.UseVisualStyleBackColor = true;
            // 
            // pi_2
            // 
            this.pi_2.AutoSize = true;
            this.pi_2.Checked = true;
            this.pi_2.Location = new System.Drawing.Point(97, 1);
            this.pi_2.Name = "pi_2";
            this.pi_2.Size = new System.Drawing.Size(39, 17);
            this.pi_2.TabIndex = 0;
            this.pi_2.TabStop = true;
            this.pi_2.Text = "No";
            this.pi_2.UseVisualStyleBackColor = true;
            // 
            // country
            // 
            this.country.FormattingEnabled = true;
            this.country.Items.AddRange(new object[] {
            "Pakistan",
            "America",
            "Afganistan"});
            this.country.Location = new System.Drawing.Point(93, 50);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(121, 21);
            this.country.TabIndex = 4;
            // 
            // ncd_1
            // 
            this.ncd_1.AutoSize = true;
            this.ncd_1.Location = new System.Drawing.Point(6, 0);
            this.ncd_1.Name = "ncd_1";
            this.ncd_1.Size = new System.Drawing.Size(43, 17);
            this.ncd_1.TabIndex = 0;
            this.ncd_1.Text = "Yes";
            this.ncd_1.UseVisualStyleBackColor = true;
            // 
            // ncd_2
            // 
            this.ncd_2.AutoSize = true;
            this.ncd_2.Checked = true;
            this.ncd_2.Location = new System.Drawing.Point(97, 1);
            this.ncd_2.Name = "ncd_2";
            this.ncd_2.Size = new System.Drawing.Size(39, 17);
            this.ncd_2.TabIndex = 0;
            this.ncd_2.TabStop = true;
            this.ncd_2.Text = "No";
            this.ncd_2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ncd_2);
            this.groupBox2.Controls.Add(this.ncd_1);
            this.groupBox2.Location = new System.Drawing.Point(158, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 18);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // sc_1
            // 
            this.sc_1.AutoSize = true;
            this.sc_1.Location = new System.Drawing.Point(6, 0);
            this.sc_1.Name = "sc_1";
            this.sc_1.Size = new System.Drawing.Size(43, 17);
            this.sc_1.TabIndex = 0;
            this.sc_1.Text = "Yes";
            this.sc_1.UseVisualStyleBackColor = true;
            // 
            // sc_2
            // 
            this.sc_2.AutoSize = true;
            this.sc_2.Checked = true;
            this.sc_2.Location = new System.Drawing.Point(97, 1);
            this.sc_2.Name = "sc_2";
            this.sc_2.Size = new System.Drawing.Size(39, 17);
            this.sc_2.TabIndex = 0;
            this.sc_2.TabStop = true;
            this.sc_2.Text = "No";
            this.sc_2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sc_2);
            this.groupBox3.Controls.Add(this.sc_1);
            this.groupBox3.Location = new System.Drawing.Point(158, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 18);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 299);
            this.Controls.Add(this.country);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.age);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Insurance Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton pi_2;
        private System.Windows.Forms.RadioButton pi_1;
        private System.Windows.Forms.ComboBox country;
        private System.Windows.Forms.RadioButton ncd_1;
        private System.Windows.Forms.RadioButton ncd_2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton sc_1;
        private System.Windows.Forms.RadioButton sc_2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

