
namespace HotelSystem
{
    partial class LeTan_Checkin_KM
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
            this.tb_KM_MKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_KM = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_KM_TraCuu = new Guna.UI2.WinForms.Guna2Button();
            this.lvKM = new System.Windows.Forms.ListView();
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // HomeLabel
            // 
            this.HomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.HomeLabel.Font = new System.Drawing.Font("Google Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.HomeLabel.Location = new System.Drawing.Point(198, 54);
            this.HomeLabel.Margin = new System.Windows.Forms.Padding(4);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(835, 59);
            this.HomeLabel.TabIndex = 1;
            this.HomeLabel.Text = "TRA CỨU CHƯƠNG TRÌNH KHUYẾN MÃI";
            this.HomeLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_KM_MKH
            // 
            this.tb_KM_MKH.BorderRadius = 4;
            this.tb_KM_MKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_KM_MKH.DefaultText = "";
            this.tb_KM_MKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_KM_MKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_KM_MKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_KM_MKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_KM_MKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_KM_MKH.Font = new System.Drawing.Font("Google Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_KM_MKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_KM_MKH.Location = new System.Drawing.Point(85, 220);
            this.tb_KM_MKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_KM_MKH.Name = "tb_KM_MKH";
            this.tb_KM_MKH.PasswordChar = '\0';
            this.tb_KM_MKH.PlaceholderText = "";
            this.tb_KM_MKH.SelectedText = "";
            this.tb_KM_MKH.Size = new System.Drawing.Size(255, 44);
            this.tb_KM_MKH.TabIndex = 5;
            // 
            // lb_KM
            // 
            this.lb_KM.BackColor = System.Drawing.Color.Transparent;
            this.lb_KM.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_KM.Location = new System.Drawing.Point(85, 185);
            this.lb_KM.Margin = new System.Windows.Forms.Padding(4);
            this.lb_KM.Name = "lb_KM";
            this.lb_KM.Size = new System.Drawing.Size(146, 28);
            this.lb_KM.TabIndex = 4;
            this.lb_KM.Text = "Mã khách hàng";
            // 
            // btn_KM_TraCuu
            // 
            this.btn_KM_TraCuu.BorderRadius = 5;
            this.btn_KM_TraCuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_KM_TraCuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_KM_TraCuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_KM_TraCuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_KM_TraCuu.FillColor = System.Drawing.Color.DeepPink;
            this.btn_KM_TraCuu.Font = new System.Drawing.Font("Google Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KM_TraCuu.ForeColor = System.Drawing.Color.White;
            this.btn_KM_TraCuu.Location = new System.Drawing.Point(441, 308);
            this.btn_KM_TraCuu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_KM_TraCuu.Name = "btn_KM_TraCuu";
            this.btn_KM_TraCuu.Size = new System.Drawing.Size(240, 55);
            this.btn_KM_TraCuu.TabIndex = 6;
            this.btn_KM_TraCuu.Text = "Tra cứu";
            this.btn_KM_TraCuu.Click += new System.EventHandler(this.btn_KM_TraCuu_Click);
            // 
            // lvKM
            // 
            this.lvKM.HideSelection = false;
            this.lvKM.Location = new System.Drawing.Point(85, 427);
            this.lvKM.Name = "lvKM";
            this.lvKM.Size = new System.Drawing.Size(1047, 330);
            this.lvKM.TabIndex = 7;
            this.lvKM.UseCompatibleStateImageBehavior = false;
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
            this.btnThoat.Location = new System.Drawing.Point(1020, 835);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 55);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // LeTan_Checkin_KM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lvKM);
            this.Controls.Add(this.btn_KM_TraCuu);
            this.Controls.Add(this.tb_KM_MKH);
            this.Controls.Add(this.lb_KM);
            this.Controls.Add(this.HomeLabel);
            this.Name = "LeTan_Checkin_KM";
            this.Size = new System.Drawing.Size(1219, 923);
            this.Load += new System.EventHandler(this.LeTan_Checkin_KM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel HomeLabel;
        private Guna.UI2.WinForms.Guna2TextBox tb_KM_MKH;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_KM;
        private Guna.UI2.WinForms.Guna2Button btn_KM_TraCuu;
        private System.Windows.Forms.ListView lvKM;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
    }
}
