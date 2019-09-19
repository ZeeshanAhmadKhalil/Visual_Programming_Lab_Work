namespace WindowsFormsApplication1
{
    partial class Employee
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label bPSLabel;
            System.Windows.Forms.Label salaryLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.emp_infoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.emp_infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDataSet1 = new WindowsFormsApplication1.EmployeeDataSet1();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.emp_infoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.bPSTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.emp_infoTableAdapter = new WindowsFormsApplication1.EmployeeDataSet1TableAdapters.Emp_infoTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.EmployeeDataSet1TableAdapters.TableAdapterManager();
            this.marriedCheckBox = new System.Windows.Forms.CheckBox();
            this.emp_infoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            bPSLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.emp_infoBindingNavigator)).BeginInit();
            this.emp_infoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emp_infoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_infoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(34, 95);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(34, 121);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // bPSLabel
            // 
            bPSLabel.AutoSize = true;
            bPSLabel.Location = new System.Drawing.Point(34, 147);
            bPSLabel.Name = "bPSLabel";
            bPSLabel.Size = new System.Drawing.Size(31, 13);
            bPSLabel.TabIndex = 5;
            bPSLabel.Text = "BPS:";
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new System.Drawing.Point(34, 173);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(39, 13);
            salaryLabel.TabIndex = 7;
            salaryLabel.Text = "Salary:";
            // 
            // emp_infoBindingNavigator
            // 
            this.emp_infoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.emp_infoBindingNavigator.BindingSource = this.emp_infoBindingSource;
            this.emp_infoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.emp_infoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.emp_infoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.emp_infoBindingNavigatorSaveItem});
            this.emp_infoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.emp_infoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.emp_infoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.emp_infoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.emp_infoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.emp_infoBindingNavigator.Name = "emp_infoBindingNavigator";
            this.emp_infoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.emp_infoBindingNavigator.Size = new System.Drawing.Size(809, 25);
            this.emp_infoBindingNavigator.TabIndex = 0;
            this.emp_infoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // emp_infoBindingSource
            // 
            this.emp_infoBindingSource.DataMember = "Emp_info";
            this.emp_infoBindingSource.DataSource = this.employeeDataSet1;
            // 
            // employeeDataSet1
            // 
            this.employeeDataSet1.DataSetName = "EmployeeDataSet1";
            this.employeeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // emp_infoBindingNavigatorSaveItem
            // 
            this.emp_infoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.emp_infoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("emp_infoBindingNavigatorSaveItem.Image")));
            this.emp_infoBindingNavigatorSaveItem.Name = "emp_infoBindingNavigatorSaveItem";
            this.emp_infoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.emp_infoBindingNavigatorSaveItem.Text = "Save Data";
            this.emp_infoBindingNavigatorSaveItem.Click += new System.EventHandler(this.emp_infoBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emp_infoBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(79, 92);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(155, 20);
            this.iDTextBox.TabIndex = 2;
            this.iDTextBox.TextChanged += new System.EventHandler(this.iDTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emp_infoBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(79, 118);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(155, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // bPSTextBox
            // 
            this.bPSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emp_infoBindingSource, "BPS", true));
            this.bPSTextBox.Location = new System.Drawing.Point(79, 144);
            this.bPSTextBox.Name = "bPSTextBox";
            this.bPSTextBox.Size = new System.Drawing.Size(155, 20);
            this.bPSTextBox.TabIndex = 6;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emp_infoBindingSource, "Salary", true));
            this.salaryTextBox.Location = new System.Drawing.Point(79, 170);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(155, 20);
            this.salaryTextBox.TabIndex = 8;
            // 
            // emp_infoTableAdapter
            // 
            this.emp_infoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Emp_infoTableAdapter = this.emp_infoTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.EmployeeDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // marriedCheckBox
            // 
            this.marriedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.emp_infoBindingSource, "Married", true));
            this.marriedCheckBox.Location = new System.Drawing.Point(79, 196);
            this.marriedCheckBox.Name = "marriedCheckBox";
            this.marriedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.marriedCheckBox.TabIndex = 11;
            this.marriedCheckBox.Text = "Married";
            this.marriedCheckBox.UseVisualStyleBackColor = true;
            // 
            // emp_infoDataGridView
            // 
            this.emp_infoDataGridView.AutoGenerateColumns = false;
            this.emp_infoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emp_infoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.emp_infoDataGridView.DataSource = this.emp_infoBindingSource;
            this.emp_infoDataGridView.Location = new System.Drawing.Point(278, 64);
            this.emp_infoDataGridView.Name = "emp_infoDataGridView";
            this.emp_infoDataGridView.Size = new System.Drawing.Size(519, 220);
            this.emp_infoDataGridView.TabIndex = 11;
            this.emp_infoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.emp_infoDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BPS";
            this.dataGridViewTextBoxColumn3.HeaderText = "BPS";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Salary";
            this.dataGridViewTextBoxColumn4.HeaderText = "Salary";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Married";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Married";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(108, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 332);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.emp_infoDataGridView);
            this.Controls.Add(this.marriedCheckBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(bPSLabel);
            this.Controls.Add(this.bPSTextBox);
            this.Controls.Add(salaryLabel);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.emp_infoBindingNavigator);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emp_infoBindingNavigator)).EndInit();
            this.emp_infoBindingNavigator.ResumeLayout(false);
            this.emp_infoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emp_infoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_infoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EmployeeDataSet1 employeeDataSet1;
        private System.Windows.Forms.BindingSource emp_infoBindingSource;
        private EmployeeDataSet1TableAdapters.Emp_infoTableAdapter emp_infoTableAdapter;
        private EmployeeDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator emp_infoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton emp_infoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox bPSTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.CheckBox marriedCheckBox;
        private System.Windows.Forms.DataGridView emp_infoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

