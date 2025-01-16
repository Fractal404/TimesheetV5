using System;
using System.Windows.Forms;

namespace TimesheetV5
{
    public partial class TimesheetsPopup : Form
    {
        public static TimesheetsPopup instance;
        private DateTimePicker weekEnding;
        private int timesheetId;
        private int employeeId;
        private ComboBox employeeName;
        Functions Con;
        public TimesheetsPopup()
        {
            InitializeComponent();
            instance = this;
            Con = new Functions();
            employeeName = EmployeeIdComboBox;
            weekEnding = WeekEndingDateTimePicker;
            GetEmployeeNames();
        }
        public void AddTimesheet()
        {
            this.timesheetId = -1;
            this.employeeId = -1;
            this.weekEnding.Value = DateTime.Now;
            this.employeeName.Text = "";

            this.ShowDialog();
        }

        private void GetEmployeeNames()
        {
            string Query = "Select * from EmployeesTable";
            EmployeeIdComboBox.DisplayMember = Con.GetData(Query).Columns["employeeName"].ToString();
            EmployeeIdComboBox.ValueMember = Con.GetData(Query).Columns["employeeId"].ToString();
            EmployeeIdComboBox.DataSource = Con.GetData(Query);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime weekEnding = WeekEndingDateTimePicker.Value;
                string employeeName = this.employeeName.Text;
                string employeeId = EmployeeIdComboBox.SelectedValue.ToString();

                if (string.IsNullOrEmpty(employeeName))
                {
                    MessageBox.Show("No timesheet has beed added, please add one");
                    return;
                }

                if (weekEnding.DayOfWeek != DayOfWeek.Sunday)
                {
                    MessageBox.Show("Timesheet must end on a Sunday");
                    return;
                }
                
                else 
                {
                    string Query = "INSERT INTO TimesheetsTable VALUES ('{0}', {1}, '{2}')";
                    Query = string.Format(Query, weekEnding.ToString("yyyy-MM-dd"), employeeId, employeeName);

                    Con.SetData(Query);
                    MessageBox.Show("Timesheet added");
                    WeekEndingDateTimePicker.Value = DateTime.Now;
                    this.employeeName.Text = "";
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            Timesheets timesheets = new Timesheets();
            timesheets.Show();
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Timesheets timesheets = new Timesheets();
            timesheets.Show();
            this.Hide();
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            Timesheets timesheets = new Timesheets();
            timesheets.Show();
            this.Hide();
        }
    }
}
