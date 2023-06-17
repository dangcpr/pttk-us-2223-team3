namespace HotelSystem
{
    partial class LeTan_Invoice_Search_Detail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.returnBtn = new Guna.UI2.WinForms.Guna2Button();
            this.controlPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.quitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.listInvoiceDetailsDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.listInvoiceDetailsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.invoiceDetailPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.HomeLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.loadBtn = new Guna.UI2.WinForms.Guna2Button();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listInvoiceDetailsDataGridView)).BeginInit();
            this.listInvoiceDetailsPanel.SuspendLayout();
            this.invoiceDetailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // returnBtn
            // 
            this.returnBtn.BorderRadius = 5;
            this.returnBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.returnBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.returnBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.returnBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.returnBtn.FillColor = System.Drawing.Color.DeepPink;
            this.returnBtn.Font = new System.Drawing.Font("Google Sans", 9F);
            this.returnBtn.ForeColor = System.Drawing.Color.White;
            this.returnBtn.Location = new System.Drawing.Point(356, 48);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(214, 45);
            this.returnBtn.TabIndex = 2;
            this.returnBtn.Text = "Quay lại";
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.quitBtn);
            this.controlPanel.Controls.Add(this.returnBtn);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(10, 784);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1209, 139);
            this.controlPanel.TabIndex = 27;
            // 
            // quitBtn
            // 
            this.quitBtn.BorderRadius = 5;
            this.quitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.quitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.quitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.quitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.quitBtn.FillColor = System.Drawing.Color.DeepPink;
            this.quitBtn.Font = new System.Drawing.Font("Google Sans", 9F);
            this.quitBtn.ForeColor = System.Drawing.Color.White;
            this.quitBtn.Location = new System.Drawing.Point(683, 48);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(214, 45);
            this.quitBtn.TabIndex = 3;
            this.quitBtn.Text = "Thoát";
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // listInvoiceDetailsDataGridView
            // 
            this.listInvoiceDetailsDataGridView.AllowUserToAddRows = false;
            this.listInvoiceDetailsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.listInvoiceDetailsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Google Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listInvoiceDetailsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.listInvoiceDetailsDataGridView.ColumnHeadersHeight = 25;
            this.listInvoiceDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Google Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listInvoiceDetailsDataGridView.DefaultCellStyle = dataGridViewCellStyle15;
            this.listInvoiceDetailsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listInvoiceDetailsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listInvoiceDetailsDataGridView.Location = new System.Drawing.Point(8, 8);
            this.listInvoiceDetailsDataGridView.MultiSelect = false;
            this.listInvoiceDetailsDataGridView.Name = "listInvoiceDetailsDataGridView";
            this.listInvoiceDetailsDataGridView.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Google Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listInvoiceDetailsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.listInvoiceDetailsDataGridView.RowHeadersVisible = false;
            this.listInvoiceDetailsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.listInvoiceDetailsDataGridView.RowTemplate.Height = 24;
            this.listInvoiceDetailsDataGridView.Size = new System.Drawing.Size(1193, 690);
            this.listInvoiceDetailsDataGridView.TabIndex = 20;
            this.listInvoiceDetailsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.listInvoiceDetailsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.listInvoiceDetailsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.listInvoiceDetailsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.listInvoiceDetailsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.listInvoiceDetailsDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.listInvoiceDetailsDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listInvoiceDetailsDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.listInvoiceDetailsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listInvoiceDetailsDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Google Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listInvoiceDetailsDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.listInvoiceDetailsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.listInvoiceDetailsDataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.listInvoiceDetailsDataGridView.ThemeStyle.ReadOnly = true;
            this.listInvoiceDetailsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.listInvoiceDetailsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listInvoiceDetailsDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Google Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listInvoiceDetailsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.listInvoiceDetailsDataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.listInvoiceDetailsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listInvoiceDetailsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // listInvoiceDetailsPanel
            // 
            this.listInvoiceDetailsPanel.Controls.Add(this.listInvoiceDetailsDataGridView);
            this.listInvoiceDetailsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.listInvoiceDetailsPanel.Location = new System.Drawing.Point(10, 78);
            this.listInvoiceDetailsPanel.Name = "listInvoiceDetailsPanel";
            this.listInvoiceDetailsPanel.Padding = new System.Windows.Forms.Padding(8);
            this.listInvoiceDetailsPanel.Size = new System.Drawing.Size(1209, 706);
            this.listInvoiceDetailsPanel.TabIndex = 25;
            // 
            // invoiceDetailPanel
            // 
            this.invoiceDetailPanel.Controls.Add(this.loadBtn);
            this.invoiceDetailPanel.Controls.Add(this.controlPanel);
            this.invoiceDetailPanel.Controls.Add(this.listInvoiceDetailsPanel);
            this.invoiceDetailPanel.Controls.Add(this.HomeLabel);
            this.invoiceDetailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoiceDetailPanel.Location = new System.Drawing.Point(0, 0);
            this.invoiceDetailPanel.Name = "invoiceDetailPanel";
            this.invoiceDetailPanel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.invoiceDetailPanel.Size = new System.Drawing.Size(1219, 923);
            this.invoiceDetailPanel.TabIndex = 6;
            // 
            // HomeLabel
            // 
            this.HomeLabel.AutoSize = false;
            this.HomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.HomeLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HomeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeLabel.Font = new System.Drawing.Font("Google Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.HomeLabel.Location = new System.Drawing.Point(10, 0);
            this.HomeLabel.Margin = new System.Windows.Forms.Padding(4);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(1209, 78);
            this.HomeLabel.TabIndex = 2;
            this.HomeLabel.Text = "CHI TIẾT PHIẾU THANH TOÁN";
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
            this.loadBtn.Font = new System.Drawing.Font("Google Sans", 9F);
            this.loadBtn.ForeColor = System.Drawing.Color.White;
            this.loadBtn.Location = new System.Drawing.Point(991, 15);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(126, 48);
            this.loadBtn.TabIndex = 21;
            this.loadBtn.Text = "Load data";
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // LeTan_Invoice_Search_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.invoiceDetailPanel);
            this.Name = "LeTan_Invoice_Search_Detail";
            this.Size = new System.Drawing.Size(1219, 923);
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listInvoiceDetailsDataGridView)).EndInit();
            this.listInvoiceDetailsPanel.ResumeLayout(false);
            this.invoiceDetailPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button returnBtn;
        private Guna.UI2.WinForms.Guna2Panel controlPanel;
        private Guna.UI2.WinForms.Guna2Button quitBtn;
        private Guna.UI2.WinForms.Guna2DataGridView listInvoiceDetailsDataGridView;
        private Guna.UI2.WinForms.Guna2Panel listInvoiceDetailsPanel;
        private Guna.UI2.WinForms.Guna2Panel invoiceDetailPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel HomeLabel;
        private Guna.UI2.WinForms.Guna2Button loadBtn;
    }
}
