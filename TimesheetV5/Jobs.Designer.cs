namespace TimesheetV5
{
    partial class Jobs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jobs));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Timesheets = new System.Windows.Forms.Label();
            this.LogoutLabel = new System.Windows.Forms.Label();
            this.LogoutPictureBox = new System.Windows.Forms.PictureBox();
            this.TimesheetsPictureBox = new System.Windows.Forms.PictureBox();
            this.JobsManagementLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ListOfEmployeesLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.JobListDataGridViewer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.EmployeesLabel = new System.Windows.Forms.Label();
            this.EmployeesPictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimesheetsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobListDataGridViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Timesheets);
            this.panel1.Controls.Add(this.LogoutLabel);
            this.panel1.Controls.Add(this.LogoutPictureBox);
            this.panel1.Controls.Add(this.TimesheetsPictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 50);
            this.panel1.TabIndex = 4;
            // 
            // Timesheets
            // 
            this.Timesheets.AutoSize = true;
            this.Timesheets.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Timesheets.Font = new System.Drawing.Font("Sitka Small", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timesheets.Location = new System.Drawing.Point(450, 7);
            this.Timesheets.Name = "Timesheets";
            this.Timesheets.Size = new System.Drawing.Size(141, 31);
            this.Timesheets.TabIndex = 13;
            this.Timesheets.Text = "Timesheets";
            this.Timesheets.Click += new System.EventHandler(this.Timesheets_Click);
            // 
            // LogoutLabel
            // 
            this.LogoutLabel.AutoSize = true;
            this.LogoutLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LogoutLabel.Font = new System.Drawing.Font("Sitka Small", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutLabel.Location = new System.Drawing.Point(758, 6);
            this.LogoutLabel.Name = "LogoutLabel";
            this.LogoutLabel.Size = new System.Drawing.Size(90, 31);
            this.LogoutLabel.TabIndex = 15;
            this.LogoutLabel.Text = "Logout";
            this.LogoutLabel.Click += new System.EventHandler(this.LogoutLabel_Click);
            // 
            // LogoutPictureBox
            // 
            this.LogoutPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoutPictureBox.Image")));
            this.LogoutPictureBox.Location = new System.Drawing.Point(717, 3);
            this.LogoutPictureBox.Name = "LogoutPictureBox";
            this.LogoutPictureBox.Size = new System.Drawing.Size(39, 40);
            this.LogoutPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoutPictureBox.TabIndex = 14;
            this.LogoutPictureBox.TabStop = false;
            this.LogoutPictureBox.Click += new System.EventHandler(this.LogoutPictureBox_Click);
            // 
            // TimesheetsPictureBox
            // 
            this.TimesheetsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("TimesheetsPictureBox.Image")));
            this.TimesheetsPictureBox.Location = new System.Drawing.Point(409, 4);
            this.TimesheetsPictureBox.Name = "TimesheetsPictureBox";
            this.TimesheetsPictureBox.Size = new System.Drawing.Size(39, 40);
            this.TimesheetsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TimesheetsPictureBox.TabIndex = 12;
            this.TimesheetsPictureBox.TabStop = false;
            this.TimesheetsPictureBox.Click += new System.EventHandler(this.TimesheetsPictureBox_Click);
            // 
            // JobsManagementLabel
            // 
            this.JobsManagementLabel.AutoSize = true;
            this.JobsManagementLabel.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobsManagementLabel.Location = new System.Drawing.Point(359, 3);
            this.JobsManagementLabel.Name = "JobsManagementLabel";
            this.JobsManagementLabel.Size = new System.Drawing.Size(274, 40);
            this.JobsManagementLabel.TabIndex = 0;
            this.JobsManagementLabel.Text = "Jobs Management";
            this.JobsManagementLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(415, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "To update an exsisting job, click on the row which displays it";
            // 
            // ListOfEmployeesLabel
            // 
            this.ListOfEmployeesLabel.AutoSize = true;
            this.ListOfEmployeesLabel.Font = new System.Drawing.Font("Sitka Small", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfEmployeesLabel.Location = new System.Drawing.Point(5, 103);
            this.ListOfEmployeesLabel.Name = "ListOfEmployeesLabel";
            this.ListOfEmployeesLabel.Size = new System.Drawing.Size(179, 40);
            this.ListOfEmployeesLabel.TabIndex = 8;
            this.ListOfEmployeesLabel.Text = "List of Jobs";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(12, 147);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(99, 41);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            this.AddButton.MouseHover += new System.EventHandler(this.AddButton_MouseHover);
            // 
            // JobListDataGridViewer
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.JobListDataGridViewer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.JobListDataGridViewer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.JobListDataGridViewer.ColumnHeadersHeight = 27;
            this.JobListDataGridViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.JobListDataGridViewer.DefaultCellStyle = dataGridViewCellStyle3;
            this.JobListDataGridViewer.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.JobListDataGridViewer.Location = new System.Drawing.Point(12, 194);
            this.JobListDataGridViewer.Name = "JobListDataGridViewer";
            this.JobListDataGridViewer.ReadOnly = true;
            this.JobListDataGridViewer.RowHeadersVisible = false;
            this.JobListDataGridViewer.Size = new System.Drawing.Size(963, 410);
            this.JobListDataGridViewer.TabIndex = 6;
            this.JobListDataGridViewer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.JobListDataGridViewer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.JobListDataGridViewer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.JobListDataGridViewer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.JobListDataGridViewer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.JobListDataGridViewer.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.JobListDataGridViewer.ThemeStyle.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.JobListDataGridViewer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.JobListDataGridViewer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.JobListDataGridViewer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobListDataGridViewer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.JobListDataGridViewer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.JobListDataGridViewer.ThemeStyle.HeaderStyle.Height = 27;
            this.JobListDataGridViewer.ThemeStyle.ReadOnly = true;
            this.JobListDataGridViewer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.JobListDataGridViewer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.JobListDataGridViewer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobListDataGridViewer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.JobListDataGridViewer.ThemeStyle.RowsStyle.Height = 22;
            this.JobListDataGridViewer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.JobListDataGridViewer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.JobListDataGridViewer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.JobListDataGridViewer_CellClick);
            // 
            // EmployeesLabel
            // 
            this.EmployeesLabel.AutoSize = true;
            this.EmployeesLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EmployeesLabel.Font = new System.Drawing.Font("Sitka Small", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeesLabel.Location = new System.Drawing.Point(153, 7);
            this.EmployeesLabel.Name = "EmployeesLabel";
            this.EmployeesLabel.Size = new System.Drawing.Size(134, 31);
            this.EmployeesLabel.TabIndex = 11;
            this.EmployeesLabel.Text = "Employees";
            this.EmployeesLabel.Click += new System.EventHandler(this.EmployeesLabel_Click);
            // 
            // EmployeesPictureBox
            // 
            this.EmployeesPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("EmployeesPictureBox.Image")));
            this.EmployeesPictureBox.Location = new System.Drawing.Point(108, 4);
            this.EmployeesPictureBox.Name = "EmployeesPictureBox";
            this.EmployeesPictureBox.Size = new System.Drawing.Size(39, 40);
            this.EmployeesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmployeesPictureBox.TabIndex = 10;
            this.EmployeesPictureBox.TabStop = false;
            this.EmployeesPictureBox.Click += new System.EventHandler(this.EmployeesPictureBox_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.JobsManagementLabel);
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 50);
            this.panel2.TabIndex = 12;
            // 
            // Jobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(987, 620);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.EmployeesLabel);
            this.Controls.Add(this.EmployeesPictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListOfEmployeesLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.JobListDataGridViewer);
            this.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Jobs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jobs";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimesheetsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobListDataGridViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label JobsManagementLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ListOfEmployeesLabel;
        private System.Windows.Forms.Button AddButton;
        private Guna.UI2.WinForms.Guna2DataGridView JobListDataGridViewer;
        private System.Windows.Forms.Label LogoutLabel;
        private System.Windows.Forms.PictureBox LogoutPictureBox;
        private System.Windows.Forms.Label Timesheets;
        private System.Windows.Forms.PictureBox TimesheetsPictureBox;
        private System.Windows.Forms.Label EmployeesLabel;
        private System.Windows.Forms.PictureBox EmployeesPictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip AddToolTip;
    }
}