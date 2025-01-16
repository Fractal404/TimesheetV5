namespace TimesheetV5
{
    partial class TimesheetsPopup
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.WeekEndingLabel = new System.Windows.Forms.Label();
            this.EmployeIdLabel = new System.Windows.Forms.Label();
            this.WeekEndingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EmployeeIdComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(149, 203);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(133, 36);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(21, 203);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(122, 36);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLabel.Location = new System.Drawing.Point(274, -4);
            this.CloseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(29, 31);
            this.CloseLabel.TabIndex = 8;
            this.CloseLabel.Text = "X";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            // 
            // WeekEndingLabel
            // 
            this.WeekEndingLabel.AutoSize = true;
            this.WeekEndingLabel.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekEndingLabel.Location = new System.Drawing.Point(15, 7);
            this.WeekEndingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WeekEndingLabel.Name = "WeekEndingLabel";
            this.WeekEndingLabel.Size = new System.Drawing.Size(168, 31);
            this.WeekEndingLabel.TabIndex = 6;
            this.WeekEndingLabel.Text = "Week Ending:";
            // 
            // EmployeIdLabel
            // 
            this.EmployeIdLabel.AutoSize = true;
            this.EmployeIdLabel.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeIdLabel.Location = new System.Drawing.Point(16, 100);
            this.EmployeIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmployeIdLabel.Name = "EmployeIdLabel";
            this.EmployeIdLabel.Size = new System.Drawing.Size(160, 31);
            this.EmployeIdLabel.TabIndex = 11;
            this.EmployeIdLabel.Text = "Employee Id:";
            // 
            // WeekEndingDateTimePicker
            // 
            this.WeekEndingDateTimePicker.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekEndingDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.WeekEndingDateTimePicker.Location = new System.Drawing.Point(22, 52);
            this.WeekEndingDateTimePicker.Name = "WeekEndingDateTimePicker";
            this.WeekEndingDateTimePicker.Size = new System.Drawing.Size(260, 34);
            this.WeekEndingDateTimePicker.TabIndex = 1;
            // 
            // EmployeeIdComboBox
            // 
            this.EmployeeIdComboBox.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeIdComboBox.FormattingEnabled = true;
            this.EmployeeIdComboBox.Location = new System.Drawing.Point(21, 145);
            this.EmployeeIdComboBox.Name = "EmployeeIdComboBox";
            this.EmployeeIdComboBox.Size = new System.Drawing.Size(261, 39);
            this.EmployeeIdComboBox.TabIndex = 2;
            // 
            // TimesheetsPopup
            // 
            this.AcceptButton = this.SaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(303, 266);
            this.Controls.Add(this.EmployeeIdComboBox);
            this.Controls.Add(this.WeekEndingDateTimePicker);
            this.Controls.Add(this.EmployeIdLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CloseLabel);
            this.Controls.Add(this.WeekEndingLabel);
            this.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TimesheetsPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimesheetsPopup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Label WeekEndingLabel;
        private System.Windows.Forms.Label EmployeIdLabel;
        private System.Windows.Forms.DateTimePicker WeekEndingDateTimePicker;
        private System.Windows.Forms.ComboBox EmployeeIdComboBox;
    }
}