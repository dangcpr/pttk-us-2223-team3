
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.listView1 = new System.Windows.Forms.ListView();
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
            this.viewRoomBtn.Location = new System.Drawing.Point(95, 109);
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
            this.LeTanRoomListView.Location = new System.Drawing.Point(95, 496);
            this.LeTanRoomListView.Name = "LeTanRoomListView";
            this.LeTanRoomListView.Size = new System.Drawing.Size(734, 215);
            this.LeTanRoomListView.TabIndex = 2;
            this.LeTanRoomListView.UseCompatibleStateImageBehavior = false;
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
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.DeepPink;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(344, 109);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "Xem danh sách khách hàng";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(95, 496);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(734, 215);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // LeTan_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.LeTanRoomListView);
            this.Controls.Add(this.viewRoomBtn);
            this.Controls.Add(this.HomeLabel);
            this.Name = "LeTan_Room";
            this.Size = new System.Drawing.Size(914, 750);
            this.Load += new System.EventHandler(this.LeTan_Room_Load);
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
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.ListView listView1;
    }
}
