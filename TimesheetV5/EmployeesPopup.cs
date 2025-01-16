using System;
using System.Windows.Forms;

namespace TimesheetV5
{
    public partial class EmployeesPopup : Form
    {
        public static EmployeesPopup instance;
        private TextBox employeeName;
        private int employeeId;
        Functions Con;
        public EmployeesPopup()
        {
            InitializeComponent();
            instance = this;
            Con = new Functions();
            employeeName = EmployeeNameTextBox;
        }

        public void UpdateEmployee(int employeeId, string employeeName)
        {
            this.employeeId = employeeId;
            this.employeeName.Text = employeeName;

            this.ShowDialog();
        }

        public void AddEmployee()
        {
            this.employeeId = -1;
            this.employeeName.Text = "";

            this.ShowDialog();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = EmployeeNameTextBox.Text;
                if (Name == "")
                {
                    MessageBox.Show("No employee has beed added, please add someone");
                    return;
                }

                if (employeeId == 0)
                {
                    string Query = "INSERT INTO EmployeesTable VALUES('{0}')";
                    Query = string.Format(Query, Name);
                    Con.SetData(Query);
                    MessageBox.Show("Employee added");
                    EmployeeNameTextBox.Text = "";
                }

                else
                {
                    string Query = "UPDATE EmployeesTable SET employeeName = '{0}' WHERE employeeId = {1}";
                    Query = string.Format(Query, Name, this.employeeId);
                    Con.SetData(Query);
                    MessageBox.Show("Employee updated");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            Employees employees = new Employees();
            employees.Show();
            this.Hide();
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.Show();
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.Show();
            this.Hide();
        }
    }
}
