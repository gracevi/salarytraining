namespace FormSalary
{
    partial class MainForm
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
            this.AddPersonnelButton = new System.Windows.Forms.Button();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.PositionListBox = new System.Windows.Forms.ListBox();
            this.HireDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PnpPersonnelGridView = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrossPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LongPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deductions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PnpPersonnelGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(666, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hire Date";
            // 
            // AddPersonnelButton
            // 
            this.AddPersonnelButton.Location = new System.Drawing.Point(56, 195);
            this.AddPersonnelButton.Name = "AddPersonnelButton";
            this.AddPersonnelButton.Size = new System.Drawing.Size(139, 39);
            this.AddPersonnelButton.TabIndex = 4;
            this.AddPersonnelButton.Text = "Add Personnel";
            this.AddPersonnelButton.UseVisualStyleBackColor = true;
            this.AddPersonnelButton.Click += new System.EventHandler(this.AddPersonnelButton_Click);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(56, 103);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(139, 26);
            this.FirstNameTextBox.TabIndex = 5;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(262, 102);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(139, 26);
            this.LastNameTextBox.TabIndex = 6;
            // 
            // PositionListBox
            // 
            this.PositionListBox.FormattingEnabled = true;
            this.PositionListBox.ItemHeight = 20;
            this.PositionListBox.Items.AddRange(new object[] {
            "PO1",
            "PO2"});
            this.PositionListBox.Location = new System.Drawing.Point(479, 102);
            this.PositionListBox.Name = "PositionListBox";
            this.PositionListBox.Size = new System.Drawing.Size(120, 104);
            this.PositionListBox.TabIndex = 7;
            // 
            // HireDateTimePicker
            // 
            this.HireDateTimePicker.Location = new System.Drawing.Point(670, 100);
            this.HireDateTimePicker.Name = "HireDateTimePicker";
            this.HireDateTimePicker.Size = new System.Drawing.Size(300, 26);
            this.HireDateTimePicker.TabIndex = 8;
            // 
            // PnpPersonnelGridView
            // 
            this.PnpPersonnelGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PnpPersonnelGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.Position,
            this.HireDate,
            this.GrossPay,
            this.LongPay,
            this.Deductions,
            this.Salary});
            this.PnpPersonnelGridView.Location = new System.Drawing.Point(56, 370);
            this.PnpPersonnelGridView.Name = "PnpPersonnelGridView";
            this.PnpPersonnelGridView.RowTemplate.Height = 28;
            this.PnpPersonnelGridView.Size = new System.Drawing.Size(1185, 421);
            this.PnpPersonnelGridView.TabIndex = 9;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            // 
            // HireDate
            // 
            this.HireDate.DataPropertyName = "HireDate";
            this.HireDate.HeaderText = "Hire Date";
            this.HireDate.Name = "HireDate";
            // 
            // GrossPay
            // 
            this.GrossPay.DataPropertyName = "GrossPay";
            this.GrossPay.HeaderText = "Gross Pay";
            this.GrossPay.Name = "GrossPay";
            // 
            // LongPay
            // 
            this.LongPay.DataPropertyName = "LongPay";
            this.LongPay.HeaderText = "Long Pay";
            this.LongPay.Name = "LongPay";
            // 
            // Deductions
            // 
            this.Deductions.DataPropertyName = "TotalDeductions";
            this.Deductions.HeaderText = "Deductions";
            this.Deductions.Name = "Deductions";
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "TotalSalary";
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 935);
            this.Controls.Add(this.PnpPersonnelGridView);
            this.Controls.Add(this.HireDateTimePicker);
            this.Controls.Add(this.PositionListBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.AddPersonnelButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.PnpPersonnelGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddPersonnelButton;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.ListBox PositionListBox;
        private System.Windows.Forms.DateTimePicker HireDateTimePicker;
        private System.Windows.Forms.DataGridView PnpPersonnelGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn HireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrossPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn LongPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deductions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
    }
}