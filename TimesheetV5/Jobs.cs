using System;
using System.Drawing;
using System.Windows.Forms;

namespace TimesheetV5
{
    public partial class Jobs : Form
    {
        public static Jobs instance;
        private JobsPopup jobsPopup = new JobsPopup();
        Functions Con;
        public Jobs()
        {
            InitializeComponent();
            Con = new Functions();
            instance = this;
            ListJobs();
        }

        private void ListJobs()
        {
            try
            {
                string Query = "SELECT * FROM JobView";
                JobListDataGridViewer.DataSource = Con.GetData(Query);
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void JobListDataGridViewer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (JobListDataGridViewer.SelectedRows[0].Cells[1].Value.ToString() == "")
            {
                return;
            }

            int jobId = Convert.ToInt32(JobListDataGridViewer.SelectedRows[0].Cells[0].Value.ToString());
            string jobName = JobListDataGridViewer.SelectedRows[0].Cells[1].Value.ToString();
            string estimatedDuration = JobListDataGridViewer.SelectedRows[0].Cells[2].Value.ToString();
            Form FormBackground = new Form();

            {
                FormBackground.StartPosition = FormStartPosition.Manual;
                FormBackground.FormBorderStyle = FormBorderStyle.None;
                FormBackground.Opacity = .70d;
                FormBackground.BackColor = Color.Black;
                FormBackground.WindowState = FormWindowState.Maximized;
                FormBackground.TopMost = false;
                FormBackground.Location = this.Location;
                FormBackground.ShowInTaskbar = false;
                FormBackground.Show();

                jobsPopup.Owner = FormBackground;
                jobsPopup.UpdateJob(jobId, jobName, estimatedDuration);

                FormBackground.Dispose();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Form FormBackground = new Form();
            JobsPopup jobsPopupForm = new JobsPopup();
            {
                FormBackground.StartPosition = FormStartPosition.Manual;
                FormBackground.FormBorderStyle = FormBorderStyle.None;
                FormBackground.Opacity = .70d;
                FormBackground.BackColor = Color.Black;
                FormBackground.WindowState = FormWindowState.Maximized;
                FormBackground.TopMost = false;
                FormBackground.Location = this.Location;
                FormBackground.ShowInTaskbar = false;
                FormBackground.Show();

                jobsPopupForm.Owner = FormBackground;
                jobsPopupForm.ShowDialog();

                FormBackground.Dispose();
            }
        }

        private void AddButton_MouseHover(object sender, EventArgs e)
        {
            AddToolTip.Show("Click here on the Add button to add a new job", AddButton);
        }

        private void EmployeesLabel_Click(object sender, EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();
        }

        private void EmployeesPictureBox_Click(object sender, EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();
        }

        private void Timesheets_Click(object sender, EventArgs e)
        {
            Timesheets Obj = new Timesheets();
            Obj.Show();
            this.Hide();
        }

        private void TimesheetsPictureBox_Click(object sender, EventArgs e)
        {
            Timesheets Obj = new Timesheets();
            Obj.Show();
            this.Hide();
        }

        private void LogoutLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogoutPictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
