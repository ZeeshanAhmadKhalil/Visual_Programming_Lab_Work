namespace Sessional1Q3
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
            this.Add_item = new System.Windows.Forms.Button();
            this.Count_items = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Remove_item = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_item
            // 
            this.Add_item.Location = new System.Drawing.Point(77, 239);
            this.Add_item.Name = "Add_item";
            this.Add_item.Size = new System.Drawing.Size(75, 23);
            this.Add_item.TabIndex = 0;
            this.Add_item.Text = "Add item";
            this.Add_item.UseVisualStyleBackColor = true;
            this.Add_item.Click += new System.EventHandler(this.Add_item_Click);
            // 
            // Count_items
            // 
            this.Count_items.Location = new System.Drawing.Point(201, 239);
            this.Count_items.Name = "Count_items";
            this.Count_items.Size = new System.Drawing.Size(75, 23);
            this.Count_items.TabIndex = 0;
            this.Count_items.Text = "Count Items";
            this.Count_items.UseVisualStyleBackColor = true;
            this.Count_items.Click += new System.EventHandler(this.Count_items_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 20);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(77, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // Remove_item
            // 
            this.Remove_item.Location = new System.Drawing.Point(132, 210);
            this.Remove_item.Name = "Remove_item";
            this.Remove_item.Size = new System.Drawing.Size(105, 23);
            this.Remove_item.TabIndex = 3;
            this.Remove_item.Text = "Remove Item";
            this.Remove_item.UseVisualStyleBackColor = true;
            this.Remove_item.Click += new System.EventHandler(this.Remove_item_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 324);
            this.Controls.Add(this.Remove_item);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Count_items);
            this.Controls.Add(this.Add_item);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_item;
        private System.Windows.Forms.Button Count_items;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Remove_item;
    }
}

