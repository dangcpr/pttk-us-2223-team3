
namespace HotelSystem
{
    partial class LeTan_Checkin
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
            this.btnAddPYC = new Guna.UI2.WinForms.Guna2Button();
            this.btn_KM = new Guna.UI2.WinForms.Guna2Button();
            this.leTan_Checkin_PDK = new HotelSystem.LeTan_Checkin_PDK();
            this.leTan_Checkin_KM1 = new HotelSystem.LeTan_Checkin_KM();
            this.SuspendLayout();
            // 
            // HomeLabel
            // 
            this.HomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.HomeLabel.Font = new System.Drawing.Font("Google Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.HomeLabel.Location = new System.Drawing.Point(353, 34);
            this.HomeLabel.Margin = new System.Windows.Forms.Padding(4);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(469, 59);
            this.HomeLabel.TabIndex = 0;
            this.HomeLabel.Text = "THÔNG TIN CHECK IN";
            this.HomeLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddPYC
            // 
            this.btnAddPYC.BorderRadius = 5;
            this.btnAddPYC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPYC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPYC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPYC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPYC.FillColor = System.Drawing.Color.DeepPink;
            this.btnAddPYC.Font = new System.Drawing.Font("Google Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPYC.ForeColor = System.Drawing.Color.White;
            this.btnAddPYC.Location = new System.Drawing.Point(56, 156);
            this.btnAddPYC.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPYC.Name = "btnAddPYC";
            this.btnAddPYC.Size = new System.Drawing.Size(267, 55);
            this.btnAddPYC.TabIndex = 1;
            this.btnAddPYC.Text = "Thêm thông tin đăng ký";
            this.btnAddPYC.Click += new System.EventHandler(this.btnAddPYC_Click);
            // 
            // btn_KM
            // 
            this.btn_KM.BorderRadius = 5;
            this.btn_KM.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_KM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_KM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_KM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_KM.FillColor = System.Drawing.Color.DeepPink;
            this.btn_KM.Font = new System.Drawing.Font("Google Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KM.ForeColor = System.Drawing.Color.White;
            this.btn_KM.Location = new System.Drawing.Point(56, 246);
            this.btn_KM.Margin = new System.Windows.Forms.Padding(4);
            this.btn_KM.Name = "btn_KM";
            this.btn_KM.Size = new System.Drawing.Size(267, 55);
            this.btn_KM.TabIndex = 4;
            this.btn_KM.Text = "Tra cứu thông tin khuyến mãi";
            this.btn_KM.Click += new System.EventHandler(this.btn_KM_Click);
            // 
            // leTan_Checkin_PDK
            // 
            this.leTan_Checkin_PDK.Location = new System.Drawing.Point(0, 0);
            this.leTan_Checkin_PDK.Name = "leTan_Checkin_PDK";
            this.leTan_Checkin_PDK.Size = new System.Drawing.Size(1219, 923);
            this.leTan_Checkin_PDK.TabIndex = 2;
            this.leTan_Checkin_PDK.Load += new System.EventHandler(this.leTan_Checkin_PDK_Load);
            // 
            // leTan_Checkin_KM1
            // 
            this.leTan_Checkin_KM1.Location = new System.Drawing.Point(0, 0);
            this.leTan_Checkin_KM1.Name = "leTan_Checkin_KM1";
            this.leTan_Checkin_KM1.Size = new System.Drawing.Size(1219, 923);
            this.leTan_Checkin_KM1.TabIndex = 3;
            // 
            // LeTan_Checkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.btn_KM);
            this.Controls.Add(this.btnAddPYC);
            this.Controls.Add(this.HomeLabel);
            this.Controls.Add(this.leTan_Checkin_PDK);
            this.Controls.Add(this.leTan_Checkin_KM1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LeTan_Checkin";
            this.Size = new System.Drawing.Size(1177, 923);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel HomeLabel;
        private Guna.UI2.WinForms.Guna2Button btnAddPYC;
        private LeTan_Checkin_PDK leTan_Checkin_PDK;
        private LeTan_Checkin_KM leTan_Checkin_KM1;
        private Guna.UI2.WinForms.Guna2Button btn_KM;
    }
}
