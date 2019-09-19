namespace Hospital_patient_interface
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Initial_buttons = new System.Windows.Forms.GroupBox();
            this.insert_data_box = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.Disease = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Show_data_box = new System.Windows.Forms.GroupBox();
            this.Show_all_button = new System.Windows.Forms.Button();
            this.ID_search = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.show_data_button = new System.Windows.Forms.Button();
            this.delete_data_box = new System.Windows.Forms.GroupBox();
            this.Delete_button = new System.Windows.Forms.Button();
            this.id_to_delete = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.go_back = new System.Windows.Forms.Button();
            this.Modify_Data_box = new System.Windows.Forms.GroupBox();
            this.Modify_button = new System.Windows.Forms.Button();
            this.Disease_Modify = new System.Windows.Forms.TextBox();
            this.Name_Modify = new System.Windows.Forms.TextBox();
            this.ID_modify = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Initial_buttons.SuspendLayout();
            this.insert_data_box.SuspendLayout();
            this.Show_data_box.SuspendLayout();
            this.delete_data_box.SuspendLayout();
            this.Modify_Data_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 48);
            this.button2.TabIndex = 0;
            this.button2.Text = "Insert Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 48);
            this.button3.TabIndex = 0;
            this.button3.Text = "Delete Data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(114, 89);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 48);
            this.button4.TabIndex = 0;
            this.button4.Text = "Modify Data";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select the transaction you want to perform";
            // 
            // Initial_buttons
            // 
            this.Initial_buttons.BackColor = System.Drawing.Color.Transparent;
            this.Initial_buttons.Controls.Add(this.button1);
            this.Initial_buttons.Controls.Add(this.button2);
            this.Initial_buttons.Controls.Add(this.button4);
            this.Initial_buttons.Controls.Add(this.button3);
            this.Initial_buttons.Location = new System.Drawing.Point(55, 99);
            this.Initial_buttons.Name = "Initial_buttons";
            this.Initial_buttons.Size = new System.Drawing.Size(193, 155);
            this.Initial_buttons.TabIndex = 2;
            this.Initial_buttons.TabStop = false;
            // 
            // insert_data_box
            // 
            this.insert_data_box.BackColor = System.Drawing.Color.Transparent;
            this.insert_data_box.Controls.Add(this.button5);
            this.insert_data_box.Controls.Add(this.Disease);
            this.insert_data_box.Controls.Add(this.Name);
            this.insert_data_box.Controls.Add(this.ID);
            this.insert_data_box.Controls.Add(this.label4);
            this.insert_data_box.Controls.Add(this.label3);
            this.insert_data_box.Controls.Add(this.label2);
            this.insert_data_box.Location = new System.Drawing.Point(40, 80);
            this.insert_data_box.Name = "insert_data_box";
            this.insert_data_box.Size = new System.Drawing.Size(302, 220);
            this.insert_data_box.TabIndex = 2;
            this.insert_data_box.TabStop = false;
            this.insert_data_box.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(197, 168);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Insert";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Disease
            // 
            this.Disease.Location = new System.Drawing.Point(87, 125);
            this.Disease.Name = "Disease";
            this.Disease.Size = new System.Drawing.Size(185, 20);
            this.Disease.TabIndex = 1;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(87, 79);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(185, 20);
            this.Name.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(87, 31);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(185, 20);
            this.ID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Disease:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // Show_data_box
            // 
            this.Show_data_box.BackColor = System.Drawing.Color.Transparent;
            this.Show_data_box.Controls.Add(this.Show_all_button);
            this.Show_data_box.Controls.Add(this.ID_search);
            this.Show_data_box.Controls.Add(this.label10);
            this.Show_data_box.Controls.Add(this.listView1);
            this.Show_data_box.Controls.Add(this.show_data_button);
            this.Show_data_box.Location = new System.Drawing.Point(42, 80);
            this.Show_data_box.Name = "Show_data_box";
            this.Show_data_box.Size = new System.Drawing.Size(297, 233);
            this.Show_data_box.TabIndex = 1;
            this.Show_data_box.TabStop = false;
            this.Show_data_box.Visible = false;
            // 
            // Show_all_button
            // 
            this.Show_all_button.Location = new System.Drawing.Point(114, 165);
            this.Show_all_button.Name = "Show_all_button";
            this.Show_all_button.Size = new System.Drawing.Size(75, 23);
            this.Show_all_button.TabIndex = 7;
            this.Show_all_button.Text = "Show All";
            this.Show_all_button.UseVisualStyleBackColor = true;
            this.Show_all_button.Click += new System.EventHandler(this.Show_all_button_Click);
            // 
            // ID_search
            // 
            this.ID_search.Location = new System.Drawing.Point(102, 194);
            this.ID_search.Name = "ID_search";
            this.ID_search.Size = new System.Drawing.Size(185, 20);
            this.ID_search.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 18);
            this.label10.TabIndex = 5;
            this.label10.Text = "ID:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(277, 127);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 31;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 52;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Disease";
            // 
            // show_data_button
            // 
            this.show_data_button.Location = new System.Drawing.Point(208, 165);
            this.show_data_button.Name = "show_data_button";
            this.show_data_button.Size = new System.Drawing.Size(75, 23);
            this.show_data_button.TabIndex = 1;
            this.show_data_button.Text = "Show Data";
            this.show_data_button.UseVisualStyleBackColor = true;
            this.show_data_button.Click += new System.EventHandler(this.show_data_button_Click);
            // 
            // delete_data_box
            // 
            this.delete_data_box.BackColor = System.Drawing.Color.Transparent;
            this.delete_data_box.Controls.Add(this.Delete_button);
            this.delete_data_box.Controls.Add(this.id_to_delete);
            this.delete_data_box.Controls.Add(this.label5);
            this.delete_data_box.Location = new System.Drawing.Point(33, 85);
            this.delete_data_box.Name = "delete_data_box";
            this.delete_data_box.Size = new System.Drawing.Size(309, 215);
            this.delete_data_box.TabIndex = 3;
            this.delete_data_box.TabStop = false;
            this.delete_data_box.Visible = false;
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(195, 104);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(75, 23);
            this.Delete_button.TabIndex = 5;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // id_to_delete
            // 
            this.id_to_delete.Location = new System.Drawing.Point(85, 72);
            this.id_to_delete.Name = "id_to_delete";
            this.id_to_delete.Size = new System.Drawing.Size(185, 20);
            this.id_to_delete.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "ID:";
            // 
            // go_back
            // 
            this.go_back.Location = new System.Drawing.Point(12, 59);
            this.go_back.Name = "go_back";
            this.go_back.Size = new System.Drawing.Size(75, 23);
            this.go_back.TabIndex = 3;
            this.go_back.Text = "<< Go Back";
            this.go_back.UseVisualStyleBackColor = true;
            this.go_back.Visible = false;
            this.go_back.Click += new System.EventHandler(this.go_back_Click);
            // 
            // Modify_Data_box
            // 
            this.Modify_Data_box.BackColor = System.Drawing.Color.Transparent;
            this.Modify_Data_box.Controls.Add(this.Modify_button);
            this.Modify_Data_box.Controls.Add(this.Disease_Modify);
            this.Modify_Data_box.Controls.Add(this.Name_Modify);
            this.Modify_Data_box.Controls.Add(this.ID_modify);
            this.Modify_Data_box.Controls.Add(this.label6);
            this.Modify_Data_box.Controls.Add(this.label7);
            this.Modify_Data_box.Controls.Add(this.label8);
            this.Modify_Data_box.Location = new System.Drawing.Point(33, 85);
            this.Modify_Data_box.Name = "Modify_Data_box";
            this.Modify_Data_box.Size = new System.Drawing.Size(335, 207);
            this.Modify_Data_box.TabIndex = 4;
            this.Modify_Data_box.TabStop = false;
            this.Modify_Data_box.Visible = false;
            // 
            // Modify_button
            // 
            this.Modify_button.Location = new System.Drawing.Point(214, 176);
            this.Modify_button.Name = "Modify_button";
            this.Modify_button.Size = new System.Drawing.Size(75, 23);
            this.Modify_button.TabIndex = 9;
            this.Modify_button.Text = "Modify";
            this.Modify_button.UseVisualStyleBackColor = true;
            this.Modify_button.Click += new System.EventHandler(this.Modify_button_Click);
            // 
            // Disease_Modify
            // 
            this.Disease_Modify.Location = new System.Drawing.Point(104, 133);
            this.Disease_Modify.Name = "Disease_Modify";
            this.Disease_Modify.Size = new System.Drawing.Size(185, 20);
            this.Disease_Modify.TabIndex = 6;
            // 
            // Name_Modify
            // 
            this.Name_Modify.Location = new System.Drawing.Point(104, 87);
            this.Name_Modify.Name = "Name_Modify";
            this.Name_Modify.Size = new System.Drawing.Size(185, 20);
            this.Name_Modify.TabIndex = 7;
            // 
            // ID_modify
            // 
            this.ID_modify.Location = new System.Drawing.Point(104, 39);
            this.ID_modify.Name = "ID_modify";
            this.ID_modify.Size = new System.Drawing.Size(185, 20);
            this.ID_modify.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Disease:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "ID:";
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(339, 6);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(32, 26);
            this.X.TabIndex = 5;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = true;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Hospital_patient_interface.Properties.Resources.icons8_therapy_50;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Magneto", 13.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(75, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(254, 22);
            this.label9.TabIndex = 7;
            this.label9.Text = "Jinnah Hospital Karachi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hospital_patient_interface.Properties.Resources._new;
            this.ClientSize = new System.Drawing.Size(375, 325);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.X);
            this.Controls.Add(this.Modify_Data_box);
            this.Controls.Add(this.delete_data_box);
            this.Controls.Add(this.Show_data_box);
            this.Controls.Add(this.insert_data_box);
            this.Controls.Add(this.go_back);
            this.Controls.Add(this.Initial_buttons);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Patient";
            this.Initial_buttons.ResumeLayout(false);
            this.insert_data_box.ResumeLayout(false);
            this.insert_data_box.PerformLayout();
            this.Show_data_box.ResumeLayout(false);
            this.Show_data_box.PerformLayout();
            this.delete_data_box.ResumeLayout(false);
            this.delete_data_box.PerformLayout();
            this.Modify_Data_box.ResumeLayout(false);
            this.Modify_Data_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Initial_buttons;
        private System.Windows.Forms.GroupBox Show_data_box;
        private System.Windows.Forms.Button show_data_button;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox insert_data_box;
        private System.Windows.Forms.TextBox Disease;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox delete_data_box;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.TextBox id_to_delete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button go_back;
        private System.Windows.Forms.GroupBox Modify_Data_box;
        private System.Windows.Forms.Button Modify_button;
        private System.Windows.Forms.TextBox Disease_Modify;
        private System.Windows.Forms.TextBox Name_Modify;
        private System.Windows.Forms.TextBox ID_modify;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ID_search;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Show_all_button;
    }
}

