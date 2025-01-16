using System;
using System.Windows.Forms;

namespace TimesheetV5
{
    public partial class JobsPopup : Form
    {
        public static JobsPopup instance;
        private int jobId;

        Functions Con;
        public JobsPopup()
        {
            InitializeComponent();
            instance = this;
            Con = new Functions();
        }
        public void UpdateJob(int jobId, string jobName, string estimatedDuration)
        {
            this.jobId = jobId;
            this.JobNameTextBox.Text = jobName;
            this.EstimatedDurationTextBox.Text = estimatedDuration;

            this.ShowDialog();
        }

        public void AddJob()
        {
            this.jobId = -1;
            this.JobNameTextBox.Text = "";
            this.EstimatedDurationTextBox.Text = "";

            this.ShowDialog();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string jobName = JobNameTextBox.Text;
                string estimatedDuration = EstimatedDurationTextBox.Text;
                if (jobName == "")
                {
                    MessageBox.Show("No job has beed added, please add one");
                    return;
                }

                if (jobId == 0)
                {
                    string query = "INSERT INTO JobsTable VALUES('{0}', '{1}')";
                    query = string.Format(query, jobName, estimatedDuration);
                    Con.SetData(query);
                    MessageBox.Show("Job added");
                    JobNameTextBox.Text = "";
                }

                else
                {
                    string query = "UPDATE JobsTable SET JobName = '{0}', EstimatedDuration = '{1}' WHERE jobId = {2}";
                    query = string.Format(query, jobName, estimatedDuration, this.jobId);
                    Con.SetData(query);
                    MessageBox.Show("Job updated");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            Jobs jobs = new Jobs();
            jobs.Show();
            this.Hide();
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            Jobs jobs = new Jobs();
            jobs.Show();
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Jobs jobs = new Jobs();
            jobs.Show();
            this.Hide();
        }
    }
}
