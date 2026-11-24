using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LeaveRequestSystem
{
    public partial class AdminDashboard : Form
    {
        private List<LeaveRequest> displayedRequests = new List<LeaveRequest>();

        public AdminDashboard()
        {
            InitializeComponent();
            EnsureSeededData();
            PopulateEmployeeDropdown();
            RefreshAdminView();
        }

        private void EnsureSeededData()
        {
            if (MainDashboard.requestList.Count == 0)
            {
                MainDashboard.requestList.Add(new LeaveRequest("Mahmoud", "Annual", 4, "Accepted", DateTime.Now.AddDays(-14)));
                MainDashboard.requestList.Add(new LeaveRequest("Ahmed", "Sick", 2, "Rejected", DateTime.Now.AddDays(-6)));
                MainDashboard.requestList.Add(new LeaveRequest("Ahmed", "Annual", 5, "Under Review", DateTime.Now.AddDays(-1)));
            }
        }

        private void PopulateEmployeeDropdown()
        {
            cmbEmployees.Items.Clear();
            cmbEmployees.Items.Add("All Employees");

            foreach (LeaveRequest req in MainDashboard.requestList)
            {
                if (!cmbEmployees.Items.Contains(req.EmployeeName))
                {
                    cmbEmployees.Items.Add(req.EmployeeName);
                }
            }

            cmbEmployees.SelectedIndex = 0;
        }

        private void RefreshAdminView(int preserveRowIndex = -1)
        {
            string selectedFilter = cmbEmployees.SelectedItem?.ToString() ?? "All Employees";

            dgvAdminRequests.Rows.Clear();
            displayedRequests.Clear();

            foreach (LeaveRequest req in MainDashboard.requestList)
            {
                if (selectedFilter == "All Employees" ||
                    req.EmployeeName.Equals(selectedFilter, StringComparison.OrdinalIgnoreCase))
                {
                    displayedRequests.Add(req);
                    dgvAdminRequests.Rows.Add(
                        req.Status.ToUpper(),
                        req.EmployeeName,
                        req.LeaveType,
                        $"{req.DurationDays} {(req.DurationDays == 1 ? "Day" : "Days")}",
                        req.RequestDate.ToString("MMM dd, yyyy")
                    );
                }
            }

            if (preserveRowIndex >= 0 && preserveRowIndex < dgvAdminRequests.Rows.Count)
            {
                dgvAdminRequests.ClearSelection();
                dgvAdminRequests.Rows[preserveRowIndex].Selected = true;
            }

            UpdateEmployeeHistorySummary(selectedFilter);

            // Force GDI+ visualization canvas to repaint with updated counts
            pnlChartCanvas.Invalidate();
        }

        private void UpdateEmployeeHistorySummary(string selectedEmployee)
        {
            if (selectedEmployee == "All Employees")
            {
                lblLastRequestInfo.Text = $"Showing all {displayedRequests.Count} request(s) across the organization.\r\nSelect an employee above to inspect their history & last leave.";
                return;
            }

            if (displayedRequests.Count == 0)
            {
                lblLastRequestInfo.Text = $"Employee: {selectedEmployee}  |  No leave history found.";
                return;
            }

            LeaveRequest lastReq = displayedRequests[0];
            foreach (LeaveRequest req in displayedRequests)
            {
                if (req.RequestDate > lastReq.RequestDate)
                {
                    lastReq = req;
                }
            }

            TimeSpan elapsed = DateTime.Now - lastReq.RequestDate;
            string timeAgoText;

            if (elapsed.TotalMinutes < 1)
                timeAgoText = "Just now";
            else if (elapsed.TotalHours < 1)
                timeAgoText = $"{(int)elapsed.TotalMinutes} min(s) ago";
            else if (elapsed.TotalDays < 1)
                timeAgoText = $"{(int)elapsed.TotalHours} hr(s) ago";
            else
                timeAgoText = $"{(int)elapsed.TotalDays} day(s) ago";

            lblLastRequestInfo.Text =
                $"Employee: {selectedEmployee}  •  History: {displayedRequests.Count} request(s)\r\n" +
                $"Last: {lastReq.LeaveType} ({lastReq.DurationDays}d) • {timeAgoText} ({lastReq.RequestDate:MMM dd})";
        }

        // =========================================================================
        // GDI+ CUSTOM GRAPHICS & VISUALIZATION (Paint Event Handlers)
        // =========================================================================

        private void pnlChartCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // 1. Draw vertical partition divider line using GDI+ Pen
            using (Pen dividerPen = new Pen(Color.FromArgb(226, 232, 240), 1))
            {
                g.DrawLine(dividerPen, 0, 14, 0, pnlChartCanvas.Height - 14);
            }

            // 2. Count request statuses for visualization
            int acceptedCount = 0;
            int pendingCount = 0;
            int rejectedCount = 0;

            foreach (LeaveRequest req in displayedRequests)
            {
                if (req.Status.Equals("Accepted", StringComparison.OrdinalIgnoreCase))
                    acceptedCount++;
                else if (req.Status.Equals("Rejected", StringComparison.OrdinalIgnoreCase))
                    rejectedCount++;
                else
                    pendingCount++;
            }

            int total = displayedRequests.Count;

            Color emerald = Color.FromArgb(16, 185, 129);
            Color amber = Color.FromArgb(245, 158, 11);
            Color rose = Color.FromArgb(225, 29, 72);
            Color slateEmpty = Color.FromArgb(226, 232, 240);

            // 3. Draw Section Title
            using (Font titleFont = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold))
            using (SolidBrush titleBrush = new SolidBrush(Color.FromArgb(100, 116, 139)))
            {
                g.DrawString("STATUS BREAKDOWN", titleFont, titleBrush, 16, 10);
            }

            // 4. Draw Donut Chart (Pie slices + White center cutout)
            Rectangle chartRect = new Rectangle(16, 33, 82, 82);
            Rectangle innerRect = new Rectangle(35, 52, 44, 44);

            if (total == 0)
            {
                using (SolidBrush emptyBrush = new SolidBrush(slateEmpty))
                {
                    g.FillEllipse(emptyBrush, chartRect);
                }
            }
            else
            {
                float startAngle = -90f; // Start at 12 o'clock
                float acceptedSweep = (acceptedCount / (float)total) * 360f;
                float pendingSweep = (pendingCount / (float)total) * 360f;
                float rejectedSweep = 360f - acceptedSweep - pendingSweep;

                if (acceptedCount > 0)
                {
                    using (SolidBrush b = new SolidBrush(emerald))
                        g.FillPie(b, chartRect, startAngle, acceptedSweep);
                    startAngle += acceptedSweep;
                }

                if (pendingCount > 0)
                {
                    using (SolidBrush b = new SolidBrush(amber))
                        g.FillPie(b, chartRect, startAngle, pendingSweep);
                    startAngle += pendingSweep;
                }

                if (rejectedCount > 0)
                {
                    using (SolidBrush b = new SolidBrush(rose))
                        g.FillPie(b, chartRect, startAngle, rejectedSweep);
                }
            }

            // Cut out the center circle to form a modern Donut Chart
            g.FillEllipse(Brushes.White, innerRect);

            // Draw total count centered inside the donut hole
            string centerText = total.ToString();
            using (Font countFont = new Font("Segoe UI", 12F, FontStyle.Bold))
            using (SolidBrush countBrush = new SolidBrush(Color.FromArgb(15, 23, 42)))
            {
                SizeF textSize = g.MeasureString(centerText, countFont);
                float textX = innerRect.X + (innerRect.Width - textSize.Width) / 2f;
                float textY = innerRect.Y + (innerRect.Height - textSize.Height) / 2f;
                g.DrawString(centerText, countFont, countBrush, textX, textY);
            }

            // 5. Draw GDI+ Legend Dots & Labels
            DrawLegendItem(g, emerald, $"Accepted: {acceptedCount}", 112, 36);
            DrawLegendItem(g, amber, $"Review: {pendingCount}", 112, 60);
            DrawLegendItem(g, rose, $"Rejected: {rejectedCount}", 112, 84);
        }

        private void DrawLegendItem(Graphics g, Color dotColor, string label, int x, int y)
        {
            using (SolidBrush dotBrush = new SolidBrush(dotColor))
            {
                g.FillEllipse(dotBrush, x, y + 4, 10, 10);
            }

            using (Font legendFont = new Font("Segoe UI Semibold", 9F, FontStyle.Bold))
            using (SolidBrush textBrush = new SolidBrush(Color.FromArgb(51, 65, 85)))
            {
                g.DrawString(label, legendFont, textBrush, x + 16, y);
            }
        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {
            // Draw a custom GDI+ LinearGradientBrush accent bar along the right edge of the sidebar
            Rectangle accentRect = new Rectangle(pnlSidebar.Width - 4, 0, 4, pnlSidebar.Height);
            using (LinearGradientBrush gradBrush = new LinearGradientBrush(
                accentRect,
                Color.FromArgb(79, 70, 229),   // Indigo 600
                Color.FromArgb(16, 185, 129),  // Emerald 500
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(gradBrush, accentRect);
            }
        }

        // =========================================================================
        // DATAGRIDVIEW STYLING & BUTTON EVENTS
        // =========================================================================

        private void dgvAdminRequests_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

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
            else if (e.ColumnIndex == 1 && e.CellStyle != null)
            {
                e.CellStyle.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (dgvAdminRequests.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a request row to accept.",
                                "No Request Selected",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int idx = dgvAdminRequests.SelectedRows[0].Index;
            displayedRequests[idx].Status = "Accepted";
            RefreshAdminView(idx);
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dgvAdminRequests.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a request row to reject.",
                                "No Request Selected",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int idx = dgvAdminRequests.SelectedRows[0].Index;
            displayedRequests[idx].Status = "Rejected";
            RefreshAdminView(idx);
        }

        private void cmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAdminView();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}