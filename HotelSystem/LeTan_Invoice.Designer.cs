namespace HotelSystem
{
    partial class LeTan_Invoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.invoicePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.controlPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.confirmBtn = new Guna.UI2.WinForms.Guna2Button();
            this.returnBtn = new Guna.UI2.WinForms.Guna2Button();
            this.invoiceContentPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.invoiceDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.invoiceDetailDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.roomIDTxb = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.HomeLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.invoicePanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.invoiceContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // invoicePanel
            // 
            this.invoicePanel.Controls.Add(this.controlPanel);
            this.invoicePanel.Controls.Add(this.invoiceContentPanel);
            this.invoicePanel.Controls.Add(this.HomeLabel);
            this.invoicePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoicePanel.Location = new System.Drawing.Point(0, 0);
            this.invoicePanel.Name = "invoicePanel";
            this.invoicePanel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.invoicePanel.Size = new System.Drawing.Size(1219, 923);
            this.invoicePanel.TabIndex = 4;
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.confirmBtn);
            this.controlPanel.Controls.Add(this.returnBtn);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.Location = new System.Drawing.Point(10, 783);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1209, 140);
            this.controlPanel.TabIndex = 16;
            // 
            // confirmBtn
            // 
            this.confirmBtn.BorderRadius = 5;
            this.confirmBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.confirmBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.confirmBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.confirmBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.confirmBtn.FillColor = System.Drawing.Color.DeepPink;
            this.confirmBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.confirmBtn.ForeColor = System.Drawing.Color.White;
            this.confirmBtn.Location = new System.Drawing.Point(692, 21);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(214, 45);
            this.confirmBtn.TabIndex = 3;
            this.confirmBtn.Text = "Hoàn thành";
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
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
            this.returnBtn.Location = new System.Drawing.Point(372, 21);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(214, 45);
            this.returnBtn.TabIndex = 2;
            this.returnBtn.Text = "Quay lại";
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // invoiceContentPanel
            // 
            this.invoiceContentPanel.AutoSize = true;
            this.invoiceContentPanel.Controls.Add(this.guna2HtmlLabel2);
            this.invoiceContentPanel.Controls.Add(this.guna2HtmlLabel1);
            this.invoiceContentPanel.Controls.Add(this.invoiceDataGridView);
            this.invoiceContentPanel.Controls.Add(this.invoiceDetailDataGridView);
            this.invoiceContentPanel.Controls.Add(this.roomIDTxb);
            this.invoiceContentPanel.Controls.Add(this.guna2HtmlLabel4);
            this.invoiceContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoiceContentPanel.Location = new System.Drawing.Point(10, 78);
            this.invoiceContentPanel.Name = "invoiceContentPanel";
            this.invoiceContentPanel.Size = new System.Drawing.Size(1209, 845);
            this.invoiceContentPanel.TabIndex = 5;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(36, 563);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(106, 27);
            this.guna2HtmlLabel2.TabIndex = 23;
            this.guna2HtmlLabel2.Text = "Tổng cộng";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(36, 93);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(155, 27);
            this.guna2HtmlLabel1.TabIndex = 22;
            this.guna2HtmlLabel1.Text = "Chi tiết hóa đơn";
            // 
            // invoiceDataGridView
            // 
            this.invoiceDataGridView.AllowUserToAddRows = false;
            this.invoiceDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.invoiceDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.invoiceDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.invoiceDataGridView.ColumnHeadersHeight = 25;
            this.invoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.invoiceDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.invoiceDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.invoiceDataGridView.Location = new System.Drawing.Point(3, 607);
            this.invoiceDataGridView.MultiSelect = false;
            this.invoiceDataGridView.Name = "invoiceDataGridView";
            this.invoiceDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.invoiceDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.invoiceDataGridView.RowHeadersVisible = false;
            this.invoiceDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.invoiceDataGridView.RowTemplate.Height = 24;
            this.invoiceDataGridView.Size = new System.Drawing.Size(1193, 74);
            this.invoiceDataGridView.TabIndex = 21;
            this.invoiceDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.invoiceDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.invoiceDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.invoiceDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.invoiceDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.invoiceDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.invoiceDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.invoiceDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.invoiceDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.invoiceDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.invoiceDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.invoiceDataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.invoiceDataGridView.ThemeStyle.ReadOnly = true;
            this.invoiceDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.invoiceDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.invoiceDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.invoiceDataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.invoiceDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.invoiceDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // invoiceDetailDataGridView
            // 
            this.invoiceDetailDataGridView.AllowUserToAddRows = false;
            this.invoiceDetailDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.invoiceDetailDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.invoiceDetailDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.invoiceDetailDataGridView.ColumnHeadersHeight = 25;
            this.invoiceDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.invoiceDetailDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.invoiceDetailDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.invoiceDetailDataGridView.Location = new System.Drawing.Point(8, 139);
            this.invoiceDetailDataGridView.MultiSelect = false;
            this.invoiceDetailDataGridView.Name = "invoiceDetailDataGridView";
            this.invoiceDetailDataGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.invoiceDetailDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.invoiceDetailDataGridView.RowHeadersVisible = false;
            this.invoiceDetailDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.invoiceDetailDataGridView.RowTemplate.Height = 24;
            this.invoiceDetailDataGridView.Size = new System.Drawing.Size(1193, 406);
            this.invoiceDetailDataGridView.TabIndex = 20;
            this.invoiceDetailDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.invoiceDetailDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.invoiceDetailDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.invoiceDetailDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.invoiceDetailDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.invoiceDetailDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.invoiceDetailDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.invoiceDetailDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.invoiceDetailDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.invoiceDetailDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceDetailDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.invoiceDetailDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.invoiceDetailDataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.invoiceDetailDataGridView.ThemeStyle.ReadOnly = true;
            this.invoiceDetailDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.invoiceDetailDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.invoiceDetailDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceDetailDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.invoiceDetailDataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.invoiceDetailDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.invoiceDetailDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // roomIDTxb
            // 
            this.roomIDTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roomIDTxb.DefaultText = "";
            this.roomIDTxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.roomIDTxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.roomIDTxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roomIDTxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roomIDTxb.Enabled = false;
            this.roomIDTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomIDTxb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.roomIDTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomIDTxb.Location = new System.Drawing.Point(441, 27);
            this.roomIDTxb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roomIDTxb.Name = "roomIDTxb";
            this.roomIDTxb.PasswordChar = '\0';
            this.roomIDTxb.PlaceholderText = "";
            this.roomIDTxb.SelectedText = "";
            this.roomIDTxb.Size = new System.Drawing.Size(370, 46);
            this.roomIDTxb.TabIndex = 19;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(36, 37);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(96, 27);
            this.guna2HtmlLabel4.TabIndex = 18;
            this.guna2HtmlLabel4.Text = "Số phòng";
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
            this.HomeLabel.Text = "PHIẾU THANH TOÁN";
            this.HomeLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeTan_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.invoicePanel);
            this.Name = "LeTan_Invoice";
            this.Size = new System.Drawing.Size(1219, 923);
            this.Load += new System.EventHandler(this.LeTan_Invoice_Load);
            this.invoicePanel.ResumeLayout(false);
            this.invoicePanel.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.invoiceContentPanel.ResumeLayout(false);
            this.invoiceContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel invoicePanel;
        private Guna.UI2.WinForms.Guna2Panel controlPanel;
        private Guna.UI2.WinForms.Guna2Button returnBtn;
        private Guna.UI2.WinForms.Guna2Panel invoiceContentPanel;
        private Guna.UI2.WinForms.Guna2DataGridView invoiceDetailDataGridView;
        private Guna.UI2.WinForms.Guna2TextBox roomIDTxb;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel HomeLabel;
        private Guna.UI2.WinForms.Guna2DataGridView invoiceDataGridView;
        private Guna.UI2.WinForms.Guna2Button confirmBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
