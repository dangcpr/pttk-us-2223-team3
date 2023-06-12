
namespace HotelSystem
{
    partial class KhachHang_Feedback_Update
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.LabelUser = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelUpdate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.feedbackContent = new Guna.UI2.WinForms.Guna2TextBox();
            this.CancelButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.updateButton = new Guna.UI2.WinForms.Guna2Button();
            this.feedbackTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.feedbackIDText = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.customerIDText = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackTable)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // LabelUser
            // 
            this.LabelUser.BackColor = System.Drawing.Color.Transparent;
            this.LabelUser.Font = new System.Drawing.Font("Google Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUser.Location = new System.Drawing.Point(134, 327);
            this.LabelUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(77, 20);
            this.LabelUser.TabIndex = 1;
            this.LabelUser.Text = "FEEDBACK";
            // 
            // labelUpdate
            // 
            this.labelUpdate.AutoSize = false;
            this.labelUpdate.BackColor = System.Drawing.Color.Transparent;
            this.labelUpdate.Font = new System.Drawing.Font("Google Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdate.ForeColor = System.Drawing.Color.DeepPink;
            this.labelUpdate.Location = new System.Drawing.Point(0, 30);
            this.labelUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(850, 30);
            this.labelUpdate.TabIndex = 13;
            this.labelUpdate.Text = "CẬP NHẬT FEEDBACK";
            this.labelUpdate.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // feedbackContent
            // 
            this.feedbackContent.BorderRadius = 4;
            this.feedbackContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.feedbackContent.DefaultText = "";
            this.feedbackContent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.feedbackContent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.feedbackContent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.feedbackContent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.feedbackContent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.feedbackContent.Font = new System.Drawing.Font("Google Sans", 10.8F);
            this.feedbackContent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.feedbackContent.Location = new System.Drawing.Point(134, 352);
            this.feedbackContent.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.feedbackContent.Name = "feedbackContent";
            this.feedbackContent.PasswordChar = '\0';
            this.feedbackContent.PlaceholderText = "Ghi nội dung Feedback vào đây";
            this.feedbackContent.SelectedText = "";
            this.feedbackContent.Size = new System.Drawing.Size(602, 39);
            this.feedbackContent.TabIndex = 2;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.BorderRadius = 4;
            this.CancelButton.FillColor = System.Drawing.Color.DeepPink;
            this.CancelButton.IconColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(795, 11);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(45, 29);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.AutoRoundedCorners = true;
            this.updateButton.BorderRadius = 17;
            this.updateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateButton.FillColor = System.Drawing.Color.DeepPink;
            this.updateButton.Font = new System.Drawing.Font("Google Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(358, 407);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(135, 37);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "CẬP NHẬT";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // feedbackTable
            // 
            this.feedbackTable.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.feedbackTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Google Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.feedbackTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.feedbackTable.ColumnHeadersHeight = 25;
            this.feedbackTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.feedbackTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.feedbackTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.feedbackTable.Location = new System.Drawing.Point(23, 88);
            this.feedbackTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.feedbackTable.Name = "feedbackTable";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Google Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.feedbackTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.feedbackTable.RowHeadersVisible = false;
            this.feedbackTable.RowHeadersWidth = 51;
            this.feedbackTable.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Google Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackTable.RowTemplate.Height = 24;
            this.feedbackTable.Size = new System.Drawing.Size(802, 169);
            this.feedbackTable.TabIndex = 15;
            this.feedbackTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.feedbackTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.feedbackTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.feedbackTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.feedbackTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.feedbackTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.feedbackTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.feedbackTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.feedbackTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.feedbackTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.feedbackTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.feedbackTable.ThemeStyle.HeaderStyle.Height = 25;
            this.feedbackTable.ThemeStyle.ReadOnly = false;
            this.feedbackTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.feedbackTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.feedbackTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.feedbackTable.ThemeStyle.RowsStyle.Height = 24;
            this.feedbackTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.feedbackTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.feedbackTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.feedbackTable_CellClick);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Google Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(0, 65);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(850, 18);
            this.guna2HtmlLabel1.TabIndex = 16;
            this.guna2HtmlLabel1.Text = "Vui lòng chọn dòng Feedback muốn cập nhật rồi ghi vào ô FEEDBACK bên dưới";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Google Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(134, 261);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(70, 20);
            this.guna2HtmlLabel2.TabIndex = 17;
            this.guna2HtmlLabel2.Text = "MÃ PHIẾU";
            // 
            // feedbackIDText
            // 
            this.feedbackIDText.BorderRadius = 4;
            this.feedbackIDText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.feedbackIDText.DefaultText = "";
            this.feedbackIDText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.feedbackIDText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.feedbackIDText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.feedbackIDText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.feedbackIDText.Enabled = false;
            this.feedbackIDText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.feedbackIDText.Font = new System.Drawing.Font("Google Sans", 10.8F);
            this.feedbackIDText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.feedbackIDText.Location = new System.Drawing.Point(134, 286);
            this.feedbackIDText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.feedbackIDText.Name = "feedbackIDText";
            this.feedbackIDText.PasswordChar = '\0';
            this.feedbackIDText.PlaceholderText = "";
            this.feedbackIDText.SelectedText = "";
            this.feedbackIDText.Size = new System.Drawing.Size(208, 39);
            this.feedbackIDText.TabIndex = 18;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Google Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(401, 261);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(125, 20);
            this.guna2HtmlLabel3.TabIndex = 19;
            this.guna2HtmlLabel3.Text = "MÃ KHÁCH HÀNG";
            // 
            // customerIDText
            // 
            this.customerIDText.BorderRadius = 4;
            this.customerIDText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerIDText.DefaultText = "";
            this.customerIDText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerIDText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerIDText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerIDText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerIDText.Enabled = false;
            this.customerIDText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerIDText.Font = new System.Drawing.Font("Google Sans", 10.8F);
            this.customerIDText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerIDText.Location = new System.Drawing.Point(401, 286);
            this.customerIDText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.customerIDText.Name = "customerIDText";
            this.customerIDText.PasswordChar = '\0';
            this.customerIDText.PlaceholderText = "";
            this.customerIDText.SelectedText = "";
            this.customerIDText.Size = new System.Drawing.Size(335, 39);
            this.customerIDText.TabIndex = 20;
            // 
            // KhachHang_Feedback_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(850, 460);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.customerIDText);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.feedbackIDText);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.feedbackTable);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.LabelUser);
            this.Controls.Add(this.feedbackContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "KhachHang_Feedback_Update";
            this.Text = "CẬP NHẬT FEEDBACK";
            this.Load += new System.EventHandler(this.KhachHang_Feedback_Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.feedbackTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ControlBox CancelButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelUpdate;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelUser;
        private Guna.UI2.WinForms.Guna2TextBox feedbackContent;
        private Guna.UI2.WinForms.Guna2Button updateButton;
        private Guna.UI2.WinForms.Guna2DataGridView feedbackTable;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox feedbackIDText;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox customerIDText;
    }
}

