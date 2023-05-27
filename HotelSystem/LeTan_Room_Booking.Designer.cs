
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
            this.bookingDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.checkinDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.checkoutDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.specialRequest = new Guna.UI2.WinForms.Guna2TextBox();
            this.addRoomBookingBtn = new Guna.UI2.WinForms.Guna2Button();
            this.roomType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.roomId = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.HomeLabel.Text = "THÊM THÔNG TIN ĐẶT PHÒNG";
            this.HomeLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quitBookingBtn
            // 
            this.quitBookingBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.quitBookingBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.quitBookingBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.quitBookingBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.quitBookingBtn.FillColor = System.Drawing.Color.DeepPink;
            this.quitBookingBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quitBookingBtn.ForeColor = System.Drawing.Color.White;
            this.quitBookingBtn.Location = new System.Drawing.Point(743, 90);
            this.quitBookingBtn.Name = "quitBookingBtn";
            this.quitBookingBtn.Size = new System.Drawing.Size(107, 45);
            this.quitBookingBtn.TabIndex = 1;
            this.quitBookingBtn.Text = "Thoát";
            this.quitBookingBtn.Click += new System.EventHandler(this.quitBookingBtn_Click);
            // 
            // roomBookingLabel
            // 
            this.roomBookingLabel.BackColor = System.Drawing.Color.Transparent;
            this.roomBookingLabel.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomBookingLabel.Location = new System.Drawing.Point(41, 172);
            this.roomBookingLabel.Name = "roomBookingLabel";
            this.roomBookingLabel.Size = new System.Drawing.Size(120, 23);
            this.roomBookingLabel.TabIndex = 2;
            this.roomBookingLabel.Text = "Mã khách hàng";
            // 
            // customerId
            // 
            this.customerId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerId.DefaultText = "";
            this.customerId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.customerId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerId.Location = new System.Drawing.Point(41, 201);
            this.customerId.Name = "customerId";
            this.customerId.PasswordChar = '\0';
            this.customerId.PlaceholderText = "";
            this.customerId.SelectedText = "";
            this.customerId.Size = new System.Drawing.Size(191, 36);
            this.customerId.TabIndex = 3;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(659, 301);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(189, 23);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "Ngày đặt (yyyy-mm-dd)";
            // 
            // bookingDate
            // 
            this.bookingDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bookingDate.DefaultText = "";
            this.bookingDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bookingDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bookingDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookingDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookingDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bookingDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bookingDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bookingDate.Location = new System.Drawing.Point(659, 330);
            this.bookingDate.Name = "bookingDate";
            this.bookingDate.PasswordChar = '\0';
            this.bookingDate.PlaceholderText = "";
            this.bookingDate.SelectedText = "";
            this.bookingDate.Size = new System.Drawing.Size(191, 36);
            this.bookingDate.TabIndex = 5;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(659, 172);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(89, 23);
            this.guna2HtmlLabel2.TabIndex = 6;
            this.guna2HtmlLabel2.Text = "Loại phòng";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(41, 301);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(173, 23);
            this.guna2HtmlLabel3.TabIndex = 8;
            this.guna2HtmlLabel3.Text = "Checkin (yyy-mm-dd)";
            this.guna2HtmlLabel3.Click += new System.EventHandler(this.guna2HtmlLabel3_Click);
            // 
            // checkinDate
            // 
            this.checkinDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.checkinDate.DefaultText = "";
            this.checkinDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.checkinDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.checkinDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.checkinDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.checkinDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkinDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkinDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkinDate.Location = new System.Drawing.Point(41, 330);
            this.checkinDate.Name = "checkinDate";
            this.checkinDate.PasswordChar = '\0';
            this.checkinDate.PlaceholderText = "";
            this.checkinDate.SelectedText = "";
            this.checkinDate.Size = new System.Drawing.Size(191, 36);
            this.checkinDate.TabIndex = 9;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(360, 301);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(195, 23);
            this.guna2HtmlLabel4.TabIndex = 10;
            this.guna2HtmlLabel4.Text = "Checkout (yyyy-mm-dd)";
            // 
            // checkoutDate
            // 
            this.checkoutDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.checkoutDate.DefaultText = "";
            this.checkoutDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.checkoutDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.checkoutDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.checkoutDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.checkoutDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkoutDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkoutDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkoutDate.Location = new System.Drawing.Point(360, 330);
            this.checkoutDate.Name = "checkoutDate";
            this.checkoutDate.PasswordChar = '\0';
            this.checkoutDate.PlaceholderText = "";
            this.checkoutDate.SelectedText = "";
            this.checkoutDate.Size = new System.Drawing.Size(191, 36);
            this.checkoutDate.TabIndex = 11;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(41, 415);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(128, 23);
            this.guna2HtmlLabel5.TabIndex = 12;
            this.guna2HtmlLabel5.Text = "Yêu cầu đặt biệt";
            // 
            // specialRequest
            // 
            this.specialRequest.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.specialRequest.DefaultText = "";
            this.specialRequest.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.specialRequest.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.specialRequest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.specialRequest.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.specialRequest.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.specialRequest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.specialRequest.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.specialRequest.Location = new System.Drawing.Point(41, 444);
            this.specialRequest.Name = "specialRequest";
            this.specialRequest.PasswordChar = '\0';
            this.specialRequest.PlaceholderText = "";
            this.specialRequest.SelectedText = "";
            this.specialRequest.Size = new System.Drawing.Size(809, 36);
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
            this.addRoomBookingBtn.Location = new System.Drawing.Point(743, 636);
            this.addRoomBookingBtn.Name = "addRoomBookingBtn";
            this.addRoomBookingBtn.Size = new System.Drawing.Size(107, 45);
            this.addRoomBookingBtn.TabIndex = 14;
            this.addRoomBookingBtn.Text = "Thêm";
            this.addRoomBookingBtn.Click += new System.EventHandler(this.addRoomBookingBtn_Click);
            // 
            // roomType
            // 
            this.roomType.BackColor = System.Drawing.Color.Transparent;
            this.roomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.roomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.roomType.ItemHeight = 30;
            this.roomType.Items.AddRange(new object[] {
            "Thường",
            "Vip"});
            this.roomType.Location = new System.Drawing.Point(659, 201);
            this.roomType.Name = "roomType";
            this.roomType.Size = new System.Drawing.Size(191, 36);
            this.roomType.TabIndex = 15;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(356, 172);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(80, 23);
            this.guna2HtmlLabel6.TabIndex = 16;
            this.guna2HtmlLabel6.Text = "Mã phòng";
            this.guna2HtmlLabel6.Click += new System.EventHandler(this.guna2HtmlLabel6_Click);
            // 
            // roomId
            // 
            this.roomId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roomId.DefaultText = "";
            this.roomId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.roomId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.roomId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roomId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roomId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.roomId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomId.Location = new System.Drawing.Point(356, 201);
            this.roomId.Name = "roomId";
            this.roomId.PasswordChar = '\0';
            this.roomId.PlaceholderText = "";
            this.roomId.SelectedText = "";
            this.roomId.Size = new System.Drawing.Size(191, 36);
            this.roomId.TabIndex = 17;
            // 
            // LeTan_Room_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.roomId);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.roomType);
            this.Controls.Add(this.addRoomBookingBtn);
            this.Controls.Add(this.specialRequest);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.checkoutDate);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.checkinDate);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.bookingDate);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.customerId);
            this.Controls.Add(this.roomBookingLabel);
            this.Controls.Add(this.quitBookingBtn);
            this.Controls.Add(this.HomeLabel);
            this.Name = "LeTan_Room_Booking";
            this.Size = new System.Drawing.Size(914, 750);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel HomeLabel;
        private Guna.UI2.WinForms.Guna2Button quitBookingBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel roomBookingLabel;
        private Guna.UI2.WinForms.Guna2TextBox customerId;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox bookingDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox checkinDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox checkoutDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox specialRequest;
        private Guna.UI2.WinForms.Guna2Button addRoomBookingBtn;
        private Guna.UI2.WinForms.Guna2ComboBox roomType;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox roomId;
    }
}
