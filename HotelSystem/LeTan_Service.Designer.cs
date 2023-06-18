
namespace HotelSystem
{
    partial class LeTan_Service
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
            this.lvService = new System.Windows.Forms.ListView();
            this.btnSearchDV = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddDV = new Guna.UI2.WinForms.Guna2Button();
            this.leTan_Service_Searching1 = new HotelSystem.LeTan_Service_Searching();
            this.leTan_Service_Booking1 = new HotelSystem.LeTan_Service_Booking();
            this.btnXemDV = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // HomeLabel
            // 
            this.HomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.HomeLabel.Font = new System.Drawing.Font("Google Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.HomeLabel.Location = new System.Drawing.Point(360, 34);
            this.HomeLabel.Margin = new System.Windows.Forms.Padding(4);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(440, 59);
            this.HomeLabel.TabIndex = 0;
            this.HomeLabel.Text = "THÔNG TIN DỊCH VỤ";
            this.HomeLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvService
            // 
            this.lvService.GridLines = true;
            this.lvService.HideSelection = false;
            this.lvService.Location = new System.Drawing.Point(74, 178);
            this.lvService.Name = "lvService";
            this.lvService.Size = new System.Drawing.Size(1049, 444);
            this.lvService.TabIndex = 1;
            this.lvService.UseCompatibleStateImageBehavior = false;
            // 
            // btnSearchDV
            // 
            this.btnSearchDV.BorderRadius = 5;
            this.btnSearchDV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchDV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchDV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchDV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchDV.FillColor = System.Drawing.Color.DeepPink;
            this.btnSearchDV.Font = new System.Drawing.Font("Google Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDV.ForeColor = System.Drawing.Color.White;
            this.btnSearchDV.Location = new System.Drawing.Point(74, 724);
            this.btnSearchDV.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchDV.Name = "btnSearchDV";
            this.btnSearchDV.Size = new System.Drawing.Size(267, 55);
            this.btnSearchDV.TabIndex = 2;
            this.btnSearchDV.Text = "Tra cứu sử dụng dịch vụ";
            this.btnSearchDV.Click += new System.EventHandler(this.btnSearchDV_Click);
            // 
            // btnAddDV
            // 
            this.btnAddDV.BorderRadius = 5;
            this.btnAddDV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddDV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddDV.FillColor = System.Drawing.Color.DeepPink;
            this.btnAddDV.Font = new System.Drawing.Font("Google Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDV.ForeColor = System.Drawing.Color.White;
            this.btnAddDV.Location = new System.Drawing.Point(856, 724);
            this.btnAddDV.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDV.Name = "btnAddDV";
            this.btnAddDV.Size = new System.Drawing.Size(267, 55);
            this.btnAddDV.TabIndex = 3;
            this.btnAddDV.Text = "Lập phiếu đăng ký dịch vụ";
            this.btnAddDV.Click += new System.EventHandler(this.btnAddDV_Click);
            // 
            // leTan_Service_Searching1
            // 
            this.leTan_Service_Searching1.Location = new System.Drawing.Point(0, -3);
            this.leTan_Service_Searching1.Name = "leTan_Service_Searching1";
            this.leTan_Service_Searching1.Size = new System.Drawing.Size(1219, 923);
            this.leTan_Service_Searching1.TabIndex = 4;
            // 
            // leTan_Service_Booking1
            // 
            this.leTan_Service_Booking1.Location = new System.Drawing.Point(-3, -3);
            this.leTan_Service_Booking1.Name = "leTan_Service_Booking1";
            this.leTan_Service_Booking1.Size = new System.Drawing.Size(1219, 923);
            this.leTan_Service_Booking1.TabIndex = 5;
            // 
            // btnXemDV
            // 
            this.btnXemDV.BorderRadius = 5;
            this.btnXemDV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXemDV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXemDV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXemDV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXemDV.FillColor = System.Drawing.Color.DeepPink;
            this.btnXemDV.Font = new System.Drawing.Font("Google Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDV.ForeColor = System.Drawing.Color.White;
            this.btnXemDV.Location = new System.Drawing.Point(74, 122);
            this.btnXemDV.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemDV.Name = "btnXemDV";
            this.btnXemDV.Size = new System.Drawing.Size(236, 40);
            this.btnXemDV.TabIndex = 6;
            this.btnXemDV.Text = "Xem thông tin dịch vụ";
            this.btnXemDV.Click += new System.EventHandler(this.btnXemKM_Click);
            // 
            // LeTan_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.btnXemDV);
            this.Controls.Add(this.btnAddDV);
            this.Controls.Add(this.btnSearchDV);
            this.Controls.Add(this.lvService);
            this.Controls.Add(this.HomeLabel);
            this.Controls.Add(this.leTan_Service_Searching1);
            this.Controls.Add(this.leTan_Service_Booking1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LeTan_Service";
            this.Size = new System.Drawing.Size(1219, 923);
            this.Load += new System.EventHandler(this.LeTan_Service_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel HomeLabel;
        private System.Windows.Forms.ListView lvService;
        private Guna.UI2.WinForms.Guna2Button btnSearchDV;
        private Guna.UI2.WinForms.Guna2Button btnAddDV;
        private LeTan_Service_Searching leTan_Service_Searching1;
        private LeTan_Service_Booking leTan_Service_Booking1;
        private Guna.UI2.WinForms.Guna2Button btnXemDV;
    }
}
