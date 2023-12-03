
namespace QLKS
{
    partial class FrmHoaDon
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dvThongTin = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpThanhToan = new System.Windows.Forms.DateTimePicker();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.cboHinhThuc = new System.Windows.Forms.ComboBox();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.btnIn = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvThongTin)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // dvThongTin
            // 
            this.dvThongTin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvThongTin.Location = new System.Drawing.Point(38, 30);
            this.dvThongTin.Name = "dvThongTin";
            this.dvThongTin.RowHeadersWidth = 51;
            this.dvThongTin.RowTemplate.Height = 24;
            this.dvThongTin.Size = new System.Drawing.Size(853, 259);
            this.dvThongTin.TabIndex = 18;
            this.dvThongTin.Click += new System.EventHandler(this.dvThongTin_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpThanhToan);
            this.groupBox2.Controls.Add(this.txtGhichu);
            this.groupBox2.Controls.Add(this.cboHinhThuc);
            this.groupBox2.Controls.Add(this.cboPhong);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(58, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(801, 146);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 85;
            this.label5.Text = "Ngày thanh toán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 83;
            this.label3.Text = "Ghi chú:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 83;
            this.label2.Text = "Hình thức:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 83;
            this.label1.Text = "Phòng:";
            // 
            // dtpThanhToan
            // 
            this.dtpThanhToan.CustomFormat = "dd/MM/yyyy";
            this.dtpThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThanhToan.Location = new System.Drawing.Point(581, 69);
            this.dtpThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpThanhToan.Name = "dtpThanhToan";
            this.dtpThanhToan.Size = new System.Drawing.Size(195, 22);
            this.dtpThanhToan.TabIndex = 82;
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(140, 108);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(196, 22);
            this.txtGhichu.TabIndex = 81;
            // 
            // cboHinhThuc
            // 
            this.cboHinhThuc.FormattingEnabled = true;
            this.cboHinhThuc.Items.AddRange(new object[] {
            "Chuyển khoản",
            "Tiền mặt"});
            this.cboHinhThuc.Location = new System.Drawing.Point(140, 71);
            this.cboHinhThuc.Name = "cboHinhThuc";
            this.cboHinhThuc.Size = new System.Drawing.Size(196, 24);
            this.cboHinhThuc.TabIndex = 78;
            // 
            // cboPhong
            // 
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(140, 30);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(196, 24);
            this.cboPhong.TabIndex = 77;
            // 
            // btnIn
            // 
            this.btnIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIn.ForeColor = System.Drawing.Color.White;
            this.btnIn.Location = new System.Drawing.Point(533, 498);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(142, 45);
            this.btnIn.TabIndex = 75;
            this.btnIn.Text = "In";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnThem
            // 
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(273, 498);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(142, 45);
            this.btnThem.TabIndex = 76;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(914, 555);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dvThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHoaDon";
            this.Text = "FrmHoaDon";
            this.Load += new System.EventHandler(this.FrmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvThongTin)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.DataGridView dvThongTin;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2Button btnIn;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.ComboBox cboHinhThuc;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.DateTimePicker dtpThanhToan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}