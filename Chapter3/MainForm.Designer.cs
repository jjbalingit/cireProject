namespace Chapter3
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
            this.AddPersonnelButton = new System.Windows.Forms.Button();
            this.fnamelabel = new System.Windows.Forms.Label();
            this.lnamelabel = new System.Windows.Forms.Label();
            this.PositionListBox = new System.Windows.Forms.ListBox();
            this.positionlabel = new System.Windows.Forms.Label();
            this.hiredatelabel = new System.Windows.Forms.Label();
            this.HireDatePicker = new System.Windows.Forms.DateTimePicker();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.PnpPersonnelDataGridView = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PnpPersonnelDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddPersonnelButton
            // 
            this.AddPersonnelButton.Location = new System.Drawing.Point(70, 149);
            this.AddPersonnelButton.Name = "AddPersonnelButton";
            this.AddPersonnelButton.Size = new System.Drawing.Size(123, 47);
            this.AddPersonnelButton.TabIndex = 0;
            this.AddPersonnelButton.Text = "Add Personnel";
            this.AddPersonnelButton.UseVisualStyleBackColor = true;
            this.AddPersonnelButton.Click += new System.EventHandler(this.AddPersonnelButton_Click);
            // 
            // fnamelabel
            // 
            this.fnamelabel.AutoSize = true;
            this.fnamelabel.Location = new System.Drawing.Point(67, 50);
            this.fnamelabel.Name = "fnamelabel";
            this.fnamelabel.Size = new System.Drawing.Size(57, 13);
            this.fnamelabel.TabIndex = 1;
            this.fnamelabel.Text = "First Name";
            // 
            // lnamelabel
            // 
            this.lnamelabel.AutoSize = true;
            this.lnamelabel.Location = new System.Drawing.Point(314, 50);
            this.lnamelabel.Name = "lnamelabel";
            this.lnamelabel.Size = new System.Drawing.Size(58, 13);
            this.lnamelabel.TabIndex = 2;
            this.lnamelabel.Text = "Last Name";
            // 
            // PositionListBox
            // 
            this.PositionListBox.FormattingEnabled = true;
            this.PositionListBox.Items.AddRange(new object[] {
            "NUP",
            "PO1",
            "PO2",
            "PO3",
            "SPO1",
            "SPO2",
            "SPO3",
            "SPO4",
            "PISNP",
            "PSINSP",
            "PCINSP",
            "PSUPT",
            "PSSUPT",
            "PCSUPT",
            "PDIR",
            "PDDG",
            "PDG",
            "PDDG",
            "PDG"});
            this.PositionListBox.Location = new System.Drawing.Point(559, 66);
            this.PositionListBox.Name = "PositionListBox";
            this.PositionListBox.Size = new System.Drawing.Size(124, 134);
            this.PositionListBox.TabIndex = 3;
            // 
            // positionlabel
            // 
            this.positionlabel.AutoSize = true;
            this.positionlabel.Location = new System.Drawing.Point(556, 50);
            this.positionlabel.Name = "positionlabel";
            this.positionlabel.Size = new System.Drawing.Size(44, 13);
            this.positionlabel.TabIndex = 4;
            this.positionlabel.Text = "Position";
            // 
            // hiredatelabel
            // 
            this.hiredatelabel.AutoSize = true;
            this.hiredatelabel.Location = new System.Drawing.Point(766, 47);
            this.hiredatelabel.Name = "hiredatelabel";
            this.hiredatelabel.Size = new System.Drawing.Size(52, 13);
            this.hiredatelabel.TabIndex = 5;
            this.hiredatelabel.Text = "Hire Date";
            // 
            // HireDatePicker
            // 
            this.HireDatePicker.Location = new System.Drawing.Point(769, 63);
            this.HireDatePicker.Name = "HireDatePicker";
            this.HireDatePicker.Size = new System.Drawing.Size(200, 20);
            this.HireDatePicker.TabIndex = 6;
            this.HireDatePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(70, 66);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(173, 20);
            this.FirstNameTextBox.TabIndex = 7;
            this.FirstNameTextBox.Click += new System.EventHandler(this.FirstNameText_Click);
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(317, 66);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(155, 20);
            this.LastNameTextBox.TabIndex = 8;
            this.LastNameTextBox.Click += new System.EventHandler(this.LastNameTextBox_Click);
            // 
            // PnpPersonnelDataGridView
            // 
            this.PnpPersonnelDataGridView.AllowUserToOrderColumns = true;
            this.PnpPersonnelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PnpPersonnelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column9,
            this.Column7,
            this.Column8});
            this.PnpPersonnelDataGridView.Location = new System.Drawing.Point(70, 215);
            this.PnpPersonnelDataGridView.Name = "PnpPersonnelDataGridView";
            this.PnpPersonnelDataGridView.Size = new System.Drawing.Size(899, 150);
            this.PnpPersonnelDataGridView.TabIndex = 9;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "LastName";
            this.Column2.HeaderText = "Last Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Position";
            this.Column3.HeaderText = "Position";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "HireDate";
            this.Column4.HeaderText = "Hire Date";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GrossPay";
            this.Column5.HeaderText = "Base Pay";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "LongPay";
            this.Column6.HeaderText = "Long Pay";
            this.Column6.Name = "Column6";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "TotalAllowances";
            this.Column9.HeaderText = "Allowances";
            this.Column9.Name = "Column9";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TotalDeductions";
            this.Column7.HeaderText = "Deductions";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TotalSalary";
            this.Column8.HeaderText = "Salary";
            this.Column8.Name = "Column8";
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.Location = new System.Drawing.Point(70, 372);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(123, 41);
            this.ButtonLoad.TabIndex = 10;
            this.ButtonLoad.Text = "Load";
            this.ButtonLoad.UseVisualStyleBackColor = true;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(216, 372);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(109, 41);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 425);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ButtonLoad);
            this.Controls.Add(this.PnpPersonnelDataGridView);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.HireDatePicker);
            this.Controls.Add(this.hiredatelabel);
            this.Controls.Add(this.positionlabel);
            this.Controls.Add(this.PositionListBox);
            this.Controls.Add(this.lnamelabel);
            this.Controls.Add(this.fnamelabel);
            this.Controls.Add(this.AddPersonnelButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.FirstNameText_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.PnpPersonnelDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddPersonnelButton;
        private System.Windows.Forms.Label fnamelabel;
        private System.Windows.Forms.Label lnamelabel;
        private System.Windows.Forms.ListBox PositionListBox;
        private System.Windows.Forms.Label positionlabel;
        private System.Windows.Forms.Label hiredatelabel;
        private System.Windows.Forms.DateTimePicker HireDatePicker;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.DataGridView PnpPersonnelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button ButtonLoad;
        private System.Windows.Forms.Button SaveButton;

    }
}

