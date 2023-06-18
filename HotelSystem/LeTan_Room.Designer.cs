
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
            this.LeTanKHListView = new System.Windows.Forms.ListView();
            this.LeTanRuleListView = new System.Windows.Forms.ListView();
            this.resultLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.addRoomBookingBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LeTanSearchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.LeTanSearchInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.LeTanRoomSearchingDropbox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.LeTanRoomBookingListView = new System.Windows.Forms.ListView();
            this.LeTanRoomListListView = new System.Windows.Forms.ListView();
            this.LeTanRoomRequestBtn = new Guna.UI2.WinForms.Guna2Button();
            this.LeTanRoomListView = new System.Windows.Forms.ListView();
            this.LeTanAddKhachDoanBtn = new Guna.UI2.WinForms.Guna2Button();
            this.LeTanRoomBooking = new HotelSystem.LeTan_Room_Booking();
            this.LeTan_Room_Searching = new HotelSystem.LeTan_Room_Searching();
            this.LeTan_Customer_Searching = new HotelSystem.LeTan_Customer_Searching();
            this.leTanRoomRequest = new HotelSystem.LeTan_Room_Request();
            this.LeTan_Room_KhachDoan = new HotelSystem.LeTan_Room_KhachDoan();
            this.SuspendLayout();
            // 
            // HomeLabel
            // 
            this.HomeLabel.AutoSize = false;
            this.HomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.HomeLabel.Font = new System.Drawing.Font("Google Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.HomeLabel.Location = new System.Drawing.Point(0, 34);
            this.HomeLabel.Margin = new System.Windows.Forms.Padding(4);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(1219, 58);
            this.HomeLabel.TabIndex = 0;
            this.HomeLabel.Text = "THÔNG TIN ĐẶT PHÒNG KHÁCH SẠN";
            this.HomeLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeTanKHListView
            // 
            this.LeTanKHListView.HideSelection = false;
            this.LeTanKHListView.Location = new System.Drawing.Point(127, 667);
            this.LeTanKHListView.Margin = new System.Windows.Forms.Padding(4);
            this.LeTanKHListView.Name = "LeTanKHListView";
            this.LeTanKHListView.Size = new System.Drawing.Size(953, 202);
            this.LeTanKHListView.TabIndex = 4;
            this.LeTanKHListView.UseCompatibleStateImageBehavior = false;
            this.LeTanKHListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // LeTanRuleListView
            // 
            this.LeTanRuleListView.HideSelection = false;
            this.LeTanRuleListView.Location = new System.Drawing.Point(127, 667);
            this.LeTanRuleListView.Margin = new System.Windows.Forms.Padding(4);
            this.LeTanRuleListView.Name = "LeTanRuleListView";
            this.LeTanRuleListView.Size = new System.Drawing.Size(953, 202);
            this.LeTanRuleListView.TabIndex = 6;
            this.LeTanRuleListView.UseCompatibleStateImageBehavior = false;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = false;
            this.resultLabel.BackColor = System.Drawing.Color.Transparent;
            this.resultLabel.Font = new System.Drawing.Font("Google Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.resultLabel.Location = new System.Drawing.Point(0, 602);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(4);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(1219, 58);
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
            this.addRoomBookingBtn.Location = new System.Drawing.Point(127, 449);
            this.addRoomBookingBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addRoomBookingBtn.Name = "addRoomBookingBtn";
            this.addRoomBookingBtn.Size = new System.Drawing.Size(240, 55);
            this.addRoomBookingBtn.TabIndex = 0;
            this.addRoomBookingBtn.Text = "Thêm thông tin đặt phòng";
            this.addRoomBookingBtn.Click += new System.EventHandler(this.addRoomBookingBtn_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(127, 137);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(173, 28);
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
            this.LeTanSearchBtn.Location = new System.Drawing.Point(127, 266);
            this.LeTanSearchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LeTanSearchBtn.Name = "LeTanSearchBtn";
            this.LeTanSearchBtn.Size = new System.Drawing.Size(240, 55);
            this.LeTanSearchBtn.TabIndex = 13;
            this.LeTanSearchBtn.Text = "Tra cứu";
            this.LeTanSearchBtn.Click += new System.EventHandler(this.LeTanSearchBtn_Click);
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
            this.LeTanSearchInput.Location = new System.Drawing.Point(407, 266);
            this.LeTanSearchInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LeTanSearchInput.Name = "LeTanSearchInput";
            this.LeTanSearchInput.PasswordChar = '\0';
            this.LeTanSearchInput.PlaceholderText = "";
            this.LeTanSearchInput.SelectedText = "";
            this.LeTanSearchInput.Size = new System.Drawing.Size(675, 55);
            this.LeTanSearchInput.TabIndex = 14;
            // 
            // LeTanRoomSearchingDropbox
            // 
            this.LeTanRoomSearchingDropbox.BackColor = System.Drawing.Color.Transparent;
            this.LeTanRoomSearchingDropbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.LeTanRoomSearchingDropbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LeTanRoomSearchingDropbox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LeTanRoomSearchingDropbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LeTanRoomSearchingDropbox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LeTanRoomSearchingDropbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.LeTanRoomSearchingDropbox.ItemHeight = 30;
            this.LeTanRoomSearchingDropbox.Items.AddRange(new object[] {
            "Tra cứu thông tin đặt phòng",
            "Tra cứu yêu cầu đặt phòng (mã)",
            "Tra cứu danh sách khách hàng",
            "Tra cứu quy định khách sạn",
            "Tra cứu danh sách đặt phòng (mã)",
            "Tra cứu danh sách phòng (mã/loại)"});
            this.LeTanRoomSearchingDropbox.Location = new System.Drawing.Point(127, 191);
            this.LeTanRoomSearchingDropbox.Margin = new System.Windows.Forms.Padding(4);
            this.LeTanRoomSearchingDropbox.Name = "LeTanRoomSearchingDropbox";
            this.LeTanRoomSearchingDropbox.Size = new System.Drawing.Size(409, 36);
            this.LeTanRoomSearchingDropbox.TabIndex = 15;
            this.LeTanRoomSearchingDropbox.SelectedIndexChanged += new System.EventHandler(this.LeTanRoomSearchingDropbox_SelectedIndexChanged);
            // 
            // LeTanRoomBookingListView
            // 
            this.LeTanRoomBookingListView.HideSelection = false;
            this.LeTanRoomBookingListView.Location = new System.Drawing.Point(127, 667);
            this.LeTanRoomBookingListView.Margin = new System.Windows.Forms.Padding(4);
            this.LeTanRoomBookingListView.Name = "LeTanRoomBookingListView";
            this.LeTanRoomBookingListView.Size = new System.Drawing.Size(953, 202);
            this.LeTanRoomBookingListView.TabIndex = 18;
            this.LeTanRoomBookingListView.UseCompatibleStateImageBehavior = false;
            // 
            // LeTanRoomListListView
            // 
            this.LeTanRoomListListView.HideSelection = false;
            this.LeTanRoomListListView.Location = new System.Drawing.Point(127, 667);
            this.LeTanRoomListListView.Margin = new System.Windows.Forms.Padding(4);
            this.LeTanRoomListListView.Name = "LeTanRoomListListView";
            this.LeTanRoomListListView.Size = new System.Drawing.Size(953, 202);
            this.LeTanRoomListListView.TabIndex = 19;
            this.LeTanRoomListListView.UseCompatibleStateImageBehavior = false;
            // 
            // LeTanRoomRequestBtn
            // 
            this.LeTanRoomRequestBtn.BorderRadius = 5;
            this.LeTanRoomRequestBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LeTanRoomRequestBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LeTanRoomRequestBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LeTanRoomRequestBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LeTanRoomRequestBtn.FillColor = System.Drawing.Color.DeepPink;
            this.LeTanRoomRequestBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LeTanRoomRequestBtn.ForeColor = System.Drawing.Color.White;
            this.LeTanRoomRequestBtn.Location = new System.Drawing.Point(477, 449);
            this.LeTanRoomRequestBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LeTanRoomRequestBtn.Name = "LeTanRoomRequestBtn";
            this.LeTanRoomRequestBtn.Size = new System.Drawing.Size(240, 55);
            this.LeTanRoomRequestBtn.TabIndex = 20;
            this.LeTanRoomRequestBtn.Text = "Thêm yêu cầu đặt phòng";
            this.LeTanRoomRequestBtn.Click += new System.EventHandler(this.LeTanRoomRequestBtn_Click);
            // 
            // LeTanRoomListView
            // 
            this.LeTanRoomListView.HideSelection = false;
            this.LeTanRoomListView.Location = new System.Drawing.Point(127, 667);
            this.LeTanRoomListView.Name = "LeTanRoomListView";
            this.LeTanRoomListView.Size = new System.Drawing.Size(953, 202);
            this.LeTanRoomListView.TabIndex = 22;
            this.LeTanRoomListView.UseCompatibleStateImageBehavior = false;
            // 
            // LeTanAddKhachDoanBtn
            // 
            this.LeTanAddKhachDoanBtn.BorderRadius = 5;
            this.LeTanAddKhachDoanBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LeTanAddKhachDoanBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LeTanAddKhachDoanBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LeTanAddKhachDoanBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LeTanAddKhachDoanBtn.FillColor = System.Drawing.Color.DeepPink;
            this.LeTanAddKhachDoanBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LeTanAddKhachDoanBtn.ForeColor = System.Drawing.Color.White;
            this.LeTanAddKhachDoanBtn.Location = new System.Drawing.Point(779, 449);
            this.LeTanAddKhachDoanBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LeTanAddKhachDoanBtn.Name = "LeTanAddKhachDoanBtn";
            this.LeTanAddKhachDoanBtn.Size = new System.Drawing.Size(240, 55);
            this.LeTanAddKhachDoanBtn.TabIndex = 23;
            this.LeTanAddKhachDoanBtn.Text = "Thêm thông tin khách đoàn";
            this.LeTanAddKhachDoanBtn.Click += new System.EventHandler(this.LeTanAddKhachDoanBtn_Click);
            // 
            // LeTanRoomBooking
            // 
            this.LeTanRoomBooking.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LeTanRoomBooking.Location = new System.Drawing.Point(0, 0);
            this.LeTanRoomBooking.Margin = new System.Windows.Forms.Padding(5);
            this.LeTanRoomBooking.Name = "LeTanRoomBooking";
            this.LeTanRoomBooking.Size = new System.Drawing.Size(1219, 923);
            this.LeTanRoomBooking.TabIndex = 11;
            // 
            // LeTan_Room_Searching
            // 
            this.LeTan_Room_Searching.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LeTan_Room_Searching.Location = new System.Drawing.Point(0, 0);
            this.LeTan_Room_Searching.Margin = new System.Windows.Forms.Padding(5);
            this.LeTan_Room_Searching.Name = "LeTan_Room_Searching";
            this.LeTan_Room_Searching.Size = new System.Drawing.Size(1217, 923);
            this.LeTan_Room_Searching.TabIndex = 16;
            // 
            // LeTan_Customer_Searching
            // 
            this.LeTan_Customer_Searching.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LeTan_Customer_Searching.Location = new System.Drawing.Point(0, 0);
            this.LeTan_Customer_Searching.Margin = new System.Windows.Forms.Padding(5);
            this.LeTan_Customer_Searching.Name = "LeTan_Customer_Searching";
            this.LeTan_Customer_Searching.Size = new System.Drawing.Size(1219, 923);
            this.LeTan_Customer_Searching.TabIndex = 17;
            // 
            // leTanRoomRequest
            // 
            this.leTanRoomRequest.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.leTanRoomRequest.Location = new System.Drawing.Point(0, 0);
            this.leTanRoomRequest.Margin = new System.Windows.Forms.Padding(5);
            this.leTanRoomRequest.Name = "leTanRoomRequest";
            this.leTanRoomRequest.Size = new System.Drawing.Size(1217, 923);
            this.leTanRoomRequest.TabIndex = 21;
            // 
            // LeTan_Room_KhachDoan
            // 
            this.LeTan_Room_KhachDoan.Location = new System.Drawing.Point(0, 0);
            this.LeTan_Room_KhachDoan.Name = "LeTan_Room_KhachDoan";
            this.LeTan_Room_KhachDoan.Size = new System.Drawing.Size(1219, 923);
            this.LeTan_Room_KhachDoan.TabIndex = 24;
            // 
            // LeTan_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.LeTanAddKhachDoanBtn);
            this.Controls.Add(this.LeTanRoomListView);
            this.Controls.Add(this.LeTanRoomRequestBtn);
            this.Controls.Add(this.LeTanRoomListListView);
            this.Controls.Add(this.LeTanRoomBookingListView);
            this.Controls.Add(this.LeTanRoomSearchingDropbox);
            this.Controls.Add(this.LeTanSearchInput);
            this.Controls.Add(this.LeTanSearchBtn);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.addRoomBookingBtn);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.LeTanRuleListView);
            this.Controls.Add(this.LeTanKHListView);
            this.Controls.Add(this.HomeLabel);
            this.Controls.Add(this.LeTanRoomBooking);
            this.Controls.Add(this.LeTan_Room_Searching);
            this.Controls.Add(this.LeTan_Customer_Searching);
            this.Controls.Add(this.leTanRoomRequest);
            this.Controls.Add(this.LeTan_Room_KhachDoan);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LeTan_Room";
            this.Size = new System.Drawing.Size(1219, 923);
            this.Load += new System.EventHandler(this.LeTan_Room_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel HomeLabel;
        private System.Windows.Forms.ListView LeTanKHListView;
        private System.Windows.Forms.ListView LeTanRuleListView;
        private Guna.UI2.WinForms.Guna2HtmlLabel resultLabel;
        private Guna.UI2.WinForms.Guna2Button addRoomBookingBtn;
        private LeTan_Room_Booking LeTanRoomBooking;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button LeTanSearchBtn;
        private Guna.UI2.WinForms.Guna2TextBox LeTanSearchInput;
        private Guna.UI2.WinForms.Guna2ComboBox LeTanRoomSearchingDropbox;
        private LeTan_Room_Searching LeTan_Room_Searching;
        private LeTan_Customer_Searching LeTan_Customer_Searching;
        private System.Windows.Forms.ListView LeTanRoomBookingListView;
        private System.Windows.Forms.ListView LeTanRoomListListView;
        private Guna.UI2.WinForms.Guna2Button LeTanRoomRequestBtn;
        private LeTan_Room_Request leTanRoomRequest;
        private System.Windows.Forms.ListView LeTanRoomListView;
        private Guna.UI2.WinForms.Guna2Button LeTanAddKhachDoanBtn;
        private LeTan_Room_KhachDoan LeTan_Room_KhachDoan;
    }
}
