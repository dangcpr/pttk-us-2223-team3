namespace HotelSystem
{
    partial class LeTan_Checkout_Driver
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
            this.driverPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.controlPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.returnBtn = new Guna.UI2.WinForms.Guna2Button();
            this.listDriversPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.driverDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.searchPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.driverIDTxb = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchDriverBtn = new Guna.UI2.WinForms.Guna2Button();
            this.HomeLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.driverPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.listDriversPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverDataGridView)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // driverPanel
            // 
            this.driverPanel.Controls.Add(this.controlPanel);
            this.driverPanel.Controls.Add(this.listDriversPanel);
            this.driverPanel.Controls.Add(this.searchPanel);
            this.driverPanel.Controls.Add(this.HomeLabel);
            this.driverPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driverPanel.Location = new System.Drawing.Point(0, 0);
            this.driverPanel.Name = "driverPanel";
            this.driverPanel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.driverPanel.Size = new System.Drawing.Size(1219, 923);
            this.driverPanel.TabIndex = 3;
            // 
            // controlPanel
            // 
            this.controlPanel.AutoSize = true;
            this.controlPanel.Controls.Add(this.returnBtn);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(10, 809);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1209, 114);
            this.controlPanel.TabIndex = 8;
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
            this.returnBtn.Location = new System.Drawing.Point(489, 37);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(214, 45);
            this.returnBtn.TabIndex = 3;
            this.returnBtn.Text = "Quay lại";
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // listDriversPanel
            // 
            this.listDriversPanel.Controls.Add(this.driverDataGridView);
            this.listDriversPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.listDriversPanel.Location = new System.Drawing.Point(10, 230);
            this.listDriversPanel.Name = "listDriversPanel";
            this.listDriversPanel.Padding = new System.Windows.Forms.Padding(8);
            this.listDriversPanel.Size = new System.Drawing.Size(1209, 579);
            this.listDriversPanel.TabIndex = 7;
            // 
            // driverDataGridView
            // 
            this.driverDataGridView.AllowUserToAddRows = false;
            this.driverDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.driverDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.driverDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.driverDataGridView.ColumnHeadersHeight = 25;
            this.driverDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.driverDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.driverDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driverDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.driverDataGridView.Location = new System.Drawing.Point(8, 8);
            this.driverDataGridView.MultiSelect = false;
            this.driverDataGridView.Name = "driverDataGridView";
            this.driverDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.driverDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.driverDataGridView.RowHeadersVisible = false;
            this.driverDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.driverDataGridView.RowTemplate.Height = 24;
            this.driverDataGridView.Size = new System.Drawing.Size(1193, 563);
            this.driverDataGridView.TabIndex = 0;
            this.driverDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.driverDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.driverDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.driverDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.driverDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.driverDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.driverDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.driverDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.driverDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.driverDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.driverDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.driverDataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.driverDataGridView.ThemeStyle.ReadOnly = true;
            this.driverDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.driverDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.driverDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.driverDataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.driverDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.driverDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.guna2HtmlLabel3);
            this.searchPanel.Controls.Add(this.driverIDTxb);
            this.searchPanel.Controls.Add(this.searchDriverBtn);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel.Location = new System.Drawing.Point(10, 78);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1209, 152);
            this.searchPanel.TabIndex = 4;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(145, 21);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(262, 27);
            this.guna2HtmlLabel3.TabIndex = 19;
            this.guna2HtmlLabel3.Text = "Nhập mã tài xế để tìm kiếm";
            // 
            // driverIDTxb
            // 
            this.driverIDTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.driverIDTxb.DefaultText = "";
            this.driverIDTxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.driverIDTxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.driverIDTxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.driverIDTxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.driverIDTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.driverIDTxb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.driverIDTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.driverIDTxb.Location = new System.Drawing.Point(145, 73);
            this.driverIDTxb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.driverIDTxb.Name = "driverIDTxb";
            this.driverIDTxb.PasswordChar = '\0';
            this.driverIDTxb.PlaceholderText = "";
            this.driverIDTxb.SelectedText = "";
            this.driverIDTxb.Size = new System.Drawing.Size(370, 46);
            this.driverIDTxb.TabIndex = 18;
            // 
            // searchDriverBtn
            // 
            this.searchDriverBtn.BorderRadius = 5;
            this.searchDriverBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchDriverBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchDriverBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchDriverBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchDriverBtn.FillColor = System.Drawing.Color.DeepPink;
            this.searchDriverBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchDriverBtn.ForeColor = System.Drawing.Color.White;
            this.searchDriverBtn.Location = new System.Drawing.Point(647, 73);
            this.searchDriverBtn.Name = "searchDriverBtn";
            this.searchDriverBtn.Size = new System.Drawing.Size(164, 45);
            this.searchDriverBtn.TabIndex = 2;
            this.searchDriverBtn.Text = "Tra cứu";
            this.searchDriverBtn.Click += new System.EventHandler(this.searchDriverBtn_Click);
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
            this.HomeLabel.Text = "THÔNG TIN TÀI XẾ";
            this.HomeLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeTan_Checkout_Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.driverPanel);
            this.Name = "LeTan_Checkout_Driver";
            this.Size = new System.Drawing.Size(1219, 923);
            this.Load += new System.EventHandler(this.LeTan_Checkout_Driver_Load);
            this.driverPanel.ResumeLayout(false);
            this.driverPanel.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.listDriversPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.driverDataGridView)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel driverPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel HomeLabel;
        private Guna.UI2.WinForms.Guna2Panel controlPanel;
        private Guna.UI2.WinForms.Guna2Button returnBtn;
        private Guna.UI2.WinForms.Guna2Panel listDriversPanel;
        private Guna.UI2.WinForms.Guna2DataGridView driverDataGridView;
        private Guna.UI2.WinForms.Guna2Panel searchPanel;
        private Guna.UI2.WinForms.Guna2TextBox driverIDTxb;
        private Guna.UI2.WinForms.Guna2Button searchDriverBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
    }
}
