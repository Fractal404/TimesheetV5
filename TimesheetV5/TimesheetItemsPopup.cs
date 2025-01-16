using System;
using System.Data;
using System.Net.Mail;
using System.Windows.Forms;

namespace TimesheetV5
{
    public partial class TimesheetItemsPopup : Form
    {
        public static TimesheetItemsPopup instance;
        Functions Con;
        private bool isUpdate = false;
        private int timesheetId;
        private int jobId;
        private string jobName;
        private string monday;
        private string tuesday;
        private string wednesday;
        private string thursday;
        private string friday;
        private string saturday;
        private string sunday;
        private int timesheetItemsId;
        private string employeeId;
        private string employeeName;
        private string timesheetPeriod;
        public TimesheetItemsPopup()
        {
            InitializeComponent();
            instance = this;
            Con = new Functions();
            GetJobIDs();
        }


        public void UpdateTimesheetItems(int timesheetId, int jobId, string jobName, string monday, string tuesday, string wednesday, string thursday, string friday, string saturday, string sunday, int timesheetItemsId, string employeeId, string employeeName, string timesheetPeriod)
        {
            this.isUpdate = true;
            this.timesheetId = timesheetId;
            this.jobId = jobId;
            this.jobName = jobName;
            this.monday = monday;
            this.tuesday = tuesday;
            this.wednesday = wednesday;
            this.thursday = thursday;
            this.friday = friday;
            this.saturday = saturday;
            this.sunday = sunday;
            this.timesheetItemsId = timesheetItemsId;
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.timesheetPeriod = timesheetPeriod;
            JobIdComboBox.Text = jobName;
            MondayTextBox.Text = monday;
            TuesdayTextBox.Text = tuesday;
            WednesdayTextBox.Text = wednesday;
            ThursdayTextBox.Text = thursday;
            FridayTextBox.Text = friday;
            SaturdayTextBox.Text = saturday;
            SundayTextBox.Text = sunday;

            this.ShowDialog();
        }

        public void AddTimesheetItems(int timeSheetId, string employeeId, string employeeName, string timesheetPeriod)
        {
            this.isUpdate = false;
            this.timesheetId = timeSheetId;
            this.jobId = 0;
            this.jobName = "";
            this.monday = "";
            this.tuesday = "";
            this.wednesday = "";
            this.thursday = "";
            this.friday = "";
            this.saturday = "";
            this.sunday = "";
            this.timesheetItemsId = -1;
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.timesheetPeriod = timesheetPeriod;

            this.ShowDialog();
        }

        private void GetJobIDs()
        {
            string Query = "Select * from JobsTable";
            JobIdComboBox.DisplayMember = Con.GetData(Query).Columns["JobName"].ToString();
            JobIdComboBox.ValueMember = Con.GetData(Query).Columns["jobId"].ToString();
            JobIdComboBox.DataSource = Con.GetData(Query);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string GetNullableFromTextBox(TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        return "0";
                    }
                    return textBox.Text;
                }

                int jobId = Convert.ToInt32(JobIdComboBox.SelectedValue);
                string jobName = JobIdComboBox.Text;
                string monday = GetNullableFromTextBox(MondayTextBox);
                string tuesday = GetNullableFromTextBox(TuesdayTextBox);
                string wednesday = GetNullableFromTextBox(WednesdayTextBox);
                string thursday = GetNullableFromTextBox(ThursdayTextBox);
                string friday = GetNullableFromTextBox(FridayTextBox);
                string saturday = GetNullableFromTextBox(SaturdayTextBox);
                string sunday = GetNullableFromTextBox(SundayTextBox);


                if (isUpdate)
                {
                    string Query = "UPDATE TimesheetItemsTable SET timesheetId = {0}, jobId = {1}, JobName = '{2}', Monday = {3}, Tuesday = {4}, Wednesday = {5}, Thursday = {6}, Friday = {7}, Saturday = {8}, Sunday = {9} WHERE TimesheetItemId = {10}";
                    Query = string.Format(Query, timesheetId, jobId, jobName, monday, tuesday, wednesday, thursday, friday, saturday, sunday, this.timesheetItemsId);
                    Con.SetData(Query);
                    MessageBox.Show("Timesheet item updated");

                }
                else
                {
                    string Query = "INSERT INTO TimesheetItemsTable VALUES ({0}, {1}, '{2}', {3}, {4}, {5}, {6}, {7}, {8}, {9})";
                    Query = string.Format(Query, timesheetId, jobId, jobName, monday, tuesday, wednesday, thursday, friday, saturday, sunday);
                    Con.SetData(Query);
                    MessageBox.Show("Timesheet item added");
                }

                DataTable timesheetTotals = Con.GetData("SELECT * FROM TimesheetDayTotals WHERE timesheetId = " + timesheetId);
                DataRow row = timesheetTotals.Rows[0];

                if (
                    Convert.ToInt32(row["MondayTotal"]) >= 10 ||
                    Convert.ToInt32(row["TuesdayTotal"]) >= 10 ||
                    Convert.ToInt32(row["WednesdayTotal"]) >= 10 ||
                    Convert.ToInt32(row["ThursdayTotal"]) >= 10 ||
                    Convert.ToInt32(row["FridayTotal"]) >= 10 ||
                    Convert.ToInt32(row["SaturdayTotal"]) >= 10 ||
                    Convert.ToInt32(row["SundayTotal"]) >= 10
                )
                {

                    string emailFrom = "leahawhitlock@gmail.com";
                    string emailPassword = "Password123!";
                    string employeeName = this.employeeName;
                    string emailTo = "developmenttask@springboardit.co.uk";
                    MailMessage message = new MailMessage();
                    message.From = new MailAddress(emailFrom);
                    message.Subject = "10 Hour Threshold Exceeded";
                    message.To.Add(emailTo);
                    message.Body = string.Format(employeeName + "'s timesheet has exceded the 10 hour threshold for a day. Please review their timesheets for the " + timesheetPeriod + "if required.");
                    message.IsBodyHtml = true;

                    //Almost got it working :)

                    //var smtpClient = new SmtpClient("smtp.gmail.com")
                    //{
                    //    Port = 587,
                    //    Credentials = new NetworkCredential(emailFrom, emailPassword),
                    //    EnableSsl = true,
                    //};

                    //smtpClient.Send(message);

                    MessageBox.Show("10 hour per day duration has been exceded, email to management has been sent");

                }
            }
            catch (Exception Ex)
            {
                Ex.StackTrace.ToString();
                MessageBox.Show(Ex.Message);
            }

            TimesheetItems timesheetItems = new TimesheetItems();
            timesheetItems.ShowTimesheetItems(timesheetId, employeeId, employeeName, timesheetPeriod);
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            TimesheetItems timesheetItems = new TimesheetItems();
            timesheetItems.ShowTimesheetItems(timesheetId, employeeId, employeeName, timesheetPeriod);
            this.Hide();
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            TimesheetItems timesheetItems = new TimesheetItems();
            timesheetItems.ShowTimesheetItems(timesheetId, employeeId, employeeName, timesheetPeriod);
            this.Hide();
        }

        private void MondayTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ThursdayTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
