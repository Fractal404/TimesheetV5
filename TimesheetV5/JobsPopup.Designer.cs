namespace TimesheetV5
{
    partial class JobsPopup
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
            this.JobNameTextBox = new System.Windows.Forms.TextBox();
            this.JobNameLabel = new System.Windows.Forms.Label();
            this.EstimatedDurationTextBox = new System.Windows.Forms.TextBox();
            this.EstimatedDurationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(211, 201);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(194, 36);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(11, 201);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(194, 36);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLabel.Location = new System.Drawing.Point(405, 7);
            this.CloseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(29, 31);
            this.CloseLabel.TabIndex = 8;
            this.CloseLabel.Text = "X";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            // 
            // JobNameTextBox
            // 
            this.JobNameTextBox.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobNameTextBox.Location = new System.Drawing.Point(12, 64);
            this.JobNameTextBox.Name = "JobNameTextBox";
            this.JobNameTextBox.Size = new System.Drawing.Size(393, 34);
            this.JobNameTextBox.TabIndex = 1;
            // 
            // JobNameLabel
            // 
            this.JobNameLabel.AutoSize = true;
            this.JobNameLabel.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobNameLabel.Location = new System.Drawing.Point(6, 18);
            this.JobNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JobNameLabel.Name = "JobNameLabel";
            this.JobNameLabel.Size = new System.Drawing.Size(128, 31);
            this.JobNameLabel.TabIndex = 6;
            this.JobNameLabel.Text = "Job Name:";
            // 
            // EstimatedDurationTextBox
            // 
            this.EstimatedDurationTextBox.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstimatedDurationTextBox.Location = new System.Drawing.Point(12, 149);
            this.EstimatedDurationTextBox.Name = "EstimatedDurationTextBox";
            this.EstimatedDurationTextBox.Size = new System.Drawing.Size(393, 34);
            this.EstimatedDurationTextBox.TabIndex = 2;
            // 
            // EstimatedDurationLabel
            // 
            this.EstimatedDurationLabel.AutoSize = true;
            this.EstimatedDurationLabel.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstimatedDurationLabel.Location = new System.Drawing.Point(6, 107);
            this.EstimatedDurationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EstimatedDurationLabel.Name = "EstimatedDurationLabel";
            this.EstimatedDurationLabel.Size = new System.Drawing.Size(242, 31);
            this.EstimatedDurationLabel.TabIndex = 11;
            this.EstimatedDurationLabel.Text = "Estimated Duration:";
            // 
            // JobsPopup
            // 
            this.AcceptButton = this.SaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(441, 260);
            this.Controls.Add(this.EstimatedDurationTextBox);
            this.Controls.Add(this.EstimatedDurationLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CloseLabel);
            this.Controls.Add(this.JobNameTextBox);
            this.Controls.Add(this.JobNameLabel);
            this.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "JobsPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JobsPopup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.TextBox JobNameTextBox;
        private System.Windows.Forms.Label JobNameLabel;
        private System.Windows.Forms.TextBox EstimatedDurationTextBox;
        private System.Windows.Forms.Label EstimatedDurationLabel;
    }
}