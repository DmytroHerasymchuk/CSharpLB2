namespace CSharpLB2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.CreationPanel = new System.Windows.Forms.Panel();
            this.CreationButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.BudgetTextBox = new System.Windows.Forms.TextBox();
            this.CountOfEmployeesTextBox = new System.Windows.Forms.TextBox();
            this.IncomeTextBox = new System.Windows.Forms.TextBox();
            this.CostsTextBox = new System.Windows.Forms.TextBox();
            this.CountDepTextBox = new System.Windows.Forms.TextBox();
            this.CountOfGoodsTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ListAllButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ListAllPanel = new System.Windows.Forms.Panel();
            this.CompareButton = new System.Windows.Forms.Button();
            this.SecondComboBox = new System.Windows.Forms.ComboBox();
            this.FirstComboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ToStringButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.FireEmployeeButton = new System.Windows.Forms.Button();
            this.HireEmployeeButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.AllShopsGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CreationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.ListAllPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllShopsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCreate.Location = new System.Drawing.Point(12, 12);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(140, 34);
            this.ButtonCreate.TabIndex = 0;
            this.ButtonCreate.Text = "Create New Shop";
            this.ButtonCreate.UseVisualStyleBackColor = true;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // CreationPanel
            // 
            this.CreationPanel.Controls.Add(this.CreationButton);
            this.CreationPanel.Controls.Add(this.label9);
            this.CreationPanel.Controls.Add(this.AddressTextBox);
            this.CreationPanel.Controls.Add(this.BudgetTextBox);
            this.CreationPanel.Controls.Add(this.CountOfEmployeesTextBox);
            this.CreationPanel.Controls.Add(this.IncomeTextBox);
            this.CreationPanel.Controls.Add(this.CostsTextBox);
            this.CreationPanel.Controls.Add(this.CountDepTextBox);
            this.CreationPanel.Controls.Add(this.CountOfGoodsTextBox);
            this.CreationPanel.Controls.Add(this.NameTextBox);
            this.CreationPanel.Controls.Add(this.label8);
            this.CreationPanel.Controls.Add(this.label7);
            this.CreationPanel.Controls.Add(this.label6);
            this.CreationPanel.Controls.Add(this.label5);
            this.CreationPanel.Controls.Add(this.label4);
            this.CreationPanel.Controls.Add(this.label3);
            this.CreationPanel.Controls.Add(this.label2);
            this.CreationPanel.Controls.Add(this.label1);
            this.CreationPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreationPanel.Location = new System.Drawing.Point(12, 52);
            this.CreationPanel.Name = "CreationPanel";
            this.CreationPanel.Size = new System.Drawing.Size(1171, 612);
            this.CreationPanel.TabIndex = 1;
            // 
            // CreationButton
            // 
            this.CreationButton.Location = new System.Drawing.Point(222, 311);
            this.CreationButton.Name = "CreationButton";
            this.CreationButton.Size = new System.Drawing.Size(193, 39);
            this.CreationButton.TabIndex = 17;
            this.CreationButton.Text = "Create";
            this.CreationButton.UseVisualStyleBackColor = true;
            this.CreationButton.Click += new System.EventHandler(this.CreationButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(31, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 39);
            this.label9.TabIndex = 16;
            this.label9.Text = "Creation";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(420, 52);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(193, 26);
            this.AddressTextBox.TabIndex = 15;
            this.AddressTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddressTextBox_Validating);
            // 
            // BudgetTextBox
            // 
            this.BudgetTextBox.Location = new System.Drawing.Point(11, 239);
            this.BudgetTextBox.Name = "BudgetTextBox";
            this.BudgetTextBox.Size = new System.Drawing.Size(205, 26);
            this.BudgetTextBox.TabIndex = 14;
            this.BudgetTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.BudgetTextBox_Validating);
            // 
            // CountOfEmployeesTextBox
            // 
            this.CountOfEmployeesTextBox.Location = new System.Drawing.Point(420, 239);
            this.CountOfEmployeesTextBox.Name = "CountOfEmployeesTextBox";
            this.CountOfEmployeesTextBox.Size = new System.Drawing.Size(193, 26);
            this.CountOfEmployeesTextBox.TabIndex = 13;
            this.CountOfEmployeesTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CountOfEmployeesTextBox_Validating);
            // 
            // IncomeTextBox
            // 
            this.IncomeTextBox.Location = new System.Drawing.Point(11, 178);
            this.IncomeTextBox.Name = "IncomeTextBox";
            this.IncomeTextBox.Size = new System.Drawing.Size(205, 26);
            this.IncomeTextBox.TabIndex = 12;
            this.IncomeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.IncomeTextBox_Validating);
            // 
            // CostsTextBox
            // 
            this.CostsTextBox.Location = new System.Drawing.Point(420, 116);
            this.CostsTextBox.Name = "CostsTextBox";
            this.CostsTextBox.Size = new System.Drawing.Size(193, 26);
            this.CostsTextBox.TabIndex = 11;
            this.CostsTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CostsTextBox_Validating);
            // 
            // CountDepTextBox
            // 
            this.CountDepTextBox.Location = new System.Drawing.Point(11, 116);
            this.CountDepTextBox.Name = "CountDepTextBox";
            this.CountDepTextBox.Size = new System.Drawing.Size(205, 26);
            this.CountDepTextBox.TabIndex = 10;
            this.CountDepTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CountDepTextBox_Validating);
            // 
            // CountOfGoodsTextBox
            // 
            this.CountOfGoodsTextBox.Location = new System.Drawing.Point(420, 178);
            this.CountOfGoodsTextBox.Name = "CountOfGoodsTextBox";
            this.CountOfGoodsTextBox.Size = new System.Drawing.Size(193, 26);
            this.CountOfGoodsTextBox.TabIndex = 9;
            this.CountOfGoodsTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CountOfGoodsTextBox_Validating);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(11, 52);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(205, 26);
            this.NameTextBox.TabIndex = 8;
            this.NameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NameTextBox_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(416, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Costs of goods";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Budget of Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Count of goods";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Average Month Income";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Count of employees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Count of departments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // ListAllButton
            // 
            this.ListAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListAllButton.Location = new System.Drawing.Point(158, 12);
            this.ListAllButton.Name = "ListAllButton";
            this.ListAllButton.Size = new System.Drawing.Size(140, 34);
            this.ListAllButton.TabIndex = 2;
            this.ListAllButton.Text = "Show All Shops";
            this.ListAllButton.UseVisualStyleBackColor = true;
            this.ListAllButton.Click += new System.EventHandler(this.ListAllButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ListAllPanel
            // 
            this.ListAllPanel.Controls.Add(this.CompareButton);
            this.ListAllPanel.Controls.Add(this.SecondComboBox);
            this.ListAllPanel.Controls.Add(this.FirstComboBox);
            this.ListAllPanel.Controls.Add(this.label15);
            this.ListAllPanel.Controls.Add(this.ToStringButton);
            this.ListAllPanel.Controls.Add(this.label12);
            this.ListAllPanel.Controls.Add(this.FireEmployeeButton);
            this.ListAllPanel.Controls.Add(this.HireEmployeeButton);
            this.ListAllPanel.Controls.Add(this.label11);
            this.ListAllPanel.Controls.Add(this.AllShopsGrid);
            this.ListAllPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListAllPanel.Location = new System.Drawing.Point(12, 52);
            this.ListAllPanel.Name = "ListAllPanel";
            this.ListAllPanel.Size = new System.Drawing.Size(1644, 659);
            this.ListAllPanel.TabIndex = 3;
            // 
            // CompareButton
            // 
            this.CompareButton.Location = new System.Drawing.Point(1181, 603);
            this.CompareButton.Name = "CompareButton";
            this.CompareButton.Size = new System.Drawing.Size(115, 40);
            this.CompareButton.TabIndex = 22;
            this.CompareButton.Text = "Compare";
            this.CompareButton.UseVisualStyleBackColor = true;
            this.CompareButton.Click += new System.EventHandler(this.CompareButton_Click);
            // 
            // SecondComboBox
            // 
            this.SecondComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondComboBox.FormattingEnabled = true;
            this.SecondComboBox.Location = new System.Drawing.Point(1269, 483);
            this.SecondComboBox.Name = "SecondComboBox";
            this.SecondComboBox.Size = new System.Drawing.Size(136, 26);
            this.SecondComboBox.TabIndex = 21;
            // 
            // FirstComboBox
            // 
            this.FirstComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstComboBox.FormattingEnabled = true;
            this.FirstComboBox.Location = new System.Drawing.Point(1066, 483);
            this.FirstComboBox.Name = "FirstComboBox";
            this.FirstComboBox.Size = new System.Drawing.Size(141, 26);
            this.FirstComboBox.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(1177, 450);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 20);
            this.label15.TabIndex = 19;
            this.label15.Text = "Compare Shops";
            // 
            // ToStringButton
            // 
            this.ToStringButton.Location = new System.Drawing.Point(889, 596);
            this.ToStringButton.Name = "ToStringButton";
            this.ToStringButton.Size = new System.Drawing.Size(115, 40);
            this.ToStringButton.TabIndex = 10;
            this.ToStringButton.Text = "ToString";
            this.ToStringButton.UseVisualStyleBackColor = true;
            this.ToStringButton.Click += new System.EventHandler(this.ToStringButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(908, 563);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "To String";
            // 
            // FireEmployeeButton
            // 
            this.FireEmployeeButton.Location = new System.Drawing.Point(146, 483);
            this.FireEmployeeButton.Name = "FireEmployeeButton";
            this.FireEmployeeButton.Size = new System.Drawing.Size(115, 40);
            this.FireEmployeeButton.TabIndex = 8;
            this.FireEmployeeButton.Text = "Fire";
            this.FireEmployeeButton.UseVisualStyleBackColor = true;
            this.FireEmployeeButton.Click += new System.EventHandler(this.FireEmployeeButton_Click);
            // 
            // HireEmployeeButton
            // 
            this.HireEmployeeButton.Location = new System.Drawing.Point(11, 483);
            this.HireEmployeeButton.Name = "HireEmployeeButton";
            this.HireEmployeeButton.Size = new System.Drawing.Size(115, 40);
            this.HireEmployeeButton.TabIndex = 7;
            this.HireEmployeeButton.Text = "Hire";
            this.HireEmployeeButton.UseVisualStyleBackColor = true;
            this.HireEmployeeButton.Click += new System.EventHandler(this.HireEmployeeButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(86, 450);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Employees";
            // 
            // AllShopsGrid
            // 
            this.AllShopsGrid.AllowUserToResizeColumns = false;
            this.AllShopsGrid.AllowUserToResizeRows = false;
            this.AllShopsGrid.BackgroundColor = System.Drawing.SystemColors.Info;
            this.AllShopsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllShopsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.AllShopsGrid.Location = new System.Drawing.Point(0, 0);
            this.AllShopsGrid.Name = "AllShopsGrid";
            this.AllShopsGrid.RowHeadersWidth = 51;
            this.AllShopsGrid.RowTemplate.Height = 24;
            this.AllShopsGrid.Size = new System.Drawing.Size(1405, 430);
            this.AllShopsGrid.TabIndex = 0;
            this.AllShopsGrid.VirtualMode = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Address";
            this.Column2.HeaderText = "Address";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NumberOfDepartments";
            this.Column3.HeaderText = "Number of Departments";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NumberOfEmployees";
            this.Column4.HeaderText = "Number of Employees";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "AverageMonthlyMoneyIncome";
            this.Column5.HeaderText = "Monthly Income";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "AllSalaryOfEmployees";
            this.Column6.HeaderText = "Salary Budget";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "AllCostsOfGoods";
            this.Column7.HeaderText = "Costs of Goods";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "CountOfGoods";
            this.Column8.HeaderText = "Number of Goods";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.Width = 125;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(1277, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(140, 34);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 741);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ListAllButton);
            this.Controls.Add(this.ListAllPanel);
            this.Controls.Add(this.CreationPanel);
            this.Controls.Add(this.ButtonCreate);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CreationPanel.ResumeLayout(false);
            this.CreationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ListAllPanel.ResumeLayout(false);
            this.ListAllPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllShopsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.Panel CreationPanel;
        private System.Windows.Forms.Button ListAllButton;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox BudgetTextBox;
        private System.Windows.Forms.TextBox CountOfEmployeesTextBox;
        private System.Windows.Forms.TextBox IncomeTextBox;
        private System.Windows.Forms.TextBox CostsTextBox;
        private System.Windows.Forms.TextBox CountDepTextBox;
        private System.Windows.Forms.TextBox CountOfGoodsTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreationButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel ListAllPanel;
        private System.Windows.Forms.DataGridView AllShopsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button FireEmployeeButton;
        private System.Windows.Forms.Button HireEmployeeButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button ToStringButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox SecondComboBox;
        private System.Windows.Forms.ComboBox FirstComboBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button CompareButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

