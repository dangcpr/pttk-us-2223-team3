
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
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.xemlichdv_service_btn = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeLabel
            // 
            this.HomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.HomeLabel.Font = new System.Drawing.Font("Google Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.HomeLabel.Location = new System.Drawing.Point(360, 34);
            this.HomeLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(440, 59);
            this.HomeLabel.TabIndex = 0;
            this.HomeLabel.Text = "THÔNG TIN DỊCH VỤ";
            this.HomeLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(59, 103);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(252, 28);
            this.guna2HtmlLabel2.TabIndex = 45;
            this.guna2HtmlLabel2.Text = "Danh sách đặt lịch dịch vụ";
            // 
            // xemlichdv_service_btn
            // 
            this.xemlichdv_service_btn.BorderRadius = 5;
            this.xemlichdv_service_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.xemlichdv_service_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.xemlichdv_service_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.xemlichdv_service_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.xemlichdv_service_btn.FillColor = System.Drawing.Color.DeepPink;
            this.xemlichdv_service_btn.Font = new System.Drawing.Font("Google Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xemlichdv_service_btn.ForeColor = System.Drawing.Color.White;
            this.xemlichdv_service_btn.Location = new System.Drawing.Point(801, 103);
            this.xemlichdv_service_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xemlichdv_service_btn.Name = "xemlichdv_service_btn";
            this.xemlichdv_service_btn.Size = new System.Drawing.Size(286, 34);
            this.xemlichdv_service_btn.TabIndex = 43;
            this.xemlichdv_service_btn.Text = "Xem danh sách đặt lịch dịch vụ";
            this.xemlichdv_service_btn.Click += new System.EventHandler(this.xemlichdv_service_btn_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(59, 167);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1028, 276);
            this.dataGridView3.TabIndex = 46;
            // 
            // LeTan_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.xemlichdv_service_btn);
            this.Controls.Add(this.HomeLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LeTan_Service";
            this.Size = new System.Drawing.Size(1219, 923);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel HomeLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button xemlichdv_service_btn;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}
