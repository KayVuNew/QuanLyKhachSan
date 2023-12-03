
namespace QLKS
{
    partial class FromDoanhThu
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
            this.btnDatPhong = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dvDoanhthu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvDoanhthu)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDatPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDatPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDatPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDatPhong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnDatPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDatPhong.ForeColor = System.Drawing.Color.White;
            this.btnDatPhong.Location = new System.Drawing.Point(399, 473);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(142, 45);
            this.btnDatPhong.TabIndex = 80;
            this.btnDatPhong.Text = "Xuất excel";
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // dvDoanhthu
            // 
            this.dvDoanhthu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvDoanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvDoanhthu.Location = new System.Drawing.Point(33, -6);
            this.dvDoanhthu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvDoanhthu.Name = "dvDoanhthu";
            this.dvDoanhthu.RowHeadersWidth = 62;
            this.dvDoanhthu.RowTemplate.Height = 28;
            this.dvDoanhthu.Size = new System.Drawing.Size(854, 447);
            this.dvDoanhthu.TabIndex = 78;
            // 
            // FromDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(914, 555);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.dvDoanhthu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FromDoanhThu";
            this.Text = "FromDoanhThu";
            this.Load += new System.EventHandler(this.FromDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvDoanhthu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnDatPhong;
        private System.Windows.Forms.DataGridView dvDoanhthu;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}