using System;
using System.Drawing;
using System.Windows.Forms;

namespace TimesheetV5
{
    public partial class TimesheetItems : Form
    {
        public static TimesheetItems instance;
        private TimesheetItemsPopup timesheetItemsPopup = new TimesheetItemsPopup();
        Functions Con;

        int timesheetId;
        string employeeId;
        string timesheetPeriod;
        string employeeName;

        public TimesheetItems()
        {
            InitializeComponent();
            Con = new Functions();
            instance = this;

        }
        public void ShowTimesheetItems(int timesheetId, string employeeId, string employeeName, string timesheetPeriod)
        {
            
            try
            {
                DateTime parsedDate = DateTime.Parse(timesheetPeriod);
                TimesheetItemsManagementLabel.Text = employeeName + "'s Timesheet Management for " + parsedDate.ToString("dd/MM/yyyy");
                this.timesheetId = timesheetId;
                this.employeeId = employeeId;
                this.employeeName = employeeName;
                this.timesheetPeriod = timesheetPeriod;
                string Query = string.Format("SELECT * FROM TimesheetItemsTable WHERE timesheetId = {0}", timesheetId);
                TimesheetItemsListDataGridViewer.DataSource = Con.GetData(Query);

                this.Show();
            }
            catch (Exception)
            {
                throw;
            }
            Show();
        }

        private void TimesheetItemListDataGridViewer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TimesheetItemsListDataGridViewer.SelectedRows[0].Cells[1].Value.ToString() == "")
            {
                return;
            }
            int timesheetId = Convert.ToInt32(TimesheetItemsListDataGridViewer.SelectedRows[0].Cells[1].Value.ToString());
            int jobId = Convert.ToInt32(TimesheetItemsListDataGridViewer.SelectedRows[0].Cells[2].Value.ToString());
            string jobName = TimesheetItemsListDataGridViewer.SelectedRows[0].Cells[3].Value.ToString();
            string monday = TimesheetItemsListDataGridViewer.SelectedRows[0].Cells[4].Value.ToString();
            string tuesday = TimesheetItemsListDataGridViewer.SelectedRows[0].Cells[5].Value.ToString();
            string wednesday = TimesheetItemsListDataGridViewer.SelectedRows[0].Cells[6].Value.ToString();
            string thursday = TimesheetItemsListDataGridViewer.SelectedRows[0].Cells[7].Value.ToString();
            string friday = TimesheetItemsListDataGridViewer.SelectedRows[0].Cells[8].Value.ToString();
            string saturday = TimesheetItemsListDataGridViewer.SelectedRows[0].Cells[9].Value.ToString();
            string sunday = TimesheetItemsListDataGridViewer.SelectedRows[0].Cells[10].Value.ToString();
            int timesheetItemId = Convert.ToInt32(TimesheetItemsListDataGridViewer.SelectedRows[0].Cells[0].Value.ToString());
            
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

                timesheetItemsPopup.Owner = FormBackground;
                timesheetItemsPopup.UpdateTimesheetItems(timesheetId, jobId, jobName, monday, tuesday, wednesday, thursday, friday, saturday, sunday, timesheetItemId, employeeId, employeeName, timesheetPeriod);

                FormBackground.Dispose();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Form FormBackground = new Form();
            TimesheetItemsPopup timesheetItemsPopup = new TimesheetItemsPopup();
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

                timesheetItemsPopup.Owner = FormBackground;
                timesheetItemsPopup.AddTimesheetItems(this.timesheetId, this.employeeId, this.employeeName, this.timesheetPeriod);

                FormBackground.Dispose();
            }
        }

        private void AddButton_MouseHover(object sender, EventArgs e)
        {
            AddToolTip.Show("Click here on the Add button to add a new timesheet", AddButton);
        }

        private void EmployeesLabel_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.Show();
            this.Hide();
        }

        private void EmployeesPictureBox_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.Show();
            this.Hide();
        }

        private void JobsLabel_Click(object sender, EventArgs e)
        {
            Jobs jobs = new Jobs();
            jobs.Show();
            this.Hide();
        }

        private void JobsPictureBox_Click(object sender, EventArgs e)
        {
            Jobs jobs = new Jobs();
            jobs.Show();
            this.Hide();
        }

        private void TimesheetsLabel_Click(object sender, EventArgs e)
        {
            Timesheets timesheets = new Timesheets();
            timesheets.Show();
            this.Hide();
        }

        private void TimesheetsPictureBox_Click(object sender, EventArgs e)
        {
            Timesheets timesheets = new Timesheets();
            timesheets.Show();
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
