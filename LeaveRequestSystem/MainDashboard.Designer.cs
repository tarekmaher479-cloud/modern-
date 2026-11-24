namespace LeaveRequestSystem
{
    partial class MainDashboard
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnNewRequest;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlSummaryBorder;
        private System.Windows.Forms.Panel pnlSummaryCard;
        private System.Windows.Forms.Label lblSummaryInfo;
        private System.Windows.Forms.Panel pnlSpacer;
        private System.Windows.Forms.Panel pnlTableBorder;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
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
            this.btnNewRequest = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlTableBorder = new System.Windows.Forms.Panel();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLeaveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSpacer = new System.Windows.Forms.Panel();
            this.pnlSummaryBorder = new System.Windows.Forms.Panel();
            this.pnlSummaryCard = new System.Windows.Forms.Panel();
            this.lblSummaryInfo = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();

            this.pnlSidebar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlTableBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.pnlSummaryBorder.SuspendLayout();
            this.pnlSummaryCard.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnNewRequest);
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 620);
            this.pnlSidebar.TabIndex = 0;

            // 
            // lblLogo
            // 
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(220, 100);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "LEAVE\nSYSTEM";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // btnNewRequest
            // 
            this.btnNewRequest.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.btnNewRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewRequest.FlatAppearance.BorderSize = 0;
            this.btnNewRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRequest.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnNewRequest.ForeColor = System.Drawing.Color.White;
            this.btnNewRequest.Location = new System.Drawing.Point(0, 100);
            this.btnNewRequest.Name = "btnNewRequest";
            this.btnNewRequest.Size = new System.Drawing.Size(220, 55);
            this.btnNewRequest.TabIndex = 0;
            this.btnNewRequest.Text = "+ Create Request";
            this.btnNewRequest.UseVisualStyleBackColor = false;
            this.btnNewRequest.Click += new System.EventHandler(this.btnNewRequest_Click);

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
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Sign Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.pnlContent.Controls.Add(this.pnlTableBorder);
            this.pnlContent.Controls.Add(this.pnlSpacer);
            this.pnlContent.Controls.Add(this.pnlSummaryBorder);
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
            this.lblHeader.Text = "My Leave Requests";
            this.lblHeader.UseMnemonic = false;

            // 
            // pnlSummaryBorder (1px Slate 200 Card Frame)
            // 
            this.pnlSummaryBorder.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.pnlSummaryBorder.Controls.Add(this.pnlSummaryCard);
            this.pnlSummaryBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSummaryBorder.Location = new System.Drawing.Point(30, 76);
            this.pnlSummaryBorder.Name = "pnlSummaryBorder";
            this.pnlSummaryBorder.Padding = new System.Windows.Forms.Padding(1);
            this.pnlSummaryBorder.Size = new System.Drawing.Size(680, 56);
            this.pnlSummaryBorder.TabIndex = 1;

            // 
            // pnlSummaryCard
            // 
            this.pnlSummaryCard.BackColor = System.Drawing.Color.White;
            this.pnlSummaryCard.Controls.Add(this.lblSummaryInfo);
            this.pnlSummaryCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSummaryCard.Location = new System.Drawing.Point(1, 1);
            this.pnlSummaryCard.Name = "pnlSummaryCard";
            this.pnlSummaryCard.Size = new System.Drawing.Size(678, 54);
            this.pnlSummaryCard.TabIndex = 0;

            // 
            // lblSummaryInfo
            // 
            this.lblSummaryInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSummaryInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblSummaryInfo.ForeColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.lblSummaryInfo.Location = new System.Drawing.Point(0, 0);
            this.lblSummaryInfo.Name = "lblSummaryInfo";
            this.lblSummaryInfo.Padding = new System.Windows.Forms.Padding(18, 0, 18, 0);
            this.lblSummaryInfo.Size = new System.Drawing.Size(678, 54);
            this.lblSummaryInfo.TabIndex = 0;
            this.lblSummaryInfo.Text = "My Leave Summary  •  Total Requests: 0   |   Approved Days: 0   |   Under Review: 0";
            this.lblSummaryInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // pnlSpacer (Visual Gap Between Summary Card and Partitioned Table)
            // 
            this.pnlSpacer.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.pnlSpacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpacer.Location = new System.Drawing.Point(30, 132);
            this.pnlSpacer.Name = "pnlSpacer";
            this.pnlSpacer.Size = new System.Drawing.Size(680, 18);
            this.pnlSpacer.TabIndex = 2;

            // 
            // pnlTableBorder (1px Slate 200 Card Frame)
            // 
            this.pnlTableBorder.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.pnlTableBorder.Controls.Add(this.dgvRequests);
            this.pnlTableBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTableBorder.Location = new System.Drawing.Point(30, 150);
            this.pnlTableBorder.Name = "pnlTableBorder";
            this.pnlTableBorder.Padding = new System.Windows.Forms.Padding(1);
            this.pnlTableBorder.Size = new System.Drawing.Size(680, 440);
            this.pnlTableBorder.TabIndex = 3;

            // 
            // dgvRequests (Modern Partitioned Table)
            // 
            this.dgvRequests.AllowUserToAddRows = false;
            this.dgvRequests.AllowUserToDeleteRows = false;
            this.dgvRequests.AllowUserToResizeColumns = false;
            this.dgvRequests.AllowUserToResizeRows = false;
            this.dgvRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequests.BackgroundColor = System.Drawing.Color.White;
            this.dgvRequests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRequests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvRequests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;

            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            headerStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            headerStyle.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            headerStyle.SelectionBackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            headerStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            headerStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRequests.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvRequests.ColumnHeadersHeight = 42;
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            this.dgvRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colStatus,
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
            this.dgvRequests.DefaultCellStyle = rowStyle;

            altRowStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgvRequests.AlternatingRowsDefaultCellStyle = altRowStyle;

            this.dgvRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRequests.EnableHeadersVisualStyles = false;
            this.dgvRequests.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvRequests.Location = new System.Drawing.Point(1, 1);
            this.dgvRequests.MultiSelect = false;
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.ReadOnly = true;
            this.dgvRequests.RowHeadersVisible = false;
            this.dgvRequests.RowTemplate.Height = 46;
            this.dgvRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequests.Size = new System.Drawing.Size(678, 438);
            this.dgvRequests.TabIndex = 0;
            this.dgvRequests.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRequests_CellFormatting);

            // 
            // Columns
            // 
            this.colStatus.FillWeight = 24F;
            this.colStatus.HeaderText = "STATUS";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            this.colLeaveType.FillWeight = 26F;
            this.colLeaveType.HeaderText = "LEAVE TYPE";
            this.colLeaveType.Name = "colLeaveType";
            this.colLeaveType.ReadOnly = true;
            this.colLeaveType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            this.colDuration.FillWeight = 22F;
            this.colDuration.HeaderText = "DURATION";
            this.colDuration.Name = "colDuration";
            this.colDuration.ReadOnly = true;
            this.colDuration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            this.colDate.FillWeight = 28F;
            this.colDate.HeaderText = "SUBMITTED";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 620);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainDashboard_FormClosed);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlTableBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.pnlSummaryBorder.ResumeLayout(false);
            this.pnlSummaryCard.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}