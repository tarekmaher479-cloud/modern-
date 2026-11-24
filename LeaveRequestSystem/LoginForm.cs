using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LeaveRequestSystem
{
    public partial class LoginForm : Form
    {
        private List<Employee> employees = new List<Employee>();

        public LoginForm()
        {
            InitializeComponent();

            // Load employee accounts using your OOP Employee class
            employees.Add(new Employee(101, "Mahmoud", "1234"));
            employees.Add(new Employee(102, "Ahmed", "1234"));

            // Ensure closing the login window via 'X' shuts down the app cleanly
            this.FormClosed += (s, args) => Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // 1. Check Administrator credentials
            if (username.Equals("Admin", StringComparison.OrdinalIgnoreCase) && password == "admin123")
            {
                txtPassword.Clear();
                AdminDashboard adminForm = new AdminDashboard();
                adminForm.Show();
                this.Hide();
                return;
            }

            // 2. Check Employee credentials
            foreach (Employee emp in employees)
            {
                if (emp.Name.Equals(username, StringComparison.OrdinalIgnoreCase) && emp.Password == password)
                {
                    txtPassword.Clear();
                    MainDashboard dashboard = new MainDashboard(emp.Name);
                    dashboard.Show();
                    this.Hide();
                    return;
                }
            }

            // 3. Failed login
            MessageBox.Show("Invalid username or password. Please try again.",
                            "Authentication Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }
}