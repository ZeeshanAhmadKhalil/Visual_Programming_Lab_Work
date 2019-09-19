namespace Addition_Form
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
            this.tempreture = new System.Windows.Forms.RadioButton();
            this.currency1 = new System.Windows.Forms.RadioButton();
            this.temprature1 = new System.Windows.Forms.RadioButton();
            this.weight = new System.Windows.Forms.RadioButton();
            this.length = new System.Windows.Forms.RadioButton();
            this.currency = new System.Windows.Forms.RadioButton();
            this.Box1 = new System.Windows.Forms.TextBox();
            this.Text1 = new System.Windows.Forms.Label();
            this.Box2 = new System.Windows.Forms.TextBox();
            this.Text2 = new System.Windows.Forms.Label();
            this.Convert = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.currency1);
            this.groupBox1.Controls.Add(this.tempreture);
            this.groupBox1.Controls.Add(this.length);
            this.groupBox1.Controls.Add(this.temprature1);
            this.groupBox1.Controls.Add(this.currency);
            this.groupBox1.Controls.Add(this.weight);
            this.groupBox1.Location = new System.Drawing.Point(7, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 91);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversion Option";
            // 
            // tempreture
            // 
            this.tempreture.AutoSize = true;
            this.tempreture.Checked = true;
            this.tempreture.Location = new System.Drawing.Point(27, 19);
            this.tempreture.Name = "tempreture";
            this.tempreture.Size = new System.Drawing.Size(103, 17);
            this.tempreture.TabIndex = 4;
            this.tempreture.TabStop = true;
            this.tempreture.Text = "Temprature(F/C)";
            this.tempreture.UseVisualStyleBackColor = true;
            this.tempreture.CheckedChanged += new System.EventHandler(this.tempreture_CheckedChanged);
            // 
            // currency1
            // 
            this.currency1.AutoSize = true;
            this.currency1.Location = new System.Drawing.Point(144, 65);
            this.currency1.Name = "currency1";
            this.currency1.Size = new System.Drawing.Size(115, 17);
            this.currency1.TabIndex = 9;
            this.currency1.Text = "Currency(US/Pak) ";
            this.currency1.UseVisualStyleBackColor = true;
            this.currency1.CheckedChanged += new System.EventHandler(this.currency1_CheckedChanged);
            // 
            // temprature1
            // 
            this.temprature1.AutoSize = true;
            this.temprature1.Location = new System.Drawing.Point(27, 65);
            this.temprature1.Name = "temprature1";
            this.temprature1.Size = new System.Drawing.Size(103, 17);
            this.temprature1.TabIndex = 6;
            this.temprature1.Text = "Temprature(C/F)";
            this.temprature1.UseVisualStyleBackColor = true;
            this.temprature1.CheckedChanged += new System.EventHandler(this.temprature1_CheckedChanged);
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Location = new System.Drawing.Point(144, 42);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(59, 17);
            this.weight.TabIndex = 8;
            this.weight.Text = "Weight";
            this.weight.UseVisualStyleBackColor = true;
            this.weight.CheckedChanged += new System.EventHandler(this.weight_CheckedChanged_1);
            // 
            // length
            // 
            this.length.AutoSize = true;
            this.length.Location = new System.Drawing.Point(144, 19);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(58, 17);
            this.length.TabIndex = 7;
            this.length.Text = "Length";
            this.length.UseVisualStyleBackColor = true;
            this.length.CheckedChanged += new System.EventHandler(this.length_CheckedChanged_1);
            // 
            // currency
            // 
            this.currency.AutoSize = true;
            this.currency.Location = new System.Drawing.Point(27, 42);
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(115, 17);
            this.currency.TabIndex = 5;
            this.currency.Text = "Currency(US/Pak) ";
            this.currency.UseVisualStyleBackColor = true;
            this.currency.CheckedChanged += new System.EventHandler(this.currency_CheckedChanged_1);
            // 
            // Box1
            // 
            this.Box1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box1.Location = new System.Drawing.Point(9, 34);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(240, 30);
            this.Box1.TabIndex = 1;
            // 
            // Text1
            // 
            this.Text1.AutoSize = true;
            this.Text1.Location = new System.Drawing.Point(6, 18);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(51, 13);
            this.Text1.TabIndex = 2;
            this.Text1.Text = "Farenhite";
            // 
            // Box2
            // 
            this.Box2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Box2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box2.Location = new System.Drawing.Point(9, 102);
            this.Box2.Name = "Box2";
            this.Box2.ReadOnly = true;
            this.Box2.Size = new System.Drawing.Size(240, 30);
            this.Box2.TabIndex = 1;
            this.Box2.TabStop = false;
            // 
            // Text2
            // 
            this.Text2.AutoSize = true;
            this.Text2.Location = new System.Drawing.Point(6, 86);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(41, 13);
            this.Text2.TabIndex = 2;
            this.Text2.Text = "Celcius";
            // 
            // Convert
            // 
            this.Convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convert.Location = new System.Drawing.Point(42, 152);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(150, 57);
            this.Convert.TabIndex = 2;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 346);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton currency1;
        private System.Windows.Forms.RadioButton temprature1;
        private System.Windows.Forms.RadioButton weight;
        private System.Windows.Forms.RadioButton length;
        private System.Windows.Forms.RadioButton currency;
        private System.Windows.Forms.RadioButton tempreture;
        private System.Windows.Forms.TextBox Box1;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.TextBox Box2;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.Button Convert;
    }
}

