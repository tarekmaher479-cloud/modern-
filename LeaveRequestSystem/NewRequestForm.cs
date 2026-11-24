using System;
using System.Windows.Forms;

namespace LeaveRequestSystem
{
    public partial class NewRequestForm : Form
    {
        private string employeeName = string.Empty;

        public NewRequestForm()
        {
            InitializeComponent();
        }

        public NewRequestForm(string name) : this()
        {
            employeeName = name;
            lblSubtitle.Text = $"Submitting as: {employeeName}";

            cmbLeaveType.Items.Clear();
            cmbLeaveType.Items.Add("Annual");
            cmbLeaveType.Items.Add("Sick");
            cmbLeaveType.Items.Add("Unpaid");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1. Dropdown Selection Validation
            if (cmbLeaveType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a leave type.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // 2. Numeric Input Validation
            int days;
            if (!int.TryParse(txtDuration.Text, out days))
            {
                MessageBox.Show("Duration must be a valid number.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // 3. Business Rule Validation
            if (days <= 0 || days > 30)
            {
                MessageBox.Show("Leave duration must be between 1 and 30 days.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // 4. Create new LeaveRequest (defaults to "Under Review") and append to shared list
            LeaveRequest newReq = new LeaveRequest(employeeName, cmbLeaveType.Text, days);
            MainDashboard.requestList.Add(newReq);

            MessageBox.Show("Leave request submitted successfully!",
                            "Request Submitted",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}