namespace Multi_Converter_1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Length_box = new System.Windows.Forms.GroupBox();
            this.Length_m_i = new System.Windows.Forms.RadioButton();
            this.Length_f_m = new System.Windows.Forms.RadioButton();
            this.Length_m_f = new System.Windows.Forms.RadioButton();
            this.Weight_box = new System.Windows.Forms.GroupBox();
            this.Weight_k_o = new System.Windows.Forms.RadioButton();
            this.Weight_p_k = new System.Windows.Forms.RadioButton();
            this.Weight_k_p = new System.Windows.Forms.RadioButton();
            this.Currency_box = new System.Windows.Forms.GroupBox();
            this.Currency_p_u = new System.Windows.Forms.RadioButton();
            this.Currency_u_i = new System.Windows.Forms.RadioButton();
            this.Currency_u_p = new System.Windows.Forms.RadioButton();
            this.temp_box = new System.Windows.Forms.GroupBox();
            this.Temp_k_c = new System.Windows.Forms.RadioButton();
            this.Temp_f_k = new System.Windows.Forms.RadioButton();
            this.Temp_c_f = new System.Windows.Forms.RadioButton();
            this.Length = new System.Windows.Forms.RadioButton();
            this.Weight = new System.Windows.Forms.RadioButton();
            this.Currency = new System.Windows.Forms.RadioButton();
            this.Temp = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Convert = new System.Windows.Forms.Button();
            this.unit2 = new System.Windows.Forms.Label();
            this.unit1 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TextBox();
            this.Input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Length_box.SuspendLayout();
            this.Weight_box.SuspendLayout();
            this.Currency_box.SuspendLayout();
            this.temp_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = global::Multi_Converter_1.Properties.Resources.fc6e75413ae6f552f802ffb0b3ce620a__marvel_dc_comics_antman_marvel;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = global::Multi_Converter_1.Properties.Resources.Ant_Man_Art_969x545;
            this.splitContainer1.Panel2.Controls.Add(this.Convert);
            this.splitContainer1.Panel2.Controls.Add(this.unit2);
            this.splitContainer1.Panel2.Controls.Add(this.unit1);
            this.splitContainer1.Panel2.Controls.Add(this.Result);
            this.splitContainer1.Panel2.Controls.Add(this.Input);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainer1.Size = new System.Drawing.Size(545, 456);
            this.splitContainer1.SplitterDistance = 207;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Length_box);
            this.groupBox1.Controls.Add(this.Weight_box);
            this.groupBox1.Controls.Add(this.Currency_box);
            this.groupBox1.Controls.Add(this.temp_box);
            this.groupBox1.Controls.Add(this.Length);
            this.groupBox1.Controls.Add(this.Weight);
            this.groupBox1.Controls.Add(this.Currency);
            this.groupBox1.Controls.Add(this.Temp);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 397);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // Length_box
            // 
            this.Length_box.Controls.Add(this.Length_m_i);
            this.Length_box.Controls.Add(this.Length_f_m);
            this.Length_box.Controls.Add(this.Length_m_f);
            this.Length_box.Location = new System.Drawing.Point(21, 308);
            this.Length_box.Name = "Length_box";
            this.Length_box.Size = new System.Drawing.Size(138, 76);
            this.Length_box.TabIndex = 4;
            this.Length_box.TabStop = false;
            this.Length_box.Visible = false;
            // 
            // Length_m_i
            // 
            this.Length_m_i.AutoSize = true;
            this.Length_m_i.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Length_m_i.Location = new System.Drawing.Point(7, 53);
            this.Length_m_i.Name = "Length_m_i";
            this.Length_m_i.Size = new System.Drawing.Size(98, 17);
            this.Length_m_i.TabIndex = 2;
            this.Length_m_i.TabStop = true;
            this.Length_m_i.Text = "Meter to inches";
            this.Length_m_i.UseVisualStyleBackColor = true;
            this.Length_m_i.CheckedChanged += new System.EventHandler(this.Length_m_i_CheckedChanged);
            // 
            // Length_f_m
            // 
            this.Length_f_m.AutoSize = true;
            this.Length_f_m.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Length_f_m.Location = new System.Drawing.Point(7, 30);
            this.Length_f_m.Name = "Length_f_m";
            this.Length_f_m.Size = new System.Drawing.Size(87, 17);
            this.Length_f_m.TabIndex = 1;
            this.Length_f_m.TabStop = true;
            this.Length_f_m.Text = "Feet to metre";
            this.Length_f_m.UseVisualStyleBackColor = true;
            this.Length_f_m.CheckedChanged += new System.EventHandler(this.Length_f_m_CheckedChanged);
            // 
            // Length_m_f
            // 
            this.Length_m_f.AutoSize = true;
            this.Length_m_f.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Length_m_f.Location = new System.Drawing.Point(6, 7);
            this.Length_m_f.Name = "Length_m_f";
            this.Length_m_f.Size = new System.Drawing.Size(88, 17);
            this.Length_m_f.TabIndex = 0;
            this.Length_m_f.TabStop = true;
            this.Length_m_f.Text = "Metre to Feet";
            this.Length_m_f.UseVisualStyleBackColor = true;
            this.Length_m_f.CheckedChanged += new System.EventHandler(this.Length_m_f_CheckedChanged);
            // 
            // Weight_box
            // 
            this.Weight_box.Controls.Add(this.Weight_k_o);
            this.Weight_box.Controls.Add(this.Weight_p_k);
            this.Weight_box.Controls.Add(this.Weight_k_p);
            this.Weight_box.Location = new System.Drawing.Point(22, 213);
            this.Weight_box.Name = "Weight_box";
            this.Weight_box.Size = new System.Drawing.Size(138, 76);
            this.Weight_box.TabIndex = 4;
            this.Weight_box.TabStop = false;
            this.Weight_box.Visible = false;
            // 
            // Weight_k_o
            // 
            this.Weight_k_o.AutoSize = true;
            this.Weight_k_o.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Weight_k_o.Location = new System.Drawing.Point(7, 53);
            this.Weight_k_o.Name = "Weight_k_o";
            this.Weight_k_o.Size = new System.Drawing.Size(90, 17);
            this.Weight_k_o.TabIndex = 2;
            this.Weight_k_o.TabStop = true;
            this.Weight_k_o.Text = "Kg to Ounces";
            this.Weight_k_o.UseVisualStyleBackColor = true;
            this.Weight_k_o.CheckedChanged += new System.EventHandler(this.Weight_k_o_CheckedChanged);
            // 
            // Weight_p_k
            // 
            this.Weight_p_k.AutoSize = true;
            this.Weight_p_k.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Weight_p_k.Location = new System.Drawing.Point(7, 30);
            this.Weight_p_k.Name = "Weight_p_k";
            this.Weight_p_k.Size = new System.Drawing.Size(84, 17);
            this.Weight_p_k.TabIndex = 1;
            this.Weight_p_k.TabStop = true;
            this.Weight_p_k.Text = "Pound to Kg";
            this.Weight_p_k.UseVisualStyleBackColor = true;
            this.Weight_p_k.CheckedChanged += new System.EventHandler(this.Weight_p_k_CheckedChanged);
            // 
            // Weight_k_p
            // 
            this.Weight_k_p.AutoSize = true;
            this.Weight_k_p.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Weight_k_p.Location = new System.Drawing.Point(6, 7);
            this.Weight_k_p.Name = "Weight_k_p";
            this.Weight_k_p.Size = new System.Drawing.Size(84, 17);
            this.Weight_k_p.TabIndex = 0;
            this.Weight_k_p.TabStop = true;
            this.Weight_k_p.Text = "Kg to Pound";
            this.Weight_k_p.UseVisualStyleBackColor = true;
            this.Weight_k_p.CheckedChanged += new System.EventHandler(this.Weight_k_p_CheckedChanged);
            // 
            // Currency_box
            // 
            this.Currency_box.Controls.Add(this.Currency_p_u);
            this.Currency_box.Controls.Add(this.Currency_u_i);
            this.Currency_box.Controls.Add(this.Currency_u_p);
            this.Currency_box.Location = new System.Drawing.Point(22, 121);
            this.Currency_box.Name = "Currency_box";
            this.Currency_box.Size = new System.Drawing.Size(138, 76);
            this.Currency_box.TabIndex = 4;
            this.Currency_box.TabStop = false;
            this.Currency_box.Visible = false;
            // 
            // Currency_p_u
            // 
            this.Currency_p_u.AutoSize = true;
            this.Currency_p_u.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Currency_p_u.Location = new System.Drawing.Point(7, 53);
            this.Currency_p_u.Name = "Currency_p_u";
            this.Currency_p_u.Size = new System.Drawing.Size(74, 17);
            this.Currency_p_u.TabIndex = 2;
            this.Currency_p_u.TabStop = true;
            this.Currency_p_u.Text = "Pak to US";
            this.Currency_p_u.UseVisualStyleBackColor = true;
            this.Currency_p_u.CheckedChanged += new System.EventHandler(this.Currency_p_u_CheckedChanged);
            // 
            // Currency_u_i
            // 
            this.Currency_u_i.AutoSize = true;
            this.Currency_u_i.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Currency_u_i.Location = new System.Drawing.Point(7, 30);
            this.Currency_u_i.Name = "Currency_u_i";
            this.Currency_u_i.Size = new System.Drawing.Size(105, 17);
            this.Currency_u_i.TabIndex = 1;
            this.Currency_u_i.TabStop = true;
            this.Currency_u_i.Text = "US to Ind Rupee";
            this.Currency_u_i.UseVisualStyleBackColor = true;
            this.Currency_u_i.CheckedChanged += new System.EventHandler(this.Currency_u_i_CheckedChanged);
            // 
            // Currency_u_p
            // 
            this.Currency_u_p.AutoSize = true;
            this.Currency_u_p.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Currency_u_p.Location = new System.Drawing.Point(6, 7);
            this.Currency_u_p.Name = "Currency_u_p";
            this.Currency_u_p.Size = new System.Drawing.Size(109, 17);
            this.Currency_u_p.TabIndex = 0;
            this.Currency_u_p.TabStop = true;
            this.Currency_u_p.Text = "US to Pak Rupee";
            this.Currency_u_p.UseVisualStyleBackColor = true;
            this.Currency_u_p.CheckedChanged += new System.EventHandler(this.Currency_u_p_CheckedChanged);
            // 
            // temp_box
            // 
            this.temp_box.Controls.Add(this.Temp_k_c);
            this.temp_box.Controls.Add(this.Temp_f_k);
            this.temp_box.Controls.Add(this.Temp_c_f);
            this.temp_box.Location = new System.Drawing.Point(23, 26);
            this.temp_box.Name = "temp_box";
            this.temp_box.Size = new System.Drawing.Size(138, 76);
            this.temp_box.TabIndex = 4;
            this.temp_box.TabStop = false;
            this.temp_box.Visible = false;
            // 
            // Temp_k_c
            // 
            this.Temp_k_c.AutoSize = true;
            this.Temp_k_c.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Temp_k_c.Location = new System.Drawing.Point(7, 53);
            this.Temp_k_c.Name = "Temp_k_c";
            this.Temp_k_c.Size = new System.Drawing.Size(103, 17);
            this.Temp_k_c.TabIndex = 2;
            this.Temp_k_c.TabStop = true;
            this.Temp_k_c.Text = "Kelvin to Celcius";
            this.Temp_k_c.UseVisualStyleBackColor = true;
            this.Temp_k_c.CheckedChanged += new System.EventHandler(this.Temp_k_c_CheckedChanged);
            // 
            // Temp_f_k
            // 
            this.Temp_f_k.AutoSize = true;
            this.Temp_f_k.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Temp_f_k.Location = new System.Drawing.Point(7, 30);
            this.Temp_f_k.Name = "Temp_f_k";
            this.Temp_f_k.Size = new System.Drawing.Size(113, 17);
            this.Temp_f_k.TabIndex = 1;
            this.Temp_f_k.TabStop = true;
            this.Temp_f_k.Text = "Farenhite to Kelvin";
            this.Temp_f_k.UseVisualStyleBackColor = true;
            this.Temp_f_k.CheckedChanged += new System.EventHandler(this.Temp_f_k_CheckedChanged);
            // 
            // Temp_c_f
            // 
            this.Temp_c_f.AutoSize = true;
            this.Temp_c_f.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Temp_c_f.Location = new System.Drawing.Point(6, 7);
            this.Temp_c_f.Name = "Temp_c_f";
            this.Temp_c_f.Size = new System.Drawing.Size(118, 17);
            this.Temp_c_f.TabIndex = 0;
            this.Temp_c_f.TabStop = true;
            this.Temp_c_f.Text = "Celcius to Farenhite";
            this.Temp_c_f.UseVisualStyleBackColor = true;
            this.Temp_c_f.CheckedChanged += new System.EventHandler(this.Temp_c_f_CheckedChanged);
            // 
            // Length
            // 
            this.Length.AutoSize = true;
            this.Length.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Length.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Length.Location = new System.Drawing.Point(15, 289);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(64, 17);
            this.Length.TabIndex = 3;
            this.Length.TabStop = true;
            this.Length.Text = "Length";
            this.Length.UseVisualStyleBackColor = true;
            this.Length.CheckedChanged += new System.EventHandler(this.Length_CheckedChanged);
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weight.Location = new System.Drawing.Point(15, 197);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(65, 17);
            this.Weight.TabIndex = 2;
            this.Weight.TabStop = true;
            this.Weight.Text = "Weight";
            this.Weight.UseVisualStyleBackColor = true;
            this.Weight.CheckedChanged += new System.EventHandler(this.Weight_CheckedChanged);
            // 
            // Currency
            // 
            this.Currency.AutoSize = true;
            this.Currency.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Currency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Currency.Location = new System.Drawing.Point(16, 102);
            this.Currency.Name = "Currency";
            this.Currency.Size = new System.Drawing.Size(75, 17);
            this.Currency.TabIndex = 1;
            this.Currency.TabStop = true;
            this.Currency.Text = "Currency";
            this.Currency.UseVisualStyleBackColor = true;
            this.Currency.CheckedChanged += new System.EventHandler(this.Currency_CheckedChanged);
            // 
            // Temp
            // 
            this.Temp.AutoSize = true;
            this.Temp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temp.Location = new System.Drawing.Point(16, 11);
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(89, 17);
            this.Temp.TabIndex = 0;
            this.Temp.TabStop = true;
            this.Temp.Text = "Temprature";
            this.Temp.UseVisualStyleBackColor = true;
            this.Temp.CheckedChanged += new System.EventHandler(this.Temp_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convertion Type";
            // 
            // Convert
            // 
            this.Convert.BackgroundImage = global::Multi_Converter_1.Properties.Resources.Ant_Man_Art_969x5452;
            this.Convert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convert.Location = new System.Drawing.Point(98, 317);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(107, 53);
            this.Convert.TabIndex = 4;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // unit2
            // 
            this.unit2.AutoSize = true;
            this.unit2.BackColor = System.Drawing.Color.Transparent;
            this.unit2.Location = new System.Drawing.Point(205, 208);
            this.unit2.Name = "unit2";
            this.unit2.Size = new System.Drawing.Size(0, 13);
            this.unit2.TabIndex = 3;
            // 
            // unit1
            // 
            this.unit1.AutoSize = true;
            this.unit1.BackColor = System.Drawing.Color.Transparent;
            this.unit1.Location = new System.Drawing.Point(205, 110);
            this.unit1.Name = "unit1";
            this.unit1.Size = new System.Drawing.Size(0, 13);
            this.unit1.TabIndex = 3;
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Result.Cursor = System.Windows.Forms.Cursors.No;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(14, 224);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(276, 27);
            this.Result.TabIndex = 2;
            // 
            // Input
            // 
            this.Input.BackColor = System.Drawing.Color.Snow;
            this.Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.Location = new System.Drawing.Point(14, 126);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(276, 27);
            this.Input.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Conversion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Multi_Converter_1.Properties.Resources.fc6e75413ae6f552f802ffb0b3ce620a__marvel_dc_comics_antman_marvel;
            this.ClientSize = new System.Drawing.Size(545, 456);
            this.Controls.Add(this.splitContainer1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi Converter";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Length_box.ResumeLayout(false);
            this.Length_box.PerformLayout();
            this.Weight_box.ResumeLayout(false);
            this.Weight_box.PerformLayout();
            this.Currency_box.ResumeLayout(false);
            this.Currency_box.PerformLayout();
            this.temp_box.ResumeLayout(false);
            this.temp_box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Length;
        private System.Windows.Forms.RadioButton Weight;
        private System.Windows.Forms.RadioButton Currency;
        private System.Windows.Forms.RadioButton Temp;
        private System.Windows.Forms.GroupBox temp_box;
        private System.Windows.Forms.RadioButton Temp_k_c;
        private System.Windows.Forms.RadioButton Temp_f_k;
        private System.Windows.Forms.RadioButton Temp_c_f;
        private System.Windows.Forms.GroupBox Weight_box;
        private System.Windows.Forms.RadioButton Weight_k_o;
        private System.Windows.Forms.RadioButton Weight_p_k;
        private System.Windows.Forms.RadioButton Weight_k_p;
        private System.Windows.Forms.GroupBox Currency_box;
        private System.Windows.Forms.RadioButton Currency_p_u;
        private System.Windows.Forms.RadioButton Currency_u_i;
        private System.Windows.Forms.RadioButton Currency_u_p;
        private System.Windows.Forms.GroupBox Length_box;
        private System.Windows.Forms.RadioButton Length_m_i;
        private System.Windows.Forms.RadioButton Length_f_m;
        private System.Windows.Forms.RadioButton Length_m_f;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Label unit2;
        private System.Windows.Forms.Label unit1;
        private System.Windows.Forms.Button Convert;

    }
}

