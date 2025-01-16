namespace TimesheetV5
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogoutLabel = new System.Windows.Forms.Label();
            this.LogoutPictureBox = new System.Windows.Forms.PictureBox();
            this.Timesheets = new System.Windows.Forms.Label();
            this.TimesheetsPictureBox = new System.Windows.Forms.PictureBox();
            this.JobsLabel = new System.Windows.Forms.Label();
            this.JobsPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeListDataGridViewer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimesheetsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeListDataGridViewer)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.LogoutLabel);
            this.panel1.Controls.Add(this.LogoutPictureBox);
            this.panel1.Controls.Add(this.Timesheets);
            this.panel1.Controls.Add(this.TimesheetsPictureBox);
            this.panel1.Controls.Add(this.JobsLabel);
            this.panel1.Controls.Add(this.JobsPictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 50);
            this.panel1.TabIndex = 0;
            // 
            // LogoutLabel
            // 
            this.LogoutLabel.AutoSize = true;
            this.LogoutLabel.Font = new System.Drawing.Font("Sitka Small", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutLabel.Location = new System.Drawing.Point(786, 8);
            this.LogoutLabel.Name = "LogoutLabel";
            this.LogoutLabel.Size = new System.Drawing.Size(90, 31);
            this.LogoutLabel.TabIndex = 9;
            this.LogoutLabel.Text = "Logout";
            this.LogoutLabel.Click += new System.EventHandler(this.LogoutLabel_Click);
            // 
            // LogoutPictureBox
            // 
            this.LogoutPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoutPictureBox.Image")));
            this.LogoutPictureBox.Location = new System.Drawing.Point(734, 4);
            this.LogoutPictureBox.Name = "LogoutPictureBox";
            this.LogoutPictureBox.Size = new System.Drawing.Size(39, 40);
            this.LogoutPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoutPictureBox.TabIndex = 8;
            this.LogoutPictureBox.TabStop = false;
            this.LogoutPictureBox.Click += new System.EventHandler(this.LogoutPictureBox_Click);
            // 
            // Timesheets
            // 
            this.Timesheets.AutoSize = true;
            this.Timesheets.Font = new System.Drawing.Font("Sitka Small", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timesheets.Location = new System.Drawing.Point(446, 6);
            this.Timesheets.Name = "Timesheets";
            this.Timesheets.Size = new System.Drawing.Size(141, 31);
            this.Timesheets.TabIndex = 7;
            this.Timesheets.Text = "Timesheets";
            this.Timesheets.Click += new System.EventHandler(this.Timesheets_Click);
            // 
            // TimesheetsPictureBox
            // 
            this.TimesheetsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("TimesheetsPictureBox.Image")));
            this.TimesheetsPictureBox.Location = new System.Drawing.Point(405, 3);
            this.TimesheetsPictureBox.Name = "TimesheetsPictureBox";
            this.TimesheetsPictureBox.Size = new System.Drawing.Size(39, 40);
            this.TimesheetsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TimesheetsPictureBox.TabIndex = 6;
            this.TimesheetsPictureBox.TabStop = false;
            this.TimesheetsPictureBox.Click += new System.EventHandler(this.TimesheetsPictureBox_Click);
            // 
            // JobsLabel
            // 
            this.JobsLabel.AutoSize = true;
            this.JobsLabel.Font = new System.Drawing.Font("Sitka Small", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobsLabel.Location = new System.Drawing.Point(189, 8);
            this.JobsLabel.Name = "JobsLabel";
            this.JobsLabel.Size = new System.Drawing.Size(62, 31);
            this.JobsLabel.TabIndex = 5;
            this.JobsLabel.Text = "Jobs";
            this.JobsLabel.Click += new System.EventHandler(this.JobsLabel_Click);
            // 
            // JobsPictureBox
            // 
            this.JobsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("JobsPictureBox.Image")));
            this.JobsPictureBox.Location = new System.Drawing.Point(144, 5);
            this.JobsPictureBox.Name = "JobsPictureBox";
            this.JobsPictureBox.Size = new System.Drawing.Size(39, 40);
            this.JobsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.JobsPictureBox.TabIndex = 4;
            this.JobsPictureBox.TabStop = false;
            this.JobsPictureBox.Click += new System.EventHandler(this.JobsPictureBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Management";
            // 
            // EmployeeListDataGridViewer
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.EmployeeListDataGridViewer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeListDataGridViewer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeListDataGridViewer.ColumnHeadersHeight = 27;
            this.EmployeeListDataGridViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeListDataGridViewer.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmployeeListDataGridViewer.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.EmployeeListDataGridViewer.Location = new System.Drawing.Point(12, 194);
            this.EmployeeListDataGridViewer.Name = "EmployeeListDataGridViewer";
            this.EmployeeListDataGridViewer.ReadOnly = true;
            this.EmployeeListDataGridViewer.RowHeadersVisible = false;
            this.EmployeeListDataGridViewer.Size = new System.Drawing.Size(963, 414);
            this.EmployeeListDataGridViewer.TabIndex = 1;
            this.EmployeeListDataGridViewer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeListDataGridViewer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmployeeListDataGridViewer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EmployeeListDataGridViewer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EmployeeListDataGridViewer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EmployeeListDataGridViewer.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeListDataGridViewer.ThemeStyle.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.EmployeeListDataGridViewer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EmployeeListDataGridViewer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmployeeListDataGridViewer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeListDataGridViewer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EmployeeListDataGridViewer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmployeeListDataGridViewer.ThemeStyle.HeaderStyle.Height = 27;
            this.EmployeeListDataGridViewer.ThemeStyle.ReadOnly = true;
            this.EmployeeListDataGridViewer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeListDataGridViewer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmployeeListDataGridViewer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeListDataGridViewer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmployeeListDataGridViewer.ThemeStyle.RowsStyle.Height = 22;
            this.EmployeeListDataGridViewer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeListDataGridViewer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmployeeListDataGridViewer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeListDataGridViewer_CellContentClick);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(12, 145);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 39);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            this.AddButton.MouseHover += new System.EventHandler(this.AddButton_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "List of Employees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(477, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "To update an exsisting employee, click on the row which displays them";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 49);
            this.panel2.TabIndex = 4;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(987, 620);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EmployeeListDataGridViewer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimesheetsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeListDataGridViewer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView EmployeeListDataGridViewer;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox JobsPictureBox;
        private System.Windows.Forms.Label JobsLabel;
        private System.Windows.Forms.Label Timesheets;
        private System.Windows.Forms.PictureBox TimesheetsPictureBox;
        private System.Windows.Forms.Label LogoutLabel;
        private System.Windows.Forms.PictureBox LogoutPictureBox;
        private System.Windows.Forms.ToolTip AddToolTip;
        private System.Windows.Forms.Panel panel2;
    }
}

