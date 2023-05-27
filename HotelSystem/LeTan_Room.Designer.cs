
namespace HotelSystem
{
    partial class LeTan_Room
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HomeLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.viewRoomBtn = new Guna.UI2.WinForms.Guna2Button();
            this.LeTanRoomListView = new System.Windows.Forms.ListView();
            this.MAPHONG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NGAYTHUE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NGAYTRA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TINHTRANG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LOAI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LeTanKHListView = new System.Windows.Forms.ListView();
            this.viewKhachHangBtn = new Guna.UI2.WinForms.Guna2Button();
            this.viewRuleBtn = new Guna.UI2.WinForms.Guna2Button();
            this.LeTanRuleListView = new System.Windows.Forms.ListView();
            this.resultLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LeTanSearch = new Guna.UI2.WinForms.Guna2GroupBox();
            this.LeTanSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeLabel
            // 
            this.HomeLabel.AutoSize = false;
            this.HomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.HomeLabel.Font = new System.Drawing.Font("Google Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.HomeLabel.Location = new System.Drawing.Point(0, 28);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(914, 47);
            this.HomeLabel.TabIndex = 0;
            this.HomeLabel.Text = "THÔNG TIN ĐẶT PHÒNG KHÁCH SẠN";
            this.HomeLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewRoomBtn
            // 
            this.viewRoomBtn.BorderRadius = 5;
            this.viewRoomBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewRoomBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewRoomBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewRoomBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewRoomBtn.FillColor = System.Drawing.Color.DeepPink;
            this.viewRoomBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.viewRoomBtn.ForeColor = System.Drawing.Color.White;
            this.viewRoomBtn.Location = new System.Drawing.Point(18, 63);
            this.viewRoomBtn.Name = "viewRoomBtn";
            this.viewRoomBtn.Size = new System.Drawing.Size(180, 45);
            this.viewRoomBtn.TabIndex = 1;
            this.viewRoomBtn.Text = "Xem danh sách phòng";
            this.viewRoomBtn.Click += new System.EventHandler(this.viewRoomBtn_Click);
            // 
            // LeTanRoomListView
            // 
            this.LeTanRoomListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LeTanRoomListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MAPHONG,
            this.NGAYTHUE,
            this.NGAYTRA,
            this.TINHTRANG,
            this.LOAI});
            this.LeTanRoomListView.HideSelection = false;
            this.LeTanRoomListView.Location = new System.Drawing.Point(95, 546);
            this.LeTanRoomListView.Name = "LeTanRoomListView";
            this.LeTanRoomListView.Size = new System.Drawing.Size(716, 165);
            this.LeTanRoomListView.TabIndex = 2;
            this.LeTanRoomListView.UseCompatibleStateImageBehavior = false;
            this.LeTanRoomListView.SelectedIndexChanged += new System.EventHandler(this.LeTanRoomListView_SelectedIndexChanged);
            // 
            // MAPHONG
            // 
            this.MAPHONG.Text = "Mã phòng";
            this.MAPHONG.Width = 100;
            // 
            // NGAYTHUE
            // 
            this.NGAYTHUE.Text = "Ngày thuê";
            this.NGAYTHUE.Width = 100;
            // 
            // NGAYTRA
            // 
            this.NGAYTRA.Text = "Ngày trả";
            this.NGAYTRA.Width = 100;
            // 
            // TINHTRANG
            // 
            this.TINHTRANG.Text = "Tình trạng";
            this.TINHTRANG.Width = 100;
            // 
            // LOAI
            // 
            this.LOAI.Text = "Loại";
            this.LOAI.Width = 100;
            // 
            // LeTanKHListView
            // 
            this.LeTanKHListView.HideSelection = false;
            this.LeTanKHListView.Location = new System.Drawing.Point(95, 546);
            this.LeTanKHListView.Name = "LeTanKHListView";
            this.LeTanKHListView.Size = new System.Drawing.Size(716, 165);
            this.LeTanKHListView.TabIndex = 4;
            this.LeTanKHListView.UseCompatibleStateImageBehavior = false;
            this.LeTanKHListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // viewKhachHangBtn
            // 
            this.viewKhachHangBtn.BorderRadius = 5;
            this.viewKhachHangBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewKhachHangBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewKhachHangBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewKhachHangBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewKhachHangBtn.FillColor = System.Drawing.Color.DeepPink;
            this.viewKhachHangBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.viewKhachHangBtn.ForeColor = System.Drawing.Color.White;
            this.viewKhachHangBtn.Location = new System.Drawing.Point(270, 63);
            this.viewKhachHangBtn.Name = "viewKhachHangBtn";
            this.viewKhachHangBtn.Size = new System.Drawing.Size(180, 45);
            this.viewKhachHangBtn.TabIndex = 3;
            this.viewKhachHangBtn.Text = "Xem danh sách khách hàng";
            this.viewKhachHangBtn.Click += new System.EventHandler(this.viewKhachHangBtn_Click);
            // 
            // viewRuleBtn
            // 
            this.viewRuleBtn.BorderRadius = 5;
            this.viewRuleBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewRuleBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewRuleBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewRuleBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewRuleBtn.FillColor = System.Drawing.Color.DeepPink;
            this.viewRuleBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.viewRuleBtn.ForeColor = System.Drawing.Color.White;
            this.viewRuleBtn.Location = new System.Drawing.Point(515, 63);
            this.viewRuleBtn.Name = "viewRuleBtn";
            this.viewRuleBtn.Size = new System.Drawing.Size(180, 45);
            this.viewRuleBtn.TabIndex = 5;
            this.viewRuleBtn.Text = "Xem quy định";
            this.viewRuleBtn.Click += new System.EventHandler(this.viewRuleBtn_Click);
            // 
            // LeTanRuleListView
            // 
            this.LeTanRuleListView.HideSelection = false;
            this.LeTanRuleListView.Location = new System.Drawing.Point(95, 546);
            this.LeTanRuleListView.Name = "LeTanRuleListView";
            this.LeTanRuleListView.Size = new System.Drawing.Size(716, 165);
            this.LeTanRuleListView.TabIndex = 6;
            this.LeTanRuleListView.UseCompatibleStateImageBehavior = false;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = false;
            this.resultLabel.BackColor = System.Drawing.Color.Transparent;
            this.resultLabel.Font = new System.Drawing.Font("Google Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.resultLabel.Location = new System.Drawing.Point(0, 500);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(914, 47);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "KẾT QUẢ TRA CỨU";
            this.resultLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeTanSearch
            // 
            this.LeTanSearch.Controls.Add(this.viewRuleBtn);
            this.LeTanSearch.Controls.Add(this.viewKhachHangBtn);
            this.LeTanSearch.Controls.Add(this.viewRoomBtn);
            this.LeTanSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LeTanSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.LeTanSearch.Location = new System.Drawing.Point(95, 83);
            this.LeTanSearch.Name = "LeTanSearch";
            this.LeTanSearch.Size = new System.Drawing.Size(716, 136);
            this.LeTanSearch.TabIndex = 8;
            this.LeTanSearch.Text = "Tra cứu thông tin";
            // 
            // LeTan_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.LeTanSearch);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.LeTanRuleListView);
            this.Controls.Add(this.LeTanKHListView);
            this.Controls.Add(this.LeTanRoomListView);
            this.Controls.Add(this.HomeLabel);
            this.Name = "LeTan_Room";
            this.Size = new System.Drawing.Size(914, 750);
            this.Load += new System.EventHandler(this.LeTan_Room_Load);
            this.LeTanSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel HomeLabel;
        private Guna.UI2.WinForms.Guna2Button viewRoomBtn;
        private System.Windows.Forms.ListView LeTanRoomListView;
        private System.Windows.Forms.ColumnHeader MAPHONG;
        private System.Windows.Forms.ColumnHeader NGAYTHUE;
        private System.Windows.Forms.ColumnHeader NGAYTRA;
        private System.Windows.Forms.ColumnHeader TINHTRANG;
        private System.Windows.Forms.ColumnHeader LOAI;
        private System.Windows.Forms.ListView LeTanKHListView;
        private Guna.UI2.WinForms.Guna2Button viewKhachHangBtn;
        private Guna.UI2.WinForms.Guna2Button viewRuleBtn;
        private System.Windows.Forms.ListView LeTanRuleListView;
        private Guna.UI2.WinForms.Guna2HtmlLabel resultLabel;
        private Guna.UI2.WinForms.Guna2GroupBox LeTanSearch;
    }
}
