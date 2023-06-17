namespace HotelSystem
{
    partial class LeTan_Invoice_Search
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HomeLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.invoicePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.controlPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.showDetailBtn = new Guna.UI2.WinForms.Guna2Button();
            this.returnBtn = new Guna.UI2.WinForms.Guna2Button();
            this.listInvoicesPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.listInvoicesDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchByInvoiceDateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.invoiceDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.customerIDTxb = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchByCustomerIDBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.invoiceIDTxb = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchByInvoiceIDBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.loadBtn = new Guna.UI2.WinForms.Guna2Button();
            this.invoicePanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.listInvoicesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listInvoicesDataGridView)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.HomeLabel.Text = "DANH SÁCH PHIẾU THANH TOÁN";
            this.HomeLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // invoicePanel
            // 
            this.invoicePanel.Controls.Add(this.controlPanel);
            this.invoicePanel.Controls.Add(this.listInvoicesPanel);
            this.invoicePanel.Controls.Add(this.searchPanel);
            this.invoicePanel.Controls.Add(this.HomeLabel);
            this.invoicePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoicePanel.Location = new System.Drawing.Point(0, 0);
            this.invoicePanel.Name = "invoicePanel";
            this.invoicePanel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.invoicePanel.Size = new System.Drawing.Size(1219, 923);
            this.invoicePanel.TabIndex = 5;
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.showDetailBtn);
            this.controlPanel.Controls.Add(this.returnBtn);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(10, 785);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1209, 138);
            this.controlPanel.TabIndex = 27;
            // 
            // showDetailBtn
            // 
            this.showDetailBtn.BorderRadius = 5;
            this.showDetailBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.showDetailBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.showDetailBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.showDetailBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.showDetailBtn.FillColor = System.Drawing.Color.DeepPink;
            this.showDetailBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.showDetailBtn.ForeColor = System.Drawing.Color.White;
            this.showDetailBtn.Location = new System.Drawing.Point(683, 48);
            this.showDetailBtn.Name = "showDetailBtn";
            this.showDetailBtn.Size = new System.Drawing.Size(214, 45);
            this.showDetailBtn.TabIndex = 3;
            this.showDetailBtn.Text = "Xem chi tiết";
            this.showDetailBtn.Click += new System.EventHandler(this.showDetailBtn_Click);
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
            this.returnBtn.Location = new System.Drawing.Point(356, 48);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(214, 45);
            this.returnBtn.TabIndex = 2;
            this.returnBtn.Text = "Quay lại";
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // listInvoicesPanel
            // 
            this.listInvoicesPanel.Controls.Add(this.listInvoicesDataGridView);
            this.listInvoicesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.listInvoicesPanel.Location = new System.Drawing.Point(10, 302);
            this.listInvoicesPanel.Name = "listInvoicesPanel";
            this.listInvoicesPanel.Padding = new System.Windows.Forms.Padding(8);
            this.listInvoicesPanel.Size = new System.Drawing.Size(1209, 483);
            this.listInvoicesPanel.TabIndex = 25;
            // 
            // listInvoicesDataGridView
            // 
            this.listInvoicesDataGridView.AllowUserToAddRows = false;
            this.listInvoicesDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.listInvoicesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listInvoicesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.listInvoicesDataGridView.ColumnHeadersHeight = 25;
            this.listInvoicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listInvoicesDataGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.listInvoicesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listInvoicesDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listInvoicesDataGridView.Location = new System.Drawing.Point(8, 8);
            this.listInvoicesDataGridView.MultiSelect = false;
            this.listInvoicesDataGridView.Name = "listInvoicesDataGridView";
            this.listInvoicesDataGridView.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listInvoicesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.listInvoicesDataGridView.RowHeadersVisible = false;
            this.listInvoicesDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.listInvoicesDataGridView.RowTemplate.Height = 24;
            this.listInvoicesDataGridView.Size = new System.Drawing.Size(1193, 467);
            this.listInvoicesDataGridView.TabIndex = 20;
            this.listInvoicesDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.listInvoicesDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.listInvoicesDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.listInvoicesDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.listInvoicesDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.listInvoicesDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.listInvoicesDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listInvoicesDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.listInvoicesDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listInvoicesDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listInvoicesDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.listInvoicesDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.listInvoicesDataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.listInvoicesDataGridView.ThemeStyle.ReadOnly = true;
            this.listInvoicesDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.listInvoicesDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listInvoicesDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listInvoicesDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.listInvoicesDataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.listInvoicesDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listInvoicesDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.loadBtn);
            this.searchPanel.Controls.Add(this.searchByInvoiceDateBtn);
            this.searchPanel.Controls.Add(this.guna2HtmlLabel3);
            this.searchPanel.Controls.Add(this.invoiceDatePicker);
            this.searchPanel.Controls.Add(this.customerIDTxb);
            this.searchPanel.Controls.Add(this.searchByCustomerIDBtn);
            this.searchPanel.Controls.Add(this.guna2HtmlLabel1);
            this.searchPanel.Controls.Add(this.invoiceIDTxb);
            this.searchPanel.Controls.Add(this.searchByInvoiceIDBtn);
            this.searchPanel.Controls.Add(this.guna2HtmlLabel2);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel.Location = new System.Drawing.Point(10, 78);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1209, 224);
            this.searchPanel.TabIndex = 24;
            // 
            // searchByInvoiceDateBtn
            // 
            this.searchByInvoiceDateBtn.BorderRadius = 5;
            this.searchByInvoiceDateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchByInvoiceDateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchByInvoiceDateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchByInvoiceDateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchByInvoiceDateBtn.FillColor = System.Drawing.Color.DeepPink;
            this.searchByInvoiceDateBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchByInvoiceDateBtn.ForeColor = System.Drawing.Color.White;
            this.searchByInvoiceDateBtn.Location = new System.Drawing.Point(429, 156);
            this.searchByInvoiceDateBtn.Name = "searchByInvoiceDateBtn";
            this.searchByInvoiceDateBtn.Size = new System.Drawing.Size(98, 46);
            this.searchByInvoiceDateBtn.TabIndex = 31;
            this.searchByInvoiceDateBtn.Text = "Tra cứu";
            this.searchByInvoiceDateBtn.Click += new System.EventHandler(this.searchByInvoiceDateBtn_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(22, 121);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(155, 27);
            this.guna2HtmlLabel3.TabIndex = 30;
            this.guna2HtmlLabel3.Text = "Chọn ngày xuất";
            // 
            // invoiceDatePicker
            // 
            this.invoiceDatePicker.Checked = true;
            this.invoiceDatePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.invoiceDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.invoiceDatePicker.Location = new System.Drawing.Point(22, 156);
            this.invoiceDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.invoiceDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.invoiceDatePicker.Name = "invoiceDatePicker";
            this.invoiceDatePicker.Size = new System.Drawing.Size(370, 48);
            this.invoiceDatePicker.TabIndex = 29;
            this.invoiceDatePicker.Value = new System.DateTime(2023, 6, 15, 11, 18, 21, 733);
            // 
            // customerIDTxb
            // 
            this.customerIDTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerIDTxb.DefaultText = "";
            this.customerIDTxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerIDTxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerIDTxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerIDTxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerIDTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerIDTxb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.customerIDTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerIDTxb.Location = new System.Drawing.Point(618, 55);
            this.customerIDTxb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customerIDTxb.Name = "customerIDTxb";
            this.customerIDTxb.PasswordChar = '\0';
            this.customerIDTxb.PlaceholderText = "";
            this.customerIDTxb.SelectedText = "";
            this.customerIDTxb.Size = new System.Drawing.Size(370, 46);
            this.customerIDTxb.TabIndex = 28;
            // 
            // searchByCustomerIDBtn
            // 
            this.searchByCustomerIDBtn.BorderRadius = 5;
            this.searchByCustomerIDBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchByCustomerIDBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchByCustomerIDBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchByCustomerIDBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchByCustomerIDBtn.FillColor = System.Drawing.Color.DeepPink;
            this.searchByCustomerIDBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchByCustomerIDBtn.ForeColor = System.Drawing.Color.White;
            this.searchByCustomerIDBtn.Location = new System.Drawing.Point(1033, 55);
            this.searchByCustomerIDBtn.Name = "searchByCustomerIDBtn";
            this.searchByCustomerIDBtn.Size = new System.Drawing.Size(98, 46);
            this.searchByCustomerIDBtn.TabIndex = 27;
            this.searchByCustomerIDBtn.Text = "Tra cứu";
            this.searchByCustomerIDBtn.Click += new System.EventHandler(this.searchByCustomerIDBtn_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(618, 19);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(322, 27);
            this.guna2HtmlLabel1.TabIndex = 26;
            this.guna2HtmlLabel1.Text = "Nhập mã khách hàng để tìm kiếm";
            // 
            // invoiceIDTxb
            // 
            this.invoiceIDTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.invoiceIDTxb.DefaultText = "";
            this.invoiceIDTxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.invoiceIDTxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.invoiceIDTxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.invoiceIDTxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.invoiceIDTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.invoiceIDTxb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.invoiceIDTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.invoiceIDTxb.Location = new System.Drawing.Point(22, 55);
            this.invoiceIDTxb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.invoiceIDTxb.Name = "invoiceIDTxb";
            this.invoiceIDTxb.PasswordChar = '\0';
            this.invoiceIDTxb.PlaceholderText = "";
            this.invoiceIDTxb.SelectedText = "";
            this.invoiceIDTxb.Size = new System.Drawing.Size(370, 46);
            this.invoiceIDTxb.TabIndex = 25;
            // 
            // searchByInvoiceIDBtn
            // 
            this.searchByInvoiceIDBtn.BorderRadius = 5;
            this.searchByInvoiceIDBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchByInvoiceIDBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchByInvoiceIDBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchByInvoiceIDBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchByInvoiceIDBtn.FillColor = System.Drawing.Color.DeepPink;
            this.searchByInvoiceIDBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchByInvoiceIDBtn.ForeColor = System.Drawing.Color.White;
            this.searchByInvoiceIDBtn.Location = new System.Drawing.Point(429, 55);
            this.searchByInvoiceIDBtn.Name = "searchByInvoiceIDBtn";
            this.searchByInvoiceIDBtn.Size = new System.Drawing.Size(98, 46);
            this.searchByInvoiceIDBtn.TabIndex = 24;
            this.searchByInvoiceIDBtn.Text = "Tra cứu";
            this.searchByInvoiceIDBtn.Click += new System.EventHandler(this.searchByInvoiceIDBtn_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(22, 19);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(288, 27);
            this.guna2HtmlLabel2.TabIndex = 23;
            this.guna2HtmlLabel2.Text = "Nhập mã hóa đơn để tìm kiếm";
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
            this.loadBtn.Location = new System.Drawing.Point(917, 156);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(214, 48);
            this.loadBtn.TabIndex = 20;
            this.loadBtn.Text = "Lấy danh sách hóa đơn";
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // LeTan_Invoice_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.invoicePanel);
            this.Name = "LeTan_Invoice_Search";
            this.Size = new System.Drawing.Size(1219, 923);
            this.invoicePanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.listInvoicesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listInvoicesDataGridView)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel HomeLabel;
        private Guna.UI2.WinForms.Guna2Panel invoicePanel;
        private Guna.UI2.WinForms.Guna2Panel listInvoicesPanel;
        private Guna.UI2.WinForms.Guna2DataGridView listInvoicesDataGridView;
        private System.Windows.Forms.Panel searchPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox invoiceIDTxb;
        private Guna.UI2.WinForms.Guna2Button searchByInvoiceIDBtn;
        private Guna.UI2.WinForms.Guna2TextBox customerIDTxb;
        private Guna.UI2.WinForms.Guna2Button searchByCustomerIDBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button searchByInvoiceDateBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2DateTimePicker invoiceDatePicker;
        private Guna.UI2.WinForms.Guna2Panel controlPanel;
        private Guna.UI2.WinForms.Guna2Button showDetailBtn;
        private Guna.UI2.WinForms.Guna2Button returnBtn;
        private Guna.UI2.WinForms.Guna2Button loadBtn;
    }
}
