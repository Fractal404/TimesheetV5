namespace TimesheetV5
{
    partial class TimesheetItems
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimesheetItems));
            this.ListOfTimesheetItemsLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.TimesheetItemsListDataGridViewer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.EmployeesLabel = new System.Windows.Forms.Label();
            this.EmployeesPictureBox = new System.Windows.Forms.PictureBox();
            this.TimesheetsLabel = new System.Windows.Forms.Label();
            this.LogoutLabel = new System.Windows.Forms.Label();
            this.LogoutPictureBox = new System.Windows.Forms.PictureBox();
            this.TimesheetsPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.JobsLabel = new System.Windows.Forms.Label();
            this.JobsPictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TimesheetItemsManagementLabel = new System.Windows.Forms.Label();
            this.AddToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TimesheetItemsListDataGridViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimesheetsPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JobsPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListOfTimesheetItemsLabel
            // 
            this.ListOfTimesheetItemsLabel.AutoSize = true;
            this.ListOfTimesheetItemsLabel.Font = new System.Drawing.Font("Sitka Small", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfTimesheetItemsLabel.Location = new System.Drawing.Point(5, 106);
            this.ListOfTimesheetItemsLabel.Name = "ListOfTimesheetItemsLabel";
            this.ListOfTimesheetItemsLabel.Size = new System.Drawing.Size(383, 40);
            this.ListOfTimesheetItemsLabel.TabIndex = 23;
            this.ListOfTimesheetItemsLabel.Text = "List of Timesheet Entries";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(10, 149);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(117, 37);
            this.AddButton.TabIndex = 22;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            this.AddButton.MouseHover += new System.EventHandler(this.AddButton_MouseHover);
            // 
            // TimesheetItemsListDataGridViewer
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.TimesheetItemsListDataGridViewer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TimesheetItemsListDataGridViewer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.TimesheetItemsListDataGridViewer.ColumnHeadersHeight = 27;
            this.TimesheetItemsListDataGridViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TimesheetItemsListDataGridViewer.DefaultCellStyle = dataGridViewCellStyle6;
            this.TimesheetItemsListDataGridViewer.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.TimesheetItemsListDataGridViewer.Location = new System.Drawing.Point(10, 192);
            this.TimesheetItemsListDataGridViewer.Name = "TimesheetItemsListDataGridViewer";
            this.TimesheetItemsListDataGridViewer.ReadOnly = true;
            this.TimesheetItemsListDataGridViewer.RowHeadersVisible = false;
            this.TimesheetItemsListDataGridViewer.Size = new System.Drawing.Size(963, 413);
            this.TimesheetItemsListDataGridViewer.TabIndex = 21;
            this.TimesheetItemsListDataGridViewer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TimesheetItemsListDataGridViewer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TimesheetItemsListDataGridViewer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TimesheetItemsListDataGridViewer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TimesheetItemsListDataGridViewer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TimesheetItemsListDataGridViewer.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.TimesheetItemsListDataGridViewer.ThemeStyle.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.TimesheetItemsListDataGridViewer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TimesheetItemsListDataGridViewer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TimesheetItemsListDataGridViewer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimesheetItemsListDataGridViewer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TimesheetItemsListDataGridViewer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TimesheetItemsListDataGridViewer.ThemeStyle.HeaderStyle.Height = 27;
            this.TimesheetItemsListDataGridViewer.ThemeStyle.ReadOnly = true;
            this.TimesheetItemsListDataGridViewer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TimesheetItemsListDataGridViewer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TimesheetItemsListDataGridViewer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimesheetItemsListDataGridViewer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TimesheetItemsListDataGridViewer.ThemeStyle.RowsStyle.Height = 22;
            this.TimesheetItemsListDataGridViewer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TimesheetItemsListDataGridViewer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TimesheetItemsListDataGridViewer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TimesheetItemListDataGridViewer_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(646, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "To update an timesheet entry for the selected employee, click on the row which di" +
    "splays the date";
            // 
            // EmployeesLabel
            // 
            this.EmployeesLabel.AutoSize = true;
            this.EmployeesLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EmployeesLabel.Font = new System.Drawing.Font("Sitka Small", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeesLabel.Location = new System.Drawing.Point(121, 9);
            this.EmployeesLabel.Name = "EmployeesLabel";
            this.EmployeesLabel.Size = new System.Drawing.Size(134, 31);
            this.EmployeesLabel.TabIndex = 32;
            this.EmployeesLabel.Text = "Employees";
            this.EmployeesLabel.Click += new System.EventHandler(this.EmployeesLabel_Click);
            // 
            // EmployeesPictureBox
            // 
            this.EmployeesPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("EmployeesPictureBox.Image")));
            this.EmployeesPictureBox.Location = new System.Drawing.Point(76, 6);
            this.EmployeesPictureBox.Name = "EmployeesPictureBox";
            this.EmployeesPictureBox.Size = new System.Drawing.Size(39, 40);
            this.EmployeesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmployeesPictureBox.TabIndex = 31;
            this.EmployeesPictureBox.TabStop = false;
            this.EmployeesPictureBox.Click += new System.EventHandler(this.EmployeesPictureBox_Click);
            // 
            // TimesheetsLabel
            // 
            this.TimesheetsLabel.AutoSize = true;
            this.TimesheetsLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TimesheetsLabel.Font = new System.Drawing.Font("Sitka Small", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimesheetsLabel.Location = new System.Drawing.Point(589, 8);
            this.TimesheetsLabel.Name = "TimesheetsLabel";
            this.TimesheetsLabel.Size = new System.Drawing.Size(141, 31);
            this.TimesheetsLabel.TabIndex = 34;
            this.TimesheetsLabel.Text = "Timesheets";
            this.TimesheetsLabel.Click += new System.EventHandler(this.TimesheetsLabel_Click);
            // 
            // LogoutLabel
            // 
            this.LogoutLabel.AutoSize = true;
            this.LogoutLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LogoutLabel.Font = new System.Drawing.Font("Sitka Small", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutLabel.Location = new System.Drawing.Point(844, 9);
            this.LogoutLabel.Name = "LogoutLabel";
            this.LogoutLabel.Size = new System.Drawing.Size(90, 31);
            this.LogoutLabel.TabIndex = 36;
            this.LogoutLabel.Text = "Logout";
            this.LogoutLabel.Click += new System.EventHandler(this.LogoutLabel_Click);
            // 
            // LogoutPictureBox
            // 
            this.LogoutPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoutPictureBox.Image")));
            this.LogoutPictureBox.Location = new System.Drawing.Point(803, 6);
            this.LogoutPictureBox.Name = "LogoutPictureBox";
            this.LogoutPictureBox.Size = new System.Drawing.Size(39, 40);
            this.LogoutPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoutPictureBox.TabIndex = 35;
            this.LogoutPictureBox.TabStop = false;
            this.LogoutPictureBox.Click += new System.EventHandler(this.LogoutPictureBox_Click);
            // 
            // TimesheetsPictureBox
            // 
            this.TimesheetsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("TimesheetsPictureBox.Image")));
            this.TimesheetsPictureBox.Location = new System.Drawing.Point(548, 5);
            this.TimesheetsPictureBox.Name = "TimesheetsPictureBox";
            this.TimesheetsPictureBox.Size = new System.Drawing.Size(39, 40);
            this.TimesheetsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TimesheetsPictureBox.TabIndex = 33;
            this.TimesheetsPictureBox.TabStop = false;
            this.TimesheetsPictureBox.Click += new System.EventHandler(this.TimesheetsPictureBox_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.JobsLabel);
            this.panel1.Controls.Add(this.LogoutLabel);
            this.panel1.Controls.Add(this.LogoutPictureBox);
            this.panel1.Controls.Add(this.TimesheetsLabel);
            this.panel1.Controls.Add(this.JobsPictureBox);
            this.panel1.Controls.Add(this.EmployeesLabel);
            this.panel1.Controls.Add(this.TimesheetsPictureBox);
            this.panel1.Controls.Add(this.EmployeesPictureBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 50);
            this.panel1.TabIndex = 37;
            // 
            // JobsLabel
            // 
            this.JobsLabel.AutoSize = true;
            this.JobsLabel.Font = new System.Drawing.Font("Sitka Small", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobsLabel.Location = new System.Drawing.Point(371, 9);
            this.JobsLabel.Name = "JobsLabel";
            this.JobsLabel.Size = new System.Drawing.Size(62, 31);
            this.JobsLabel.TabIndex = 34;
            this.JobsLabel.Text = "Jobs";
            this.JobsLabel.Click += new System.EventHandler(this.JobsLabel_Click);
            // 
            // JobsPictureBox
            // 
            this.JobsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("JobsPictureBox.Image")));
            this.JobsPictureBox.Location = new System.Drawing.Point(326, 6);
            this.JobsPictureBox.Name = "JobsPictureBox";
            this.JobsPictureBox.Size = new System.Drawing.Size(39, 40);
            this.JobsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.JobsPictureBox.TabIndex = 33;
            this.JobsPictureBox.TabStop = false;
            this.JobsPictureBox.Click += new System.EventHandler(this.JobsPictureBox_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.TimesheetItemsManagementLabel);
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(990, 50);
            this.panel2.TabIndex = 38;
            // 
            // TimesheetItemsManagementLabel
            // 
            this.TimesheetItemsManagementLabel.AutoSize = true;
            this.TimesheetItemsManagementLabel.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimesheetItemsManagementLabel.Location = new System.Drawing.Point(60, 3);
            this.TimesheetItemsManagementLabel.Name = "TimesheetItemsManagementLabel";
            this.TimesheetItemsManagementLabel.Size = new System.Drawing.Size(852, 40);
            this.TimesheetItemsManagementLabel.TabIndex = 39;
            this.TimesheetItemsManagementLabel.Text = "@employeeName\'s Timesheet Management for dd/mm/yy";
            this.TimesheetItemsManagementLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimesheetItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(987, 620);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListOfTimesheetItemsLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TimesheetItemsListDataGridViewer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TimesheetItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimesheetItems";
            ((System.ComponentModel.ISupportInitialize)(this.TimesheetItemsListDataGridViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimesheetsPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JobsPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ListOfTimesheetItemsLabel;
        private System.Windows.Forms.Button AddButton;
        private Guna.UI2.WinForms.Guna2DataGridView TimesheetItemsListDataGridViewer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label EmployeesLabel;
        private System.Windows.Forms.PictureBox EmployeesPictureBox;
        private System.Windows.Forms.Label TimesheetsLabel;
        private System.Windows.Forms.Label LogoutLabel;
        private System.Windows.Forms.PictureBox LogoutPictureBox;
        private System.Windows.Forms.PictureBox TimesheetsPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label JobsLabel;
        private System.Windows.Forms.PictureBox JobsPictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TimesheetItemsManagementLabel;
        private System.Windows.Forms.ToolTip AddToolTip;
    }
}