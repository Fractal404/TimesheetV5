using System;
using System.Drawing;
using System.Windows.Forms;

namespace TimesheetV5
{
    public partial class Employees : Form
    {
        public static Employees instance;
        private EmployeesPopup employeesPopup = new EmployeesPopup();
        Functions Con;
        public Employees()
        {
            InitializeComponent();
            Con = new Functions();
            instance = this;
            ListEmployees();
        }

        private void ListEmployees()
        {
            try
            {
                string Query = "SELECT * FROM EmployeesTable";
                EmployeeListDataGridViewer.DataSource = Con.GetData(Query);
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void EmployeeListDataGridViewer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (EmployeeListDataGridViewer.SelectedRows[0].Cells[1].Value.ToString() == "")
            {
                return;
            }
            string employeeName = EmployeeListDataGridViewer.SelectedRows[0].Cells[1].Value.ToString();
            int employeeId = Convert.ToInt32(EmployeeListDataGridViewer.SelectedRows[0].Cells[0].Value.ToString());
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

                employeesPopup.Owner = FormBackground;
                employeesPopup.UpdateEmployee(employeeId, employeeName);

                FormBackground.Dispose();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Form FormBackground = new Form();
            EmployeesPopup employeesPopup = new EmployeesPopup();
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

                employeesPopup.Owner = FormBackground;
                employeesPopup.ShowDialog();

                FormBackground.Dispose();
            }
        }
        private void AddButton_MouseHover(object sender, EventArgs e)
        {
            AddToolTip.Show("Click here on the Add button to add a new employee", AddButton);
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
