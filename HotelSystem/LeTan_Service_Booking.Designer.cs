
namespace HotelSystem
{
    partial class LeTan_Service_Booking
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
            this.tb_MKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_MKH = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbLoaiDV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lb_LoaiDV = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DK_Date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbNgay = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbSoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbSoLuong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbThanhToan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbThanhToan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.bntAddDV = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // HomeLabel
            // 
            this.HomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.HomeLabel.Font = new System.Drawing.Font("Google Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.HomeLabel.Location = new System.Drawing.Point(291, 41);
            this.HomeLabel.Margin = new System.Windows.Forms.Padding(4);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(605, 59);
            this.HomeLabel.TabIndex = 2;
            this.HomeLabel.Text = "ĐĂNG KÝ SỬ DỤNG DỊCH VỤ";
            this.HomeLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_MKH
            // 
            this.tb_MKH.BorderRadius = 4;
            this.tb_MKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_MKH.DefaultText = "";
            this.tb_MKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_MKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_MKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_MKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_MKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_MKH.Font = new System.Drawing.Font("Google Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_MKH.Location = new System.Drawing.Point(59, 189);
            this.tb_MKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_MKH.Name = "tb_MKH";
            this.tb_MKH.PasswordChar = '\0';
            this.tb_MKH.PlaceholderText = "";
            this.tb_MKH.SelectedText = "";
            this.tb_MKH.Size = new System.Drawing.Size(255, 44);
            this.tb_MKH.TabIndex = 7;
            // 
            // lb_MKH
            // 
            this.lb_MKH.BackColor = System.Drawing.Color.Transparent;
            this.lb_MKH.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MKH.Location = new System.Drawing.Point(59, 154);
            this.lb_MKH.Margin = new System.Windows.Forms.Padding(4);
            this.lb_MKH.Name = "lb_MKH";
            this.lb_MKH.Size = new System.Drawing.Size(146, 28);
            this.lb_MKH.TabIndex = 6;
            this.lb_MKH.Text = "Mã khách hàng";
            // 
            // cbLoaiDV
            // 
            this.cbLoaiDV.BackColor = System.Drawing.Color.Transparent;
            this.cbLoaiDV.BorderRadius = 4;
            this.cbLoaiDV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoaiDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiDV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoaiDV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoaiDV.Font = new System.Drawing.Font("Google Sans", 10.8F);
            this.cbLoaiDV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLoaiDV.ItemHeight = 30;
            this.cbLoaiDV.Items.AddRange(new object[] {
            "Ăn uống",
            "Spa",
            "Bi-a",
            "Karaoke"});
            this.cbLoaiDV.Location = new System.Drawing.Point(506, 197);
            this.cbLoaiDV.Margin = new System.Windows.Forms.Padding(4);
            this.cbLoaiDV.Name = "cbLoaiDV";
            this.cbLoaiDV.Size = new System.Drawing.Size(253, 36);
            this.cbLoaiDV.TabIndex = 17;
            this.cbLoaiDV.SelectedIndexChanged += new System.EventHandler(this.cbLoaiDV_SelectedIndexChanged);
            // 
            // lb_LoaiDV
            // 
            this.lb_LoaiDV.BackColor = System.Drawing.Color.Transparent;
            this.lb_LoaiDV.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LoaiDV.Location = new System.Drawing.Point(506, 162);
            this.lb_LoaiDV.Margin = new System.Windows.Forms.Padding(4);
            this.lb_LoaiDV.Name = "lb_LoaiDV";
            this.lb_LoaiDV.Size = new System.Drawing.Size(117, 28);
            this.lb_LoaiDV.TabIndex = 16;
            this.lb_LoaiDV.Text = "Loại dịch vụ";
            // 
            // DK_Date
            // 
            this.DK_Date.BorderRadius = 4;
            this.DK_Date.Checked = true;
            this.DK_Date.CustomFormat = "yyyy-MM-dd";
            this.DK_Date.FillColor = System.Drawing.Color.White;
            this.DK_Date.Font = new System.Drawing.Font("Google Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DK_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DK_Date.Location = new System.Drawing.Point(59, 328);
            this.DK_Date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DK_Date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DK_Date.Name = "DK_Date";
            this.DK_Date.Size = new System.Drawing.Size(255, 45);
            this.DK_Date.TabIndex = 23;
            this.DK_Date.Value = new System.DateTime(2023, 5, 28, 0, 23, 11, 398);
            // 
            // lbNgay
            // 
            this.lbNgay.BackColor = System.Drawing.Color.Transparent;
            this.lbNgay.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgay.Location = new System.Drawing.Point(59, 293);
            this.lbNgay.Margin = new System.Windows.Forms.Padding(4);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(281, 28);
            this.lbNgay.TabIndex = 22;
            this.lbNgay.Text = "Ngày đăng ký (yyyy-mm-dd)";
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.BorderRadius = 4;
            this.tbSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSoLuong.DefaultText = "";
            this.tbSoLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSoLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSoLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSoLuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSoLuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSoLuong.Font = new System.Drawing.Font("Google Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoLuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSoLuong.Location = new System.Drawing.Point(504, 328);
            this.tbSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.PasswordChar = '\0';
            this.tbSoLuong.PlaceholderText = "";
            this.tbSoLuong.SelectedText = "";
            this.tbSoLuong.Size = new System.Drawing.Size(255, 44);
            this.tbSoLuong.TabIndex = 25;
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.lbSoLuong.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuong.Location = new System.Drawing.Point(504, 293);
            this.lbSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(86, 28);
            this.lbSoLuong.TabIndex = 24;
            this.lbSoLuong.Text = "Số lượng";
            // 
            // cbThanhToan
            // 
            this.cbThanhToan.BackColor = System.Drawing.Color.Transparent;
            this.cbThanhToan.BorderRadius = 4;
            this.cbThanhToan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbThanhToan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThanhToan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbThanhToan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbThanhToan.Font = new System.Drawing.Font("Google Sans", 10.8F);
            this.cbThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbThanhToan.ItemHeight = 30;
            this.cbThanhToan.Items.AddRange(new object[] {
            "Đã thanh toán",
            "Chưa thanh toán"});
            this.cbThanhToan.Location = new System.Drawing.Point(877, 337);
            this.cbThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.cbThanhToan.Name = "cbThanhToan";
            this.cbThanhToan.Size = new System.Drawing.Size(253, 36);
            this.cbThanhToan.TabIndex = 27;
            // 
            // lbThanhToan
            // 
            this.lbThanhToan.BackColor = System.Drawing.Color.Transparent;
            this.lbThanhToan.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhToan.Location = new System.Drawing.Point(877, 302);
            this.lbThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.lbThanhToan.Name = "lbThanhToan";
            this.lbThanhToan.Size = new System.Drawing.Size(208, 28);
            this.lbThanhToan.TabIndex = 26;
            this.lbThanhToan.Text = "Trạng thái thanh toán";
            // 
            // btnThoat
            // 
            this.btnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoat.FillColor = System.Drawing.Color.DeepPink;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(1009, 815);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 55);
            this.btnThoat.TabIndex = 28;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // bntAddDV
            // 
            this.bntAddDV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bntAddDV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bntAddDV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bntAddDV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bntAddDV.FillColor = System.Drawing.Color.DeepPink;
            this.bntAddDV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bntAddDV.ForeColor = System.Drawing.Color.White;
            this.bntAddDV.Location = new System.Drawing.Point(360, 492);
            this.bntAddDV.Margin = new System.Windows.Forms.Padding(4);
            this.bntAddDV.Name = "bntAddDV";
            this.bntAddDV.Size = new System.Drawing.Size(423, 55);
            this.bntAddDV.TabIndex = 29;
            this.bntAddDV.Text = "Đăng ký";
            this.bntAddDV.Click += new System.EventHandler(this.bntAddDV_Click);
            // 
            // LeTan_Service_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bntAddDV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.cbThanhToan);
            this.Controls.Add(this.lbThanhToan);
            this.Controls.Add(this.tbSoLuong);
            this.Controls.Add(this.lbSoLuong);
            this.Controls.Add(this.DK_Date);
            this.Controls.Add(this.lbNgay);
            this.Controls.Add(this.cbLoaiDV);
            this.Controls.Add(this.lb_LoaiDV);
            this.Controls.Add(this.tb_MKH);
            this.Controls.Add(this.lb_MKH);
            this.Controls.Add(this.HomeLabel);
            this.Name = "LeTan_Service_Booking";
            this.Size = new System.Drawing.Size(1219, 923);
            this.Load += new System.EventHandler(this.LeTan_Service_Booking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel HomeLabel;
        private Guna.UI2.WinForms.Guna2TextBox tb_MKH;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_MKH;
        private Guna.UI2.WinForms.Guna2ComboBox cbLoaiDV;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_LoaiDV;
        private Guna.UI2.WinForms.Guna2DateTimePicker DK_Date;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbNgay;
        private Guna.UI2.WinForms.Guna2TextBox tbSoLuong;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbSoLuong;
        private Guna.UI2.WinForms.Guna2ComboBox cbThanhToan;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbThanhToan;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private Guna.UI2.WinForms.Guna2Button bntAddDV;
    }
}
