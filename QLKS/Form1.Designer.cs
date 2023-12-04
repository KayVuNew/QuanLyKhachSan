namespace QLKS
{
    partial class Form1
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
            this.label5 = new System.Windows.Forms.Label();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.MaLoaiDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Madv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btxoa = new System.Windows.Forms.Button();
            this.dtgzDV = new System.Windows.Forms.DataGridView();
            this.cmxloaidv = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttdv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgzDV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(311, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "QUẢN LÝ DỊCH VỤ";
            // 
            // btsua
            // 
            this.btsua.BackColor = System.Drawing.Color.Blue;
            this.btsua.Location = new System.Drawing.Point(394, 389);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(97, 46);
            this.btsua.TabIndex = 9;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = false;
            // 
            // btthem
            // 
            this.btthem.BackColor = System.Drawing.Color.LawnGreen;
            this.btthem.Location = new System.Drawing.Point(259, 390);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(97, 46);
            this.btthem.TabIndex = 8;
            this.btthem.Text = "Thêm ";
            this.btthem.UseVisualStyleBackColor = false;
            // 
            // MaLoaiDV
            // 
            this.MaLoaiDV.HeaderText = "Mã Loại Dịch Vụ";
            this.MaLoaiDV.MinimumWidth = 6;
            this.MaLoaiDV.Name = "MaLoaiDV";
            this.MaLoaiDV.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 125;
            // 
            // TenDichVu
            // 
            this.TenDichVu.HeaderText = "Tên Dịch Vụ";
            this.TenDichVu.MinimumWidth = 6;
            this.TenDichVu.Name = "TenDichVu";
            this.TenDichVu.Width = 125;
            // 
            // Madv
            // 
            this.Madv.HeaderText = "Mã dịch vụ";
            this.Madv.MinimumWidth = 6;
            this.Madv.Name = "Madv";
            this.Madv.Width = 125;
            // 
            // btxoa
            // 
            this.btxoa.BackColor = System.Drawing.Color.Red;
            this.btxoa.Location = new System.Drawing.Point(539, 389);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(97, 46);
            this.btxoa.TabIndex = 10;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = false;
            // 
            // dtgzDV
            // 
            this.dtgzDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgzDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Madv,
            this.TenDichVu,
            this.DonGia,
            this.MaLoaiDV});
            this.dtgzDV.Location = new System.Drawing.Point(300, 86);
            this.dtgzDV.Name = "dtgzDV";
            this.dtgzDV.RowHeadersWidth = 51;
            this.dtgzDV.RowTemplate.Height = 24;
            this.dtgzDV.Size = new System.Drawing.Size(473, 273);
            this.dtgzDV.TabIndex = 7;
            // 
            // cmxloaidv
            // 
            this.cmxloaidv.FormattingEnabled = true;
            this.cmxloaidv.Location = new System.Drawing.Point(103, 209);
            this.cmxloaidv.Name = "cmxloaidv";
            this.cmxloaidv.Size = new System.Drawing.Size(121, 24);
            this.cmxloaidv.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Thông tin dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mã loại DV :";
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(103, 158);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(122, 22);
            this.txtdongia.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Đơn giá :";
            // 
            // txttdv
            // 
            this.txttdv.Location = new System.Drawing.Point(103, 106);
            this.txttdv.Name = "txttdv";
            this.txttdv.Size = new System.Drawing.Size(122, 22);
            this.txttdv.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên dịch vụ :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Controls.Add(this.cmxloaidv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtdongia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txttdv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 273);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.dtgzDV);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgzDV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Madv;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.DataGridView dtgzDV;
        private System.Windows.Forms.ComboBox cmxloaidv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttdv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

