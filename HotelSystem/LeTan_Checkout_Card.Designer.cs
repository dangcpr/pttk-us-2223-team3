namespace HotelSystem
{
    partial class LeTan_Checkout_Card
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.checkoutCardPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.controlPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.returnBtn = new Guna.UI2.WinForms.Guna2Button();
            this.createInvoiceBtn = new Guna.UI2.WinForms.Guna2Button();
            this.checkoutCardContentPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.serviceDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.roomTypeTxb = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.customerNameTxb = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.roomStatusTxb = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.HomeLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.loadBtn = new Guna.UI2.WinForms.Guna2Button();
            this.checkoutCardPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.checkoutCardContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // checkoutCardPanel
            // 
            this.checkoutCardPanel.Controls.Add(this.loadBtn);
            this.checkoutCardPanel.Controls.Add(this.controlPanel);
            this.checkoutCardPanel.Controls.Add(this.checkoutCardContentPanel);
            this.checkoutCardPanel.Controls.Add(this.HomeLabel);
            this.checkoutCardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkoutCardPanel.Location = new System.Drawing.Point(0, 0);
            this.checkoutCardPanel.Name = "checkoutCardPanel";
            this.checkoutCardPanel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.checkoutCardPanel.Size = new System.Drawing.Size(1219, 923);
            this.checkoutCardPanel.TabIndex = 3;
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.returnBtn);
            this.controlPanel.Controls.Add(this.createInvoiceBtn);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.Location = new System.Drawing.Point(10, 783);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1209, 140);
            this.controlPanel.TabIndex = 16;
            // 
            // returnBtn
            // 
            this.returnBtn.BorderRadius = 5;
            this.returnBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.returnBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.returnBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.returnBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.returnBtn.FillColor = System.Drawing.Color.DeepPink;
            this.returnBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.returnBtn.ForeColor = System.Drawing.Color.White;
            this.returnBtn.Location = new System.Drawing.Point(325, 28);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(214, 45);
            this.returnBtn.TabIndex = 2;
            this.returnBtn.Text = "Quay lại";
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // createInvoiceBtn
            // 
            this.createInvoiceBtn.BorderRadius = 5;
            this.createInvoiceBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createInvoiceBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createInvoiceBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createInvoiceBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createInvoiceBtn.FillColor = System.Drawing.Color.DeepPink;
            this.createInvoiceBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createInvoiceBtn.ForeColor = System.Drawing.Color.White;
            this.createInvoiceBtn.Location = new System.Drawing.Point(646, 28);
            this.createInvoiceBtn.Name = "createInvoiceBtn";
            this.createInvoiceBtn.Size = new System.Drawing.Size(214, 45);
            this.createInvoiceBtn.TabIndex = 1;
            this.createInvoiceBtn.Text = "Lập phiếu thanh toán";
            this.createInvoiceBtn.Click += new System.EventHandler(this.createInvoiceBtn_Click);
            // 
            // checkoutCardContentPanel
            // 
            this.checkoutCardContentPanel.AutoSize = true;
            this.checkoutCardContentPanel.Controls.Add(this.serviceDataGridView);
            this.checkoutCardContentPanel.Controls.Add(this.roomTypeTxb);
            this.checkoutCardContentPanel.Controls.Add(this.guna2HtmlLabel4);
            this.checkoutCardContentPanel.Controls.Add(this.customerNameTxb);
            this.checkoutCardContentPanel.Controls.Add(this.guna2HtmlLabel3);
            this.checkoutCardContentPanel.Controls.Add(this.roomStatusTxb);
            this.checkoutCardContentPanel.Controls.Add(this.guna2HtmlLabel2);
            this.checkoutCardContentPanel.Controls.Add(this.guna2HtmlLabel1);
            this.checkoutCardContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkoutCardContentPanel.Location = new System.Drawing.Point(10, 78);
            this.checkoutCardContentPanel.Name = "checkoutCardContentPanel";
            this.checkoutCardContentPanel.Size = new System.Drawing.Size(1209, 845);
            this.checkoutCardContentPanel.TabIndex = 5;
            // 
            // serviceDataGridView
            // 
            this.serviceDataGridView.AllowUserToAddRows = false;
            this.serviceDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.serviceDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serviceDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.serviceDataGridView.ColumnHeadersHeight = 25;
            this.serviceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.serviceDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.serviceDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.serviceDataGridView.Location = new System.Drawing.Point(8, 276);
            this.serviceDataGridView.MultiSelect = false;
            this.serviceDataGridView.Name = "serviceDataGridView";
            this.serviceDataGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serviceDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.serviceDataGridView.RowHeadersVisible = false;
            this.serviceDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.serviceDataGridView.RowTemplate.Height = 24;
            this.serviceDataGridView.Size = new System.Drawing.Size(1193, 412);
            this.serviceDataGridView.TabIndex = 20;
            this.serviceDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.serviceDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.serviceDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.serviceDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.serviceDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.serviceDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.serviceDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.serviceDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.serviceDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.serviceDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.serviceDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.serviceDataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.serviceDataGridView.ThemeStyle.ReadOnly = true;
            this.serviceDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.serviceDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.serviceDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.serviceDataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.serviceDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.serviceDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // roomTypeTxb
            // 
            this.roomTypeTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roomTypeTxb.DefaultText = "";
            this.roomTypeTxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.roomTypeTxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.roomTypeTxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roomTypeTxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roomTypeTxb.Enabled = false;
            this.roomTypeTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomTypeTxb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.roomTypeTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomTypeTxb.Location = new System.Drawing.Point(452, 166);
            this.roomTypeTxb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roomTypeTxb.Name = "roomTypeTxb";
            this.roomTypeTxb.PasswordChar = '\0';
            this.roomTypeTxb.PlaceholderText = "";
            this.roomTypeTxb.SelectedText = "";
            this.roomTypeTxb.Size = new System.Drawing.Size(370, 46);
            this.roomTypeTxb.TabIndex = 19;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(26, 175);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(110, 27);
            this.guna2HtmlLabel4.TabIndex = 18;
            this.guna2HtmlLabel4.Text = "Loại phòng";
            // 
            // customerNameTxb
            // 
            this.customerNameTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerNameTxb.DefaultText = "";
            this.customerNameTxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerNameTxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerNameTxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerNameTxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerNameTxb.Enabled = false;
            this.customerNameTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerNameTxb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.customerNameTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerNameTxb.Location = new System.Drawing.Point(452, 101);
            this.customerNameTxb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customerNameTxb.Name = "customerNameTxb";
            this.customerNameTxb.PasswordChar = '\0';
            this.customerNameTxb.PlaceholderText = "";
            this.customerNameTxb.SelectedText = "";
            this.customerNameTxb.Size = new System.Drawing.Size(370, 46);
            this.customerNameTxb.TabIndex = 17;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(26, 111);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(159, 27);
            this.guna2HtmlLabel3.TabIndex = 16;
            this.guna2HtmlLabel3.Text = "Tên khách hàng";
            // 
            // roomStatusTxb
            // 
            this.roomStatusTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roomStatusTxb.DefaultText = "";
            this.roomStatusTxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.roomStatusTxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.roomStatusTxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roomStatusTxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roomStatusTxb.Enabled = false;
            this.roomStatusTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomStatusTxb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.roomStatusTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomStatusTxb.Location = new System.Drawing.Point(452, 33);
            this.roomStatusTxb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roomStatusTxb.Name = "roomStatusTxb";
            this.roomStatusTxb.PasswordChar = '\0';
            this.roomStatusTxb.PlaceholderText = "";
            this.roomStatusTxb.SelectedText = "";
            this.roomStatusTxb.Size = new System.Drawing.Size(370, 46);
            this.roomStatusTxb.TabIndex = 15;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(26, 242);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(264, 27);
            this.guna2HtmlLabel2.TabIndex = 14;
            this.guna2HtmlLabel2.Text = "Danh sách dịch vụ sử dụng";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(26, 43);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(167, 27);
            this.guna2HtmlLabel1.TabIndex = 13;
            this.guna2HtmlLabel1.Text = "Tình trạng phòng";
            // 
            // HomeLabel
            // 
            this.HomeLabel.AutoSize = false;
            this.HomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.HomeLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HomeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.HomeLabel.Location = new System.Drawing.Point(10, 0);
            this.HomeLabel.Margin = new System.Windows.Forms.Padding(4);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(1209, 78);
            this.HomeLabel.TabIndex = 2;
            this.HomeLabel.Text = "PHIẾU CHECK OUT";
            this.HomeLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadBtn
            // 
            this.loadBtn.BorderRadius = 5;
            this.loadBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loadBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loadBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loadBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loadBtn.FillColor = System.Drawing.Color.DeepPink;
            this.loadBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loadBtn.ForeColor = System.Drawing.Color.White;
            this.loadBtn.Location = new System.Drawing.Point(973, 15);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(110, 45);
            this.loadBtn.TabIndex = 17;
            this.loadBtn.Text = "Load data";
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // LeTan_Checkout_Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkoutCardPanel);
            this.Name = "LeTan_Checkout_Card";
            this.Size = new System.Drawing.Size(1219, 923);
            this.checkoutCardPanel.ResumeLayout(false);
            this.checkoutCardPanel.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.checkoutCardContentPanel.ResumeLayout(false);
            this.checkoutCardContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel checkoutCardPanel;
        private Guna.UI2.WinForms.Guna2Panel checkoutCardContentPanel;
        private Guna.UI2.WinForms.Guna2TextBox roomStatusTxb;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel HomeLabel;
        private Guna.UI2.WinForms.Guna2Panel controlPanel;
        private Guna.UI2.WinForms.Guna2Button createInvoiceBtn;
        private Guna.UI2.WinForms.Guna2TextBox customerNameTxb;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox roomTypeTxb;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2Button returnBtn;
        private Guna.UI2.WinForms.Guna2DataGridView serviceDataGridView;
        private Guna.UI2.WinForms.Guna2Button loadBtn;
    }
}
