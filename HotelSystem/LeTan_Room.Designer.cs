﻿
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
            this.LeTanRoomListView = new System.Windows.Forms.ListView();
            this.MAPHONG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NGAYTHUE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NGAYTRA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TINHTRANG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LOAI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LeTanKHListView = new System.Windows.Forms.ListView();
            this.LeTanRuleListView = new System.Windows.Forms.ListView();
            this.resultLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.addRoomBookingBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LeTanSearchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.LeTanSearchInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.LeTanRoomBooking = new HotelSystem.LeTan_Room_Booking();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
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
            // addRoomBookingBtn
            // 
            this.addRoomBookingBtn.BorderRadius = 5;
            this.addRoomBookingBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addRoomBookingBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addRoomBookingBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addRoomBookingBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addRoomBookingBtn.FillColor = System.Drawing.Color.DeepPink;
            this.addRoomBookingBtn.Font = new System.Drawing.Font("Google Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRoomBookingBtn.ForeColor = System.Drawing.Color.White;
            this.addRoomBookingBtn.Location = new System.Drawing.Point(95, 365);
            this.addRoomBookingBtn.Name = "addRoomBookingBtn";
            this.addRoomBookingBtn.Size = new System.Drawing.Size(180, 45);
            this.addRoomBookingBtn.TabIndex = 0;
            this.addRoomBookingBtn.Text = "Thêm thông tin đặt phòng";
            this.addRoomBookingBtn.Click += new System.EventHandler(this.addRoomBookingBtn_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(95, 111);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(142, 23);
            this.guna2HtmlLabel1.TabIndex = 12;
            this.guna2HtmlLabel1.Text = "Tra cứu thông tin:";
            // 
            // LeTanSearchBtn
            // 
            this.LeTanSearchBtn.BorderRadius = 5;
            this.LeTanSearchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LeTanSearchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LeTanSearchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LeTanSearchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LeTanSearchBtn.FillColor = System.Drawing.Color.DeepPink;
            this.LeTanSearchBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LeTanSearchBtn.ForeColor = System.Drawing.Color.White;
            this.LeTanSearchBtn.Location = new System.Drawing.Point(95, 216);
            this.LeTanSearchBtn.Name = "LeTanSearchBtn";
            this.LeTanSearchBtn.Size = new System.Drawing.Size(180, 45);
            this.LeTanSearchBtn.TabIndex = 13;
            this.LeTanSearchBtn.Text = "Tra cứu";
            // 
            // LeTanSearchInput
            // 
            this.LeTanSearchInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LeTanSearchInput.DefaultText = "";
            this.LeTanSearchInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LeTanSearchInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LeTanSearchInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LeTanSearchInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LeTanSearchInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LeTanSearchInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LeTanSearchInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LeTanSearchInput.Location = new System.Drawing.Point(305, 216);
            this.LeTanSearchInput.Name = "LeTanSearchInput";
            this.LeTanSearchInput.PasswordChar = '\0';
            this.LeTanSearchInput.PlaceholderText = "";
            this.LeTanSearchInput.SelectedText = "";
            this.LeTanSearchInput.Size = new System.Drawing.Size(506, 45);
            this.LeTanSearchInput.TabIndex = 14;
            // 
            // LeTanRoomBooking
            // 
            this.LeTanRoomBooking.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LeTanRoomBooking.Location = new System.Drawing.Point(0, 0);
            this.LeTanRoomBooking.Margin = new System.Windows.Forms.Padding(4);
            this.LeTanRoomBooking.Name = "LeTanRoomBooking";
            this.LeTanRoomBooking.Size = new System.Drawing.Size(914, 750);
            this.LeTanRoomBooking.TabIndex = 11;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(95, 155);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(308, 36);
            this.guna2ComboBox1.TabIndex = 15;
            // 
            // LeTan_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.LeTanSearchInput);
            this.Controls.Add(this.LeTanSearchBtn);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.addRoomBookingBtn);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.LeTanRuleListView);
            this.Controls.Add(this.LeTanKHListView);
            this.Controls.Add(this.LeTanRoomListView);
            this.Controls.Add(this.HomeLabel);
            this.Controls.Add(this.LeTanRoomBooking);
            this.Name = "LeTan_Room";
            this.Size = new System.Drawing.Size(914, 750);
            this.Load += new System.EventHandler(this.LeTan_Room_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel HomeLabel;
        private System.Windows.Forms.ListView LeTanRoomListView;
        private System.Windows.Forms.ColumnHeader MAPHONG;
        private System.Windows.Forms.ColumnHeader NGAYTHUE;
        private System.Windows.Forms.ColumnHeader NGAYTRA;
        private System.Windows.Forms.ColumnHeader TINHTRANG;
        private System.Windows.Forms.ColumnHeader LOAI;
        private System.Windows.Forms.ListView LeTanKHListView;
        private System.Windows.Forms.ListView LeTanRuleListView;
        private Guna.UI2.WinForms.Guna2HtmlLabel resultLabel;
        private Guna.UI2.WinForms.Guna2Button addRoomBookingBtn;
        private LeTan_Room_Booking LeTanRoomBooking;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button LeTanSearchBtn;
        private Guna.UI2.WinForms.Guna2TextBox LeTanSearchInput;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
    }
}
