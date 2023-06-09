﻿
namespace HotelSystem
{
    partial class LeTan_Customer_Searching
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
            this.LeTanCustomerInfoBtn = new Guna.UI2.WinForms.Guna2Button();
            this.LeTanCustomerInfoInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LeTanCustomerGroupListView = new System.Windows.Forms.ListView();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LeTanCustomerMainListView = new System.Windows.Forms.ListView();
            this.LeTancustomerTypeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
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
            this.HomeLabel.Text = "TRA CỨU THÔNG TIN KHÁCH HÀNG";
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
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(307, 23);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Nhập mã khách hàng / đoàn để tra cứu:";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // LeTanCustomerInfoBtn
            // 
            this.LeTanCustomerInfoBtn.BorderRadius = 5;
            this.LeTanCustomerInfoBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LeTanCustomerInfoBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LeTanCustomerInfoBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LeTanCustomerInfoBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LeTanCustomerInfoBtn.FillColor = System.Drawing.Color.DeepPink;
            this.LeTanCustomerInfoBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LeTanCustomerInfoBtn.ForeColor = System.Drawing.Color.White;
            this.LeTanCustomerInfoBtn.Location = new System.Drawing.Point(68, 225);
            this.LeTanCustomerInfoBtn.Name = "LeTanCustomerInfoBtn";
            this.LeTanCustomerInfoBtn.Size = new System.Drawing.Size(107, 45);
            this.LeTanCustomerInfoBtn.TabIndex = 3;
            this.LeTanCustomerInfoBtn.Text = "Tra cứu";
            this.LeTanCustomerInfoBtn.Click += new System.EventHandler(this.LeTanCustomerInfoBtn_Click);
            // 
            // LeTanCustomerInfoInput
            // 
            this.LeTanCustomerInfoInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LeTanCustomerInfoInput.DefaultText = "";
            this.LeTanCustomerInfoInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LeTanCustomerInfoInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LeTanCustomerInfoInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LeTanCustomerInfoInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LeTanCustomerInfoInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LeTanCustomerInfoInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LeTanCustomerInfoInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LeTanCustomerInfoInput.Location = new System.Drawing.Point(208, 225);
            this.LeTanCustomerInfoInput.Name = "LeTanCustomerInfoInput";
            this.LeTanCustomerInfoInput.PasswordChar = '\0';
            this.LeTanCustomerInfoInput.PlaceholderText = "";
            this.LeTanCustomerInfoInput.SelectedText = "";
            this.LeTanCustomerInfoInput.Size = new System.Drawing.Size(287, 45);
            this.LeTanCustomerInfoInput.TabIndex = 4;
            this.LeTanCustomerInfoInput.TextChanged += new System.EventHandler(this.LeTanCustomerInfoInput_TextChanged);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(67, 319);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(171, 23);
            this.guna2HtmlLabel2.TabIndex = 5;
            this.guna2HtmlLabel2.Text = "Thông tin khách hàng";
            // 
            // LeTanCustomerGroupListView
            // 
            this.LeTanCustomerGroupListView.HideSelection = false;
            this.LeTanCustomerGroupListView.Location = new System.Drawing.Point(63, 550);
            this.LeTanCustomerGroupListView.Name = "LeTanCustomerGroupListView";
            this.LeTanCustomerGroupListView.Size = new System.Drawing.Size(786, 134);
            this.LeTanCustomerGroupListView.TabIndex = 6;
            this.LeTanCustomerGroupListView.UseCompatibleStateImageBehavior = false;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(63, 521);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(171, 23);
            this.guna2HtmlLabel3.TabIndex = 7;
            this.guna2HtmlLabel3.Text = "Thông tin khách đoàn";
            // 
            // LeTanCustomerMainListView
            // 
            this.LeTanCustomerMainListView.HideSelection = false;
            this.LeTanCustomerMainListView.Location = new System.Drawing.Point(64, 348);
            this.LeTanCustomerMainListView.Name = "LeTanCustomerMainListView";
            this.LeTanCustomerMainListView.Size = new System.Drawing.Size(785, 134);
            this.LeTanCustomerMainListView.TabIndex = 8;
            this.LeTanCustomerMainListView.UseCompatibleStateImageBehavior = false;
            // 
            // LeTancustomerTypeComboBox
            // 
            this.LeTancustomerTypeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.LeTancustomerTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.LeTancustomerTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LeTancustomerTypeComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LeTancustomerTypeComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LeTancustomerTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LeTancustomerTypeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.LeTancustomerTypeComboBox.ItemHeight = 30;
            this.LeTancustomerTypeComboBox.Items.AddRange(new object[] {
            "Khách hàng",
            "Khách đoàn"});
            this.LeTancustomerTypeComboBox.Location = new System.Drawing.Point(67, 162);
            this.LeTancustomerTypeComboBox.Name = "LeTancustomerTypeComboBox";
            this.LeTancustomerTypeComboBox.Size = new System.Drawing.Size(160, 36);
            this.LeTancustomerTypeComboBox.TabIndex = 9;
            // 
            // LeTan_Customer_Searching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.LeTancustomerTypeComboBox);
            this.Controls.Add(this.LeTanCustomerMainListView);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.LeTanCustomerGroupListView);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.LeTanCustomerInfoInput);
            this.Controls.Add(this.LeTanCustomerInfoBtn);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.quitBookingBtn);
            this.Controls.Add(this.HomeLabel);
            this.Name = "LeTan_Customer_Searching";
            this.Size = new System.Drawing.Size(914, 750);
            this.Load += new System.EventHandler(this.LeTan_Room_Booking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel HomeLabel;
        private Guna.UI2.WinForms.Guna2Button quitBookingBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button LeTanCustomerInfoBtn;
        private Guna.UI2.WinForms.Guna2TextBox LeTanCustomerInfoInput;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.ListView LeTanCustomerGroupListView;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private System.Windows.Forms.ListView LeTanCustomerMainListView;
        private Guna.UI2.WinForms.Guna2ComboBox LeTancustomerTypeComboBox;
    }
}