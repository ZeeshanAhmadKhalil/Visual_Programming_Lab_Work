namespace WebBrowser
{
    partial class SettingsForm
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
            this.homelabel = new System.Windows.Forms.Label();
            this.homePagetextBox = new System.Windows.Forms.TextBox();
            this.Savebutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // homelabel
            // 
            this.homelabel.AutoSize = true;
            this.homelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homelabel.Location = new System.Drawing.Point(12, 45);
            this.homelabel.Name = "homelabel";
            this.homelabel.Size = new System.Drawing.Size(107, 20);
            this.homelabel.TabIndex = 0;
            this.homelabel.Text = "Home Page:";
            //this.homelabel.Click += new System.EventHandler(this.homelabel_Click);
            // 
            // homePagetextBox
            // 
            this.homePagetextBox.Location = new System.Drawing.Point(125, 47);
            this.homePagetextBox.Name = "homePagetextBox";
            this.homePagetextBox.Size = new System.Drawing.Size(306, 20);
            this.homePagetextBox.TabIndex = 1;
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(125, 113);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(75, 23);
            this.Savebutton.TabIndex = 2;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(356, 113);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 2;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 158);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.homePagetextBox);
            this.Controls.Add(this.homelabel);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings Option";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label homelabel;
        private System.Windows.Forms.TextBox homePagetextBox;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button Cancelbutton;
    }
}