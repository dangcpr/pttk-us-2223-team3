
namespace HotelSystem
{
    partial class LeTan_Checkout
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.checkoutPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.controlPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.showInvoiceBtn = new Guna.UI2.WinForms.Guna2Button();
            this.showDriverBtn = new Guna.UI2.WinForms.Guna2Button();
            this.createCheckoutCardBtn = new Guna.UI2.WinForms.Guna2Button();
            this.roomPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.roomDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.HomeLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.reloadBtn = new Guna.UI2.WinForms.Guna2Button();
            this.checkoutPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.roomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // checkoutPanel
            // 
            this.checkoutPanel.Controls.Add(this.reloadBtn);
            this.checkoutPanel.Controls.Add(this.controlPanel);
            this.checkoutPanel.Controls.Add(this.roomPanel);
            this.checkoutPanel.Controls.Add(this.HomeLabel);
            this.checkoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkoutPanel.Location = new System.Drawing.Point(0, 0);
            this.checkoutPanel.Name = "checkoutPanel";
            this.checkoutPanel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.checkoutPanel.Size = new System.Drawing.Size(1219, 923);
            this.checkoutPanel.TabIndex = 2;
            // 
            // controlPanel
            // 
            this.controlPanel.AutoSize = true;
            this.controlPanel.Controls.Add(this.showInvoiceBtn);
            this.controlPanel.Controls.Add(this.showDriverBtn);
            this.controlPanel.Controls.Add(this.createCheckoutCardBtn);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(10, 764);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1209, 159);
            this.controlPanel.TabIndex = 5;
            // 
            // showInvoiceBtn
            // 
            this.showInvoiceBtn.BorderRadius = 5;
            this.showInvoiceBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.showInvoiceBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.showInvoiceBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.showInvoiceBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.showInvoiceBtn.FillColor = System.Drawing.Color.DeepPink;
            this.showInvoiceBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.showInvoiceBtn.ForeColor = System.Drawing.Color.White;
            this.showInvoiceBtn.Location = new System.Drawing.Point(819, 53);
            this.showInvoiceBtn.Name = "showInvoiceBtn";
            this.showInvoiceBtn.Size = new System.Drawing.Size(207, 45);
            this.showInvoiceBtn.TabIndex = 2;
            this.showInvoiceBtn.Text = "Xem phiếu thanh toán";
            this.showInvoiceBtn.Click += new System.EventHandler(this.showInvoiceBtn_Click);
            // 
            // showDriverBtn
            // 
            this.showDriverBtn.BorderRadius = 5;
            this.showDriverBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.showDriverBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.showDriverBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.showDriverBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.showDriverBtn.FillColor = System.Drawing.Color.DeepPink;
            this.showDriverBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.showDriverBtn.ForeColor = System.Drawing.Color.White;
            this.showDriverBtn.Location = new System.Drawing.Point(522, 53);
            this.showDriverBtn.Name = "showDriverBtn";
            this.showDriverBtn.Size = new System.Drawing.Size(205, 45);
            this.showDriverBtn.TabIndex = 1;
            this.showDriverBtn.Text = "Tra cứu danh sách tài xế";
            this.showDriverBtn.Click += new System.EventHandler(this.showDriverBtn_Click);
            // 
            // createCheckoutCardBtn
            // 
            this.createCheckoutCardBtn.BorderRadius = 5;
            this.createCheckoutCardBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createCheckoutCardBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createCheckoutCardBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createCheckoutCardBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createCheckoutCardBtn.FillColor = System.Drawing.Color.DeepPink;
            this.createCheckoutCardBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createCheckoutCardBtn.ForeColor = System.Drawing.Color.White;
            this.createCheckoutCardBtn.Location = new System.Drawing.Point(218, 53);
            this.createCheckoutCardBtn.Name = "createCheckoutCardBtn";
            this.createCheckoutCardBtn.Size = new System.Drawing.Size(208, 45);
            this.createCheckoutCardBtn.TabIndex = 0;
            this.createCheckoutCardBtn.Text = "Lập phiếu checkout";
            this.createCheckoutCardBtn.Click += new System.EventHandler(this.createCheckoutCardBtn_Click);
            // 
            // roomPanel
            // 
            this.roomPanel.Controls.Add(this.roomDataGridView);
            this.roomPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomPanel.Location = new System.Drawing.Point(10, 78);
            this.roomPanel.Name = "roomPanel";
            this.roomPanel.Padding = new System.Windows.Forms.Padding(8);
            this.roomPanel.Size = new System.Drawing.Size(1209, 686);
            this.roomPanel.TabIndex = 3;
            // 
            // roomDataGridView
            // 
            this.roomDataGridView.AllowUserToAddRows = false;
            this.roomDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            this.roomDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.roomDataGridView.ColumnHeadersHeight = 25;
            this.roomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.roomDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roomDataGridView.DefaultCellStyle = dataGridViewCellStyle19;
            this.roomDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.roomDataGridView.Location = new System.Drawing.Point(8, 8);
            this.roomDataGridView.MultiSelect = false;
            this.roomDataGridView.Name = "roomDataGridView";
            this.roomDataGridView.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.roomDataGridView.RowHeadersVisible = false;
            this.roomDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.roomDataGridView.RowTemplate.Height = 24;
            this.roomDataGridView.Size = new System.Drawing.Size(1193, 670);
            this.roomDataGridView.TabIndex = 0;
            this.roomDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.roomDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.roomDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.roomDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.roomDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.roomDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.roomDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.roomDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.roomDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.roomDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.roomDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.roomDataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.roomDataGridView.ThemeStyle.ReadOnly = true;
            this.roomDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.roomDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.roomDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.roomDataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.roomDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.roomDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.HomeLabel.Text = "THÔNG TIN CHECK OUT";
            this.HomeLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reloadBtn
            // 
            this.reloadBtn.BorderRadius = 5;
            this.reloadBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reloadBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reloadBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reloadBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reloadBtn.FillColor = System.Drawing.Color.DeepPink;
            this.reloadBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reloadBtn.ForeColor = System.Drawing.Color.White;
            this.reloadBtn.Location = new System.Drawing.Point(1001, 14);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(110, 45);
            this.reloadBtn.TabIndex = 3;
            this.reloadBtn.Text = "Reload";
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // LeTan_Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.checkoutPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LeTan_Checkout";
            this.Size = new System.Drawing.Size(1219, 923);
            this.Load += new System.EventHandler(this.LeTan_Checkout_Load);
            this.checkoutPanel.ResumeLayout(false);
            this.checkoutPanel.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.roomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel checkoutPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel HomeLabel;
        private Guna.UI2.WinForms.Guna2Panel controlPanel;
        private Guna.UI2.WinForms.Guna2Button createCheckoutCardBtn;
        private Guna.UI2.WinForms.Guna2Panel roomPanel;
        private Guna.UI2.WinForms.Guna2DataGridView roomDataGridView;
        private Guna.UI2.WinForms.Guna2Button showDriverBtn;
        private Guna.UI2.WinForms.Guna2Button showInvoiceBtn;
        private Guna.UI2.WinForms.Guna2Button reloadBtn;
    }
}
