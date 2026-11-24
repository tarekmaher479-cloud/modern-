using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LeaveRequestSystem
{
    public partial class MainDashboard : Form
    {
        private string loggedInUser;
        private static bool isSeeded = false;
        public static List<LeaveRequest> requestList = new List<LeaveRequest>();

        public MainDashboard(string username)
        {
            InitializeComponent();
            loggedInUser = username;

            SeedSampleData();

            lblHeader.Text = $"Welcome back, {loggedInUser}";
            RefreshList();
        }

        private void SeedSampleData()
        {
            if (!isSeeded)
            {
                requestList.Add(new LeaveRequest("Mahmoud", "Annual", 4, "Accepted", DateTime.Now.AddDays(-14)));
                requestList.Add(new LeaveRequest("Ahmed", "Sick", 2, "Rejected", DateTime.Now.AddDays(-6)));
                requestList.Add(new LeaveRequest("Ahmed", "Annual", 5, "Under Review", DateTime.Now.AddDays(-1)));
                isSeeded = true;
            }
        }

        public void RefreshList()
        {
            dgvRequests.Rows.Clear();

            int totalRequests = 0;
            int acceptedDays = 0;
            int underReviewCount = 0;

            foreach (LeaveRequest req in requestList)
            {
                if (req.EmployeeName.Equals(loggedInUser, StringComparison.OrdinalIgnoreCase))
                {
                    totalRequests++;
                    if (req.Status.Equals("Accepted", StringComparison.OrdinalIgnoreCase))
                    {
                        acceptedDays += req.DurationDays;
                    }
                    else if (req.Status.Equals("Under Review", StringComparison.OrdinalIgnoreCase))
                    {
                        underReviewCount++;
                    }

                    dgvRequests.Rows.Add(
                        req.Status.ToUpper(),
                        req.LeaveType,
                        $"{req.DurationDays} {(req.DurationDays == 1 ? "Day" : "Days")}",
                        req.RequestDate.ToString("MMM dd, yyyy")
                    );
                }
            }

            lblSummaryInfo.Text =
                $"My Leave Summary  •  Total Requests: {totalRequests}   |   Approved Days: {acceptedDays}   |   Under Review: {underReviewCount}";
        }

        private void dgvRequests_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            // Color-code the Status partition
            if (e.ColumnIndex == 0 && e.CellStyle != null)
            {
                string status = e.Value.ToString() ?? string.Empty;
                e.CellStyle.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);

                if (status == "ACCEPTED")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(5, 150, 105);
                    e.CellStyle.BackColor = Color.FromArgb(236, 253, 245);
                    e.CellStyle.SelectionForeColor = Color.FromArgb(5, 150, 105);
                    e.CellStyle.SelectionBackColor = Color.FromArgb(209, 250, 229);
                }
                else if (status == "REJECTED")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(225, 29, 72);
                    e.CellStyle.BackColor = Color.FromArgb(255, 241, 242);
                    e.CellStyle.SelectionForeColor = Color.FromArgb(225, 29, 72);
                    e.CellStyle.SelectionBackColor = Color.FromArgb(255, 228, 230);
                }
                else
                {
                    e.CellStyle.ForeColor = Color.FromArgb(217, 119, 6);
                    e.CellStyle.BackColor = Color.FromArgb(255, 251, 235);
                    e.CellStyle.SelectionForeColor = Color.FromArgb(217, 119, 6);
                    e.CellStyle.SelectionBackColor = Color.FromArgb(254, 243, 199);
                }
            }
            // Bold the Leave Type partition
            else if (e.ColumnIndex == 1 && e.CellStyle != null)
            {
                e.CellStyle.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            }
        }

        private void btnNewRequest_Click(object sender, EventArgs e)
        {
            NewRequestForm requestForm = new NewRequestForm(loggedInUser);
            requestForm.ShowDialog();
            RefreshList();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void MainDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}