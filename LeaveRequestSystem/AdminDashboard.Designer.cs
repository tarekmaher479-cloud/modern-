namespace LeaveRequestSystem
{
    partial class AdminDashboard
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlFilterBorder;
        private System.Windows.Forms.Panel pnlFilterCard;
        private System.Windows.Forms.Panel pnlChartCanvas;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.Label lblLastRequestInfo;
        private System.Windows.Forms.Panel pnlSpacer;
        private System.Windows.Forms.Panel pnlTableBorder;
        private System.Windows.Forms.DataGridView dgvAdminRequests;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLeaveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle rowStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle altRowStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlTableBorder = new System.Windows.Forms.Panel();
            this.dgvAdminRequests = new System.Windows.Forms.DataGridView();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLeaveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSpacer = new System.Windows.Forms.Panel();
            this.pnlFilterBorder = new System.Windows.Forms.Panel();
            this.pnlFilterCard = new System.Windows.Forms.Panel();
            this.pnlChartCanvas = new System.Windows.Forms.Panel();
            this.lblLastRequestInfo = new System.Windows.Forms.Label();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();

            this.pnlSidebar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlTableBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminRequests)).BeginInit();
            this.pnlFilterBorder.SuspendLayout();
            this.pnlFilterCard.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnReject);
            this.pnlSidebar.Controls.Add(this.btnAccept);
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 620);
            this.pnlSidebar.TabIndex = 0;
            this.pnlSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSidebar_Paint);

            // 
            // lblLogo
            // 
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(220, 100);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "ADMIN\nPORTAL";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.Location = new System.Drawing.Point(0, 100);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(220, 55);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Accept Request";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);

            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.FromArgb(225, 29, 72);
            this.btnReject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReject.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReject.FlatAppearance.BorderSize = 0;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnReject.ForeColor = System.Drawing.Color.White;
            this.btnReject.Location = new System.Drawing.Point(0, 155);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(220, 55);
            this.btnReject.TabIndex = 2;
            this.btnReject.Text = "Reject Request";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);

            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 570);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(220, 50);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Sign Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.pnlContent.Controls.Add(this.pnlTableBorder);
            this.pnlContent.Controls.Add(this.pnlSpacer);
            this.pnlContent.Controls.Add(this.pnlFilterBorder);
            this.pnlContent.Controls.Add(this.lblHeader);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(220, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(30);
            this.pnlContent.Size = new System.Drawing.Size(740, 620);
            this.pnlContent.TabIndex = 1;

            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblHeader.Location = new System.Drawing.Point(30, 30);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(680, 46);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Employee Leave Requests & History";
            this.lblHeader.UseMnemonic = false;

            // 
            // pnlFilterBorder (1px Slate 200 Card Frame)
            // 
            this.pnlFilterBorder.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.pnlFilterBorder.Controls.Add(this.pnlFilterCard);
            this.pnlFilterBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterBorder.Location = new System.Drawing.Point(30, 76);
            this.pnlFilterBorder.Name = "pnlFilterBorder";
            this.pnlFilterBorder.Padding = new System.Windows.Forms.Padding(1);
            this.pnlFilterBorder.Size = new System.Drawing.Size(680, 132);
            this.pnlFilterBorder.TabIndex = 1;

            // 
            // pnlFilterCard
            // 
            this.pnlFilterCard.BackColor = System.Drawing.Color.White;
            this.pnlFilterCard.Controls.Add(this.pnlChartCanvas);
            this.pnlFilterCard.Controls.Add(this.lblLastRequestInfo);
            this.pnlFilterCard.Controls.Add(this.cmbEmployees);
            this.pnlFilterCard.Controls.Add(this.lblFilter);
            this.pnlFilterCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilterCard.Location = new System.Drawing.Point(1, 1);
            this.pnlFilterCard.Name = "pnlFilterCard";
            this.pnlFilterCard.Size = new System.Drawing.Size(678, 130);
            this.pnlFilterCard.TabIndex = 0;

            // 
            // pnlChartCanvas (GDI+ Donut Chart & Legend Partition)
            // 
            this.pnlChartCanvas.BackColor = System.Drawing.Color.White;
            this.pnlChartCanvas.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlChartCanvas.Location = new System.Drawing.Point(418, 0);
            this.pnlChartCanvas.Name = "pnlChartCanvas";
            this.pnlChartCanvas.Size = new System.Drawing.Size(260, 130);
            this.pnlChartCanvas.TabIndex = 3;
            this.pnlChartCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChartCanvas_Paint);

            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblFilter.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblFilter.Location = new System.Drawing.Point(18, 18);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(145, 23);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "Filter by Employee:";

            // 
            // cmbEmployees
            // 
            this.cmbEmployees.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.cmbEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployees.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular);
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(168, 14);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(232, 31);
            this.cmbEmployees.TabIndex = 1;
            this.cmbEmployees.SelectedIndexChanged += new System.EventHandler(this.cmbEmployees_SelectedIndexChanged);

            // 
            // lblLastRequestInfo
            // 
            this.lblLastRequestInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.lblLastRequestInfo.ForeColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.lblLastRequestInfo.Location = new System.Drawing.Point(18, 56);
            this.lblLastRequestInfo.Name = "lblLastRequestInfo";
            this.lblLastRequestInfo.Size = new System.Drawing.Size(385, 62);
            this.lblLastRequestInfo.TabIndex = 2;
            this.lblLastRequestInfo.Text = "Select an employee above to inspect their request history and last leave details.";

            // 
            // pnlSpacer
            // 
            this.pnlSpacer.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.pnlSpacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpacer.Location = new System.Drawing.Point(30, 208);
            this.pnlSpacer.Name = "pnlSpacer";
            this.pnlSpacer.Size = new System.Drawing.Size(680, 18);
            this.pnlSpacer.TabIndex = 2;

            // 
            // pnlTableBorder
            // 
            this.pnlTableBorder.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.pnlTableBorder.Controls.Add(this.dgvAdminRequests);
            this.pnlTableBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTableBorder.Location = new System.Drawing.Point(30, 226);
            this.pnlTableBorder.Name = "pnlTableBorder";
            this.pnlTableBorder.Padding = new System.Windows.Forms.Padding(1);
            this.pnlTableBorder.Size = new System.Drawing.Size(680, 364);
            this.pnlTableBorder.TabIndex = 3;

            // 
            // dgvAdminRequests
            // 
            this.dgvAdminRequests.AllowUserToAddRows = false;
            this.dgvAdminRequests.AllowUserToDeleteRows = false;
            this.dgvAdminRequests.AllowUserToResizeColumns = false;
            this.dgvAdminRequests.AllowUserToResizeRows = false;
            this.dgvAdminRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdminRequests.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdminRequests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAdminRequests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvAdminRequests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;

            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            headerStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            headerStyle.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            headerStyle.SelectionBackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            headerStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            headerStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdminRequests.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvAdminRequests.ColumnHeadersHeight = 42;
            this.dgvAdminRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            this.dgvAdminRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colStatus,
                this.colEmployee,
                this.colLeaveType,
                this.colDuration,
                this.colDate
            });

            rowStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            rowStyle.BackColor = System.Drawing.Color.White;
            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular);
            rowStyle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            rowStyle.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            rowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(238, 242, 255);
            rowStyle.SelectionForeColor = System.Drawing.Color.FromArgb(30, 27, 75);
            rowStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdminRequests.DefaultCellStyle = rowStyle;

            altRowStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgvAdminRequests.AlternatingRowsDefaultCellStyle = altRowStyle;

            this.dgvAdminRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdminRequests.EnableHeadersVisualStyles = false;
            this.dgvAdminRequests.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvAdminRequests.Location = new System.Drawing.Point(1, 1);
            this.dgvAdminRequests.MultiSelect = false;
            this.dgvAdminRequests.Name = "dgvAdminRequests";
            this.dgvAdminRequests.ReadOnly = true;
            this.dgvAdminRequests.RowHeadersVisible = false;
            this.dgvAdminRequests.RowTemplate.Height = 46;
            this.dgvAdminRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdminRequests.Size = new System.Drawing.Size(678, 362);
            this.dgvAdminRequests.TabIndex = 0;
            this.dgvAdminRequests.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAdminRequests_CellFormatting);

            // 
            // Columns
            // 
            this.colStatus.FillWeight = 22F;
            this.colStatus.HeaderText = "STATUS";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            this.colEmployee.FillWeight = 20F;
            this.colEmployee.HeaderText = "EMPLOYEE";
            this.colEmployee.Name = "colEmployee";
            this.colEmployee.ReadOnly = true;
            this.colEmployee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            this.colLeaveType.FillWeight = 18F;
            this.colLeaveType.HeaderText = "LEAVE TYPE";
            this.colLeaveType.Name = "colLeaveType";
            this.colLeaveType.ReadOnly = true;
            this.colLeaveType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            this.colDuration.FillWeight = 17F;
            this.colDuration.HeaderText = "DURATION";
            this.colDuration.Name = "colDuration";
            this.colDuration.ReadOnly = true;
            this.colDuration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            this.colDate.FillWeight = 23F;
            this.colDate.HeaderText = "SUBMITTED";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 620);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminDashboard_FormClosed);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlTableBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminRequests)).EndInit();
            this.pnlFilterBorder.ResumeLayout(false);
            this.pnlFilterCard.ResumeLayout(false);
            this.pnlFilterCard.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}