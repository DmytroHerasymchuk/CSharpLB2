namespace CSharpLB2.View
{
    partial class EmployeesForm
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
            this.CreatePerson = new System.Windows.Forms.Button();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.SalaryTB = new System.Windows.Forms.TextBox();
            this.EducationCB = new System.Windows.Forms.ComboBox();
            this.PositionCB = new System.Windows.Forms.ComboBox();
            this.BirthdayDT = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IpnTB = new System.Windows.Forms.TextBox();
            this.FireAllButton = new System.Windows.Forms.Button();
            this.FireIPNButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // CreatePerson
            // 
            this.CreatePerson.Location = new System.Drawing.Point(156, 398);
            this.CreatePerson.Margin = new System.Windows.Forms.Padding(4);
            this.CreatePerson.Name = "CreatePerson";
            this.CreatePerson.Size = new System.Drawing.Size(198, 49);
            this.CreatePerson.TabIndex = 0;
            this.CreatePerson.Text = "Hire Employee";
            this.CreatePerson.UseVisualStyleBackColor = true;
            this.CreatePerson.Click += new System.EventHandler(this.CreatePerson_Click);
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(29, 71);
            this.NameTB.Margin = new System.Windows.Forms.Padding(4);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(143, 27);
            this.NameTB.TabIndex = 1;
            this.NameTB.Validating += new System.ComponentModel.CancelEventHandler(this.NameTB_Validating);
            // 
            // LastNameTB
            // 
            this.LastNameTB.Location = new System.Drawing.Point(29, 139);
            this.LastNameTB.Margin = new System.Windows.Forms.Padding(4);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(143, 27);
            this.LastNameTB.TabIndex = 2;
            this.LastNameTB.Validating += new System.ComponentModel.CancelEventHandler(this.LastNameTB_Validating);
            // 
            // SalaryTB
            // 
            this.SalaryTB.Location = new System.Drawing.Point(29, 213);
            this.SalaryTB.Margin = new System.Windows.Forms.Padding(4);
            this.SalaryTB.Name = "SalaryTB";
            this.SalaryTB.Size = new System.Drawing.Size(143, 27);
            this.SalaryTB.TabIndex = 3;
            this.SalaryTB.Validating += new System.ComponentModel.CancelEventHandler(this.SalaryTB_Validating);
            // 
            // EducationCB
            // 
            this.EducationCB.FormattingEnabled = true;
            this.EducationCB.Location = new System.Drawing.Point(328, 70);
            this.EducationCB.Margin = new System.Windows.Forms.Padding(4);
            this.EducationCB.Name = "EducationCB";
            this.EducationCB.Size = new System.Drawing.Size(150, 28);
            this.EducationCB.TabIndex = 5;
            // 
            // PositionCB
            // 
            this.PositionCB.FormattingEnabled = true;
            this.PositionCB.Location = new System.Drawing.Point(328, 138);
            this.PositionCB.Margin = new System.Windows.Forms.Padding(4);
            this.PositionCB.Name = "PositionCB";
            this.PositionCB.Size = new System.Drawing.Size(150, 28);
            this.PositionCB.TabIndex = 6;
            // 
            // BirthdayDT
            // 
            this.BirthdayDT.Location = new System.Drawing.Point(29, 300);
            this.BirthdayDT.Margin = new System.Windows.Forms.Padding(4);
            this.BirthdayDT.Name = "BirthdayDT";
            this.BirthdayDT.Size = new System.Drawing.Size(199, 27);
            this.BirthdayDT.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lastname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Salary:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bitrhday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Education:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Position:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NameTB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PositionCB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.EducationCB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BirthdayDT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CreatePerson);
            this.groupBox1.Controls.Add(this.LastNameTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SalaryTB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 496);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiring";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.IpnTB);
            this.groupBox2.Controls.Add(this.FireAllButton);
            this.groupBox2.Controls.Add(this.FireIPNButton);
            this.groupBox2.Location = new System.Drawing.Point(562, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 496);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Firing";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "IPN:";
            // 
            // IpnTB
            // 
            this.IpnTB.Location = new System.Drawing.Point(254, 70);
            this.IpnTB.Margin = new System.Windows.Forms.Padding(4);
            this.IpnTB.Name = "IpnTB";
            this.IpnTB.Size = new System.Drawing.Size(143, 27);
            this.IpnTB.TabIndex = 9;
            this.IpnTB.Validating += new System.ComponentModel.CancelEventHandler(this.IpnTB_Validating);
            // 
            // FireAllButton
            // 
            this.FireAllButton.Location = new System.Drawing.Point(116, 398);
            this.FireAllButton.Margin = new System.Windows.Forms.Padding(4);
            this.FireAllButton.Name = "FireAllButton";
            this.FireAllButton.Size = new System.Drawing.Size(198, 49);
            this.FireAllButton.TabIndex = 8;
            this.FireAllButton.Text = "Fire All";
            this.FireAllButton.UseVisualStyleBackColor = true;
            this.FireAllButton.Click += new System.EventHandler(this.FireAllButton_Click);
            // 
            // FireIPNButton
            // 
            this.FireIPNButton.Location = new System.Drawing.Point(25, 59);
            this.FireIPNButton.Margin = new System.Windows.Forms.Padding(4);
            this.FireIPNButton.Name = "FireIPNButton";
            this.FireIPNButton.Size = new System.Drawing.Size(198, 49);
            this.FireIPNButton.TabIndex = 7;
            this.FireIPNButton.Text = "Fire by IPN";
            this.FireIPNButton.UseVisualStyleBackColor = true;
            this.FireIPNButton.Click += new System.EventHandler(this.FireIPNButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 525);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeesForm";
            this.Text = "ShopInfoForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreatePerson;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.TextBox SalaryTB;
        private System.Windows.Forms.ComboBox EducationCB;
        private System.Windows.Forms.ComboBox PositionCB;
        private System.Windows.Forms.DateTimePicker BirthdayDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button FireAllButton;
        private System.Windows.Forms.Button FireIPNButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IpnTB;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}