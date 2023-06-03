
namespace HotelSystem
{
    partial class LeTan_Room_Searching
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LeTanRoomInfoBtn = new Guna.UI2.WinForms.Guna2Button();
            this.LeTanRoomInfoInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LeTanRoomInfoListView = new System.Windows.Forms.ListView();
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
            this.HomeLabel.Text = "TRA CỨU THÔNG TIN ĐẶT PHÒNG";
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
            this.quitBookingBtn.Location = new System.Drawing.Point(743, 90);
            this.quitBookingBtn.Name = "quitBookingBtn";
            this.quitBookingBtn.Size = new System.Drawing.Size(107, 45);
            this.quitBookingBtn.TabIndex = 1;
            this.quitBookingBtn.Text = "Thoát";
            this.quitBookingBtn.Click += new System.EventHandler(this.quitBookingBtn_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(68, 112);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(244, 23);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Nhập mã đặt phòng để tra cứu:";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // LeTanRoomInfoBtn
            // 
            this.LeTanRoomInfoBtn.BorderRadius = 5;
            this.LeTanRoomInfoBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LeTanRoomInfoBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LeTanRoomInfoBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LeTanRoomInfoBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LeTanRoomInfoBtn.FillColor = System.Drawing.Color.DeepPink;
            this.LeTanRoomInfoBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LeTanRoomInfoBtn.ForeColor = System.Drawing.Color.White;
            this.LeTanRoomInfoBtn.Location = new System.Drawing.Point(68, 161);
            this.LeTanRoomInfoBtn.Name = "LeTanRoomInfoBtn";
            this.LeTanRoomInfoBtn.Size = new System.Drawing.Size(107, 45);
            this.LeTanRoomInfoBtn.TabIndex = 3;
            this.LeTanRoomInfoBtn.Text = "Tra cứu";
            this.LeTanRoomInfoBtn.Click += new System.EventHandler(this.LeTanRoomInfoBtn_Click);
            // 
            // LeTanRoomInfoInput
            // 
            this.LeTanRoomInfoInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LeTanRoomInfoInput.DefaultText = "";
            this.LeTanRoomInfoInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LeTanRoomInfoInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LeTanRoomInfoInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LeTanRoomInfoInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LeTanRoomInfoInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LeTanRoomInfoInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LeTanRoomInfoInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LeTanRoomInfoInput.Location = new System.Drawing.Point(225, 161);
            this.LeTanRoomInfoInput.Name = "LeTanRoomInfoInput";
            this.LeTanRoomInfoInput.PasswordChar = '\0';
            this.LeTanRoomInfoInput.PlaceholderText = "";
            this.LeTanRoomInfoInput.SelectedText = "";
            this.LeTanRoomInfoInput.Size = new System.Drawing.Size(287, 45);
            this.LeTanRoomInfoInput.TabIndex = 4;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(68, 248);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(161, 23);
            this.guna2HtmlLabel2.TabIndex = 5;
            this.guna2HtmlLabel2.Text = "Thông tin đặt phòng";
            // 
            // LeTanRoomInfoListView
            // 
            this.LeTanRoomInfoListView.HideSelection = false;
            this.LeTanRoomInfoListView.Location = new System.Drawing.Point(68, 287);
            this.LeTanRoomInfoListView.Name = "LeTanRoomInfoListView";
            this.LeTanRoomInfoListView.Size = new System.Drawing.Size(786, 134);
            this.LeTanRoomInfoListView.TabIndex = 6;
            this.LeTanRoomInfoListView.UseCompatibleStateImageBehavior = false;
            // 
            // LeTan_Room_Searching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.LeTanRoomInfoListView);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.LeTanRoomInfoInput);
            this.Controls.Add(this.LeTanRoomInfoBtn);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.quitBookingBtn);
            this.Controls.Add(this.HomeLabel);
            this.Name = "LeTan_Room_Searching";
            this.Size = new System.Drawing.Size(914, 750);
            this.Load += new System.EventHandler(this.LeTan_Room_Booking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel HomeLabel;
        private Guna.UI2.WinForms.Guna2Button quitBookingBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button LeTanRoomInfoBtn;
        private Guna.UI2.WinForms.Guna2TextBox LeTanRoomInfoInput;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.ListView LeTanRoomInfoListView;
    }
}
