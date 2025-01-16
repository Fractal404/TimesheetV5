using System;
using System.Drawing;
using System.Windows.Forms;

namespace TimesheetV5
{
    public partial class Timesheets : Form
    {
        public static Timesheets instance;
        private TimesheetsPopup timesheetsPopup = new TimesheetsPopup();
        Functions Con;
        public Timesheets()
        {
            InitializeComponent();
            Con = new Functions();
            instance = this;
            ListTimesheets();
        }

        private void ListTimesheets()
        {
            try
            {
                string Query = "SELECT * FROM TimesheetsTable";
                TimesheetListDataGridViewer.DataSource = Con.GetData(Query);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void TimesheetListDataGridViewer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TimesheetListDataGridViewer.SelectedRows[0].Cells[1].Value.ToString() == "")
            {
                return;
            }

            string timesheetPeriod = TimesheetListDataGridViewer.SelectedRows[0].Cells[1].Value.ToString();
            string employeeId = TimesheetListDataGridViewer.SelectedRows[0].Cells[2].Value.ToString();
            string employeeName = TimesheetListDataGridViewer.SelectedRows[0].Cells[3].Value.ToString();
            int timesheetId = Convert.ToInt32(TimesheetListDataGridViewer.SelectedRows[0].Cells[0].Value.ToString());

            TimesheetItems Obj = new TimesheetItems();

            Obj.ShowTimesheetItems(timesheetId, employeeId, employeeName, timesheetPeriod);
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Form FormBackground = new Form();
            TimesheetsPopup timesheetsPopupForm = new TimesheetsPopup();
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

                timesheetsPopupForm.Owner = FormBackground;
                timesheetsPopupForm.ShowDialog();

                FormBackground.Dispose();
            }
        }

        private void AddButton_MouseHover(object sender, EventArgs e)
        {
            AddToolTip.Show("Click here on the Add button to add a new timesheet", AddButton);
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

        private void JobsLabel_Click(object sender, EventArgs e)
        {
            Jobs Obj = new Jobs();
            Obj.Show();
            this.Hide();
        }

        private void JobsPictureBox_Click(object sender, EventArgs e)
        {
            Jobs Obj = new Jobs();
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
