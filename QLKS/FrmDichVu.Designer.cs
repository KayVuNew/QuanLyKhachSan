
namespace QLKS
{
    partial class FrmDichVu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btxoa = new Guna.UI2.WinForms.Guna2Button();
            this.btsua = new Guna.UI2.WinForms.Guna2Button();
            this.btthem = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmxloaidv = new System.Windows.Forms.ComboBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txttdv = new System.Windows.Forms.TextBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // btxoa
            // 
            this.btxoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btxoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btxoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btxoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btxoa.FillColor = System.Drawing.Color.Red;
            this.btxoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btxoa.ForeColor = System.Drawing.Color.White;
            this.btxoa.Location = new System.Drawing.Point(648, 496);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(142, 45);
            this.btxoa.TabIndex = 21;
            this.btxoa.Text = "Xóa";
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btsua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btsua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btsua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btsua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btsua.ForeColor = System.Drawing.Color.White;
            this.btsua.Location = new System.Drawing.Point(398, 496);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(142, 45);
            this.btsua.TabIndex = 22;
            this.btsua.Text = "Sửa";
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btthem
            // 
            this.btthem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btthem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btthem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btthem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btthem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btthem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btthem.ForeColor = System.Drawing.Color.White;
            this.btthem.Location = new System.Drawing.Point(138, 496);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(142, 45);
            this.btthem.TabIndex = 23;
            this.btthem.Text = "Thêm";
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmxloaidv);
            this.groupBox1.Controls.Add(this.txtdongia);
            this.groupBox1.Controls.Add(this.txttdv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(57, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 146);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dịch vụ";
            // 
            // cmxloaidv
            // 
            this.cmxloaidv.FormattingEnabled = true;
            this.cmxloaidv.Location = new System.Drawing.Point(582, 37);
            this.cmxloaidv.Name = "cmxloaidv";
            this.cmxloaidv.Size = new System.Drawing.Size(195, 24);
            this.cmxloaidv.TabIndex = 12;
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(194, 90);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(195, 22);
            this.txtdongia.TabIndex = 8;
            // 
            // txttdv
            // 
            this.txttdv.Location = new System.Drawing.Point(194, 41);
            this.txttdv.Name = "txttdv";
            this.txttdv.Size = new System.Drawing.Size(195, 22);
            this.txttdv.TabIndex = 6;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(12, 12);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidth = 51;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(890, 285);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroGrid1.TabIndex = 25;
            this.metroGrid1.Click += new System.EventHandler(this.metroGrid1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Loại dịch vụ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tên dịch vụ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Đơn giá:";
            // 
            // FrmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(914, 555);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDichVu";
            this.Text = "FrmDichVu";
            this.Load += new System.EventHandler(this.FrmDichVu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btxoa;
        private Guna.UI2.WinForms.Guna2Button btsua;
        private Guna.UI2.WinForms.Guna2Button btthem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmxloaidv;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txttdv;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}