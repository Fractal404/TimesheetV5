namespace TimesheetV5
{
    partial class Timesheets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timesheets));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.JobsLabel = new System.Windows.Forms.Label();
            this.JobsPictureBox = new System.Windows.Forms.PictureBox();
            this.LogoutLabel = new System.Windows.Forms.Label();
            this.LogoutPictureBox = new System.Windows.Forms.PictureBox();
            this.EmployeesLabel = new System.Windows.Forms.Label();
            this.EmployeesPictureBox = new System.Windows.Forms.PictureBox();
            this.TimesheetManagementLabel = new System.Windows.Forms.Label();
            this.ListOfTimesheetsLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.TimesheetListDataGridViewer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.AddToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JobsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimesheetListDataGridViewer)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.JobsLabel);
            this.panel1.Controls.Add(this.JobsPictureBox);
            this.panel1.Controls.Add(this.LogoutLabel);
            this.panel1.Controls.Add(this.LogoutPictureBox);
            this.panel1.Controls.Add(this.EmployeesLabel);
            this.panel1.Controls.Add(this.EmployeesPictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 50);
            this.panel1.TabIndex = 9;
            // 
            // JobsLabel
            // 
            this.JobsLabel.AutoSize = true;
            this.JobsLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.JobsLabel.Font = new System.Drawing.Font("Sitka Small", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobsLabel.Location = new System.Drawing.Point(181, 7);
            this.JobsLabel.Name = "JobsLabel";
            this.JobsLabel.Size = new System.Drawing.Size(62, 31);
            this.JobsLabel.TabIndex = 15;
            this.JobsLabel.Text = "Jobs";
            this.JobsLabel.Click += new System.EventHandler(this.JobsLabel_Click);
            // 
            // JobsPictureBox
            // 
            this.JobsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("JobsPictureBox.Image")));
            this.JobsPictureBox.Location = new System.Drawing.Point(136, 4);
            this.JobsPictureBox.Name = "JobsPictureBox";
            this.JobsPictureBox.Size = new System.Drawing.Size(39, 40);
            this.JobsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.JobsPictureBox.TabIndex = 14;
            this.JobsPictureBox.TabStop = false;
            this.JobsPictureBox.Click += new System.EventHandler(this.JobsPictureBox_Click);
            // 
            // LogoutLabel
            // 
            this.LogoutLabel.AutoSize = true;
            this.LogoutLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LogoutLabel.Font = new System.Drawing.Font("Sitka Small", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutLabel.Location = new System.Drawing.Point(743, 7);
            this.LogoutLabel.Name = "LogoutLabel";
            this.LogoutLabel.Size = new System.Drawing.Size(90, 31);
            this.LogoutLabel.TabIndex = 19;
            this.LogoutLabel.Text = "Logout";
            this.LogoutLabel.Click += new System.EventHandler(this.LogoutLabel_Click);
            // 
            // LogoutPictureBox
            // 
            this.LogoutPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoutPictureBox.Image")));
            this.LogoutPictureBox.Location = new System.Drawing.Point(702, 4);
            this.LogoutPictureBox.Name = "LogoutPictureBox";
            this.LogoutPictureBox.Size = new System.Drawing.Size(39, 40);
            this.LogoutPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoutPictureBox.TabIndex = 18;
            this.LogoutPictureBox.TabStop = false;
            this.LogoutPictureBox.Click += new System.EventHandler(this.LogoutPictureBox_Click);
            // 
            // EmployeesLabel
            // 
            this.EmployeesLabel.AutoSize = true;
            this.EmployeesLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EmployeesLabel.Font = new System.Drawing.Font("Sitka Small", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeesLabel.Location = new System.Drawing.Point(428, 7);
            this.EmployeesLabel.Name = "EmployeesLabel";
            this.EmployeesLabel.Size = new System.Drawing.Size(134, 31);
            this.EmployeesLabel.TabIndex = 17;
            this.EmployeesLabel.Text = "Employees";
            this.EmployeesLabel.Click += new System.EventHandler(this.EmployeesLabel_Click);
            // 
            // EmployeesPictureBox
            // 
            this.EmployeesPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("EmployeesPictureBox.Image")));
            this.EmployeesPictureBox.Location = new System.Drawing.Point(387, 4);
            this.EmployeesPictureBox.Name = "EmployeesPictureBox";
            this.EmployeesPictureBox.Size = new System.Drawing.Size(39, 40);
            this.EmployeesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmployeesPictureBox.TabIndex = 16;
            this.EmployeesPictureBox.TabStop = false;
            this.EmployeesPictureBox.Click += new System.EventHandler(this.EmployeesPictureBox_Click);
            // 
            // TimesheetManagementLabel
            // 
            this.TimesheetManagementLabel.AutoSize = true;
            this.TimesheetManagementLabel.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimesheetManagementLabel.Location = new System.Drawing.Point(309, 3);
            this.TimesheetManagementLabel.Name = "TimesheetManagementLabel";
            this.TimesheetManagementLabel.Size = new System.Drawing.Size(378, 40);
            this.TimesheetManagementLabel.TabIndex = 0;
            this.TimesheetManagementLabel.Text = "Timesheets Management";
            this.TimesheetManagementLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListOfTimesheetsLabel
            // 
            this.ListOfTimesheetsLabel.AutoSize = true;
            this.ListOfTimesheetsLabel.Font = new System.Drawing.Font("Sitka Small", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfTimesheetsLabel.Location = new System.Drawing.Point(6, 99);
            this.ListOfTimesheetsLabel.Name = "ListOfTimesheetsLabel";
            this.ListOfTimesheetsLabel.Size = new System.Drawing.Size(283, 40);
            this.ListOfTimesheetsLabel.TabIndex = 13;
            this.ListOfTimesheetsLabel.Text = "List of Timesheets";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(12, 142);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(95, 42);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            this.AddButton.MouseHover += new System.EventHandler(this.AddButton_MouseHover);
            // 
            // TimesheetListDataGridViewer
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.TimesheetListDataGridViewer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TimesheetListDataGridViewer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TimesheetListDataGridViewer.ColumnHeadersHeight = 27;
            this.TimesheetListDataGridViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TimesheetListDataGridViewer.DefaultCellStyle = dataGridViewCellStyle3;
            this.TimesheetListDataGridViewer.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.TimesheetListDataGridViewer.Location = new System.Drawing.Point(12, 194);
            this.TimesheetListDataGridViewer.Name = "TimesheetListDataGridViewer";
            this.TimesheetListDataGridViewer.ReadOnly = true;
            this.TimesheetListDataGridViewer.RowHeadersVisible = false;
            this.TimesheetListDataGridViewer.Size = new System.Drawing.Size(961, 413);
            this.TimesheetListDataGridViewer.TabIndex = 11;
            this.TimesheetListDataGridViewer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TimesheetListDataGridViewer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TimesheetListDataGridViewer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TimesheetListDataGridViewer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TimesheetListDataGridViewer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TimesheetListDataGridViewer.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.TimesheetListDataGridViewer.ThemeStyle.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.TimesheetListDataGridViewer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TimesheetListDataGridViewer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TimesheetListDataGridViewer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimesheetListDataGridViewer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TimesheetListDataGridViewer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TimesheetListDataGridViewer.ThemeStyle.HeaderStyle.Height = 27;
            this.TimesheetListDataGridViewer.ThemeStyle.ReadOnly = true;
            this.TimesheetListDataGridViewer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TimesheetListDataGridViewer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TimesheetListDataGridViewer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimesheetListDataGridViewer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TimesheetListDataGridViewer.ThemeStyle.RowsStyle.Height = 22;
            this.TimesheetListDataGridViewer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TimesheetListDataGridViewer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TimesheetListDataGridViewer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TimesheetListDataGridViewer_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.TimesheetManagementLabel);
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 50);
            this.panel2.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(639, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "To update details inside an exsisting employee timesheet, click on the row which " +
    "displays them";
            // 
            // Timesheets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(987, 620);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ListOfTimesheetsLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TimesheetListDataGridViewer);
            this.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Timesheets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timesheets";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JobsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimesheetListDataGridViewer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TimesheetManagementLabel;
        private System.Windows.Forms.Label ListOfTimesheetsLabel;
        private System.Windows.Forms.Button AddButton;
        private Guna.UI2.WinForms.Guna2DataGridView TimesheetListDataGridViewer;
        private System.Windows.Forms.Label LogoutLabel;
        private System.Windows.Forms.PictureBox LogoutPictureBox;
        private System.Windows.Forms.Label EmployeesLabel;
        private System.Windows.Forms.PictureBox EmployeesPictureBox;
        private System.Windows.Forms.Label JobsLabel;
        private System.Windows.Forms.PictureBox JobsPictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip AddToolTip;
    }
}