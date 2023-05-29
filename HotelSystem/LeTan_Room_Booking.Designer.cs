
namespace HotelSystem
{
    partial class LeTan_Room_Booking
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
            this.quitBookingBtn = new Guna.UI2.WinForms.Guna2Button();
            this.roomBookingLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.customerId = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.specialRequest = new Guna.UI2.WinForms.Guna2TextBox();
            this.addRoomBookingBtn = new Guna.UI2.WinForms.Guna2Button();
            this.roomType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.checkoutDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.bookingDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.checkinDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.roomId = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // HomeLabel
            // 
            this.HomeLabel.AutoSize = false;
            this.HomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.HomeLabel.Font = new System.Drawing.Font("Google Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.HomeLabel.Location = new System.Drawing.Point(0, 34);
            this.HomeLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(1219, 58);
            this.HomeLabel.TabIndex = 0;
            this.HomeLabel.Text = "THÊM THÔNG TIN ĐẶT PHÒNG";
            this.HomeLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quitBookingBtn
            // 
            this.quitBookingBtn.BorderRadius = 4;
            this.quitBookingBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.quitBookingBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.quitBookingBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.quitBookingBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.quitBookingBtn.FillColor = System.Drawing.Color.DeepPink;
            this.quitBookingBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quitBookingBtn.ForeColor = System.Drawing.Color.White;
            this.quitBookingBtn.Location = new System.Drawing.Point(991, 111);
            this.quitBookingBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quitBookingBtn.Name = "quitBookingBtn";
            this.quitBookingBtn.Size = new System.Drawing.Size(143, 55);
            this.quitBookingBtn.TabIndex = 1;
            this.quitBookingBtn.Text = "Thoát";
            this.quitBookingBtn.Click += new System.EventHandler(this.quitBookingBtn_Click);
            // 
            // roomBookingLabel
            // 
            this.roomBookingLabel.BackColor = System.Drawing.Color.Transparent;
            this.roomBookingLabel.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomBookingLabel.Location = new System.Drawing.Point(55, 212);
            this.roomBookingLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roomBookingLabel.Name = "roomBookingLabel";
            this.roomBookingLabel.Size = new System.Drawing.Size(146, 28);
            this.roomBookingLabel.TabIndex = 2;
            this.roomBookingLabel.Text = "Mã khách hàng";
            // 
            // customerId
            // 
            this.customerId.BorderRadius = 4;
            this.customerId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerId.DefaultText = "";
            this.customerId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerId.Font = new System.Drawing.Font("Google Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerId.Location = new System.Drawing.Point(55, 247);
            this.customerId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customerId.Name = "customerId";
            this.customerId.PasswordChar = '\0';
            this.customerId.PlaceholderText = "";
            this.customerId.SelectedText = "";
            this.customerId.Size = new System.Drawing.Size(255, 44);
            this.customerId.TabIndex = 3;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(879, 370);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(237, 28);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "Ngày đặt (yyyy-mm-dd)";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(480, 212);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(108, 28);
            this.guna2HtmlLabel2.TabIndex = 6;
            this.guna2HtmlLabel2.Text = "Loại phòng";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(55, 370);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(228, 28);
            this.guna2HtmlLabel3.TabIndex = 8;
            this.guna2HtmlLabel3.Text = "Checkin (yyyy-mm-dd)";
            this.guna2HtmlLabel3.Click += new System.EventHandler(this.guna2HtmlLabel3_Click);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(480, 370);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(243, 28);
            this.guna2HtmlLabel4.TabIndex = 10;
            this.guna2HtmlLabel4.Text = "Checkout (yyyy-mm-dd)";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(55, 511);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(162, 28);
            this.guna2HtmlLabel5.TabIndex = 12;
            this.guna2HtmlLabel5.Text = "Yêu cầu đặc biệt";
            // 
            // specialRequest
            // 
            this.specialRequest.BorderRadius = 4;
            this.specialRequest.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.specialRequest.DefaultText = "";
            this.specialRequest.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.specialRequest.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.specialRequest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.specialRequest.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.specialRequest.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.specialRequest.Font = new System.Drawing.Font("Google Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialRequest.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.specialRequest.Location = new System.Drawing.Point(55, 546);
            this.specialRequest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.specialRequest.Name = "specialRequest";
            this.specialRequest.PasswordChar = '\0';
            this.specialRequest.PlaceholderText = "";
            this.specialRequest.SelectedText = "";
            this.specialRequest.Size = new System.Drawing.Size(1079, 44);
            this.specialRequest.TabIndex = 13;
            // 
            // addRoomBookingBtn
            // 
            this.addRoomBookingBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addRoomBookingBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addRoomBookingBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addRoomBookingBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addRoomBookingBtn.FillColor = System.Drawing.Color.DeepPink;
            this.addRoomBookingBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addRoomBookingBtn.ForeColor = System.Drawing.Color.White;
            this.addRoomBookingBtn.Location = new System.Drawing.Point(991, 783);
            this.addRoomBookingBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addRoomBookingBtn.Name = "addRoomBookingBtn";
            this.addRoomBookingBtn.Size = new System.Drawing.Size(143, 55);
            this.addRoomBookingBtn.TabIndex = 14;
            this.addRoomBookingBtn.Text = "Thêm";
            this.addRoomBookingBtn.Click += new System.EventHandler(this.addRoomBookingBtn_Click);
            // 
            // roomType
            // 
            this.roomType.BackColor = System.Drawing.Color.Transparent;
            this.roomType.BorderRadius = 4;
            this.roomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomType.Font = new System.Drawing.Font("Google Sans", 10.8F);
            this.roomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.roomType.ItemHeight = 30;
            this.roomType.Items.AddRange(new object[] {
            "Thường",
            "Vip"});
            this.roomType.Location = new System.Drawing.Point(480, 247);
            this.roomType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roomType.Name = "roomType";
            this.roomType.Size = new System.Drawing.Size(253, 36);
            this.roomType.TabIndex = 15;
            this.roomType.SelectedIndexChanged += new System.EventHandler(this.roomType_SelectedIndexChanged);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(882, 212);
            this.guna2HtmlLabel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(98, 28);
            this.guna2HtmlLabel6.TabIndex = 16;
            this.guna2HtmlLabel6.Text = "Mã phòng";
            this.guna2HtmlLabel6.Click += new System.EventHandler(this.guna2HtmlLabel6_Click);
            // 
            // checkoutDate
            // 
            this.checkoutDate.BorderRadius = 4;
            this.checkoutDate.Checked = true;
            this.checkoutDate.CustomFormat = "yyyy-MM-dd";
            this.checkoutDate.FillColor = System.Drawing.Color.White;
            this.checkoutDate.Font = new System.Drawing.Font("Google Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.checkoutDate.Location = new System.Drawing.Point(480, 405);
            this.checkoutDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.checkoutDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.checkoutDate.Name = "checkoutDate";
            this.checkoutDate.Size = new System.Drawing.Size(250, 45);
            this.checkoutDate.TabIndex = 19;
            this.checkoutDate.Value = new System.DateTime(2023, 5, 28, 0, 23, 11, 398);
            // 
            // bookingDate
            // 
            this.bookingDate.BorderRadius = 4;
            this.bookingDate.Checked = true;
            this.bookingDate.CustomFormat = "yyyy-MM-dd";
            this.bookingDate.Enabled = false;
            this.bookingDate.FillColor = System.Drawing.Color.White;
            this.bookingDate.Font = new System.Drawing.Font("Google Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bookingDate.Location = new System.Drawing.Point(882, 405);
            this.bookingDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.bookingDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.bookingDate.Name = "bookingDate";
            this.bookingDate.Size = new System.Drawing.Size(250, 45);
            this.bookingDate.TabIndex = 20;
            this.bookingDate.Value = new System.DateTime(2023, 5, 28, 0, 23, 11, 398);
            // 
            // checkinDate
            // 
            this.checkinDate.BorderRadius = 4;
            this.checkinDate.Checked = true;
            this.checkinDate.CustomFormat = "yyyy-MM-dd";
            this.checkinDate.FillColor = System.Drawing.Color.White;
            this.checkinDate.Font = new System.Drawing.Font("Google Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.checkinDate.Location = new System.Drawing.Point(55, 405);
            this.checkinDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.checkinDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.checkinDate.Name = "checkinDate";
            this.checkinDate.Size = new System.Drawing.Size(255, 45);
            this.checkinDate.TabIndex = 21;
            this.checkinDate.Value = new System.DateTime(2023, 5, 28, 0, 23, 11, 398);
            // 
            // roomId
            // 
            this.roomId.BackColor = System.Drawing.Color.Transparent;
            this.roomId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roomId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomId.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomId.Font = new System.Drawing.Font("Google Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.roomId.ItemHeight = 30;
            this.roomId.Location = new System.Drawing.Point(882, 247);
            this.roomId.Name = "roomId";
            this.roomId.Size = new System.Drawing.Size(255, 36);
            this.roomId.TabIndex = 22;
            this.roomId.SelectedIndexChanged += new System.EventHandler(this.roomId_SelectedIndexChanged);
            // 
            // LeTan_Room_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.roomId);
            this.Controls.Add(this.checkinDate);
            this.Controls.Add(this.bookingDate);
            this.Controls.Add(this.checkoutDate);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.roomType);
            this.Controls.Add(this.addRoomBookingBtn);
            this.Controls.Add(this.specialRequest);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.customerId);
            this.Controls.Add(this.roomBookingLabel);
            this.Controls.Add(this.quitBookingBtn);
            this.Controls.Add(this.HomeLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LeTan_Room_Booking";
            this.Size = new System.Drawing.Size(1219, 923);
            this.Load += new System.EventHandler(this.LeTan_Room_Booking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel HomeLabel;
        private Guna.UI2.WinForms.Guna2Button quitBookingBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel roomBookingLabel;
        private Guna.UI2.WinForms.Guna2TextBox customerId;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox specialRequest;
        private Guna.UI2.WinForms.Guna2Button addRoomBookingBtn;
        private Guna.UI2.WinForms.Guna2ComboBox roomType;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2DateTimePicker checkoutDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker bookingDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker checkinDate;
        private Guna.UI2.WinForms.Guna2ComboBox roomId;
    }
}
