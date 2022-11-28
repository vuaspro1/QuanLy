namespace QLBH
{
    partial class frmTrangChu
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
            this.btnMuaNguyenVatLieu = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnQuanLyKho = new System.Windows.Forms.Button();
            this.btnQuanLyDoanhThu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMuaNguyenVatLieu
            // 
            this.btnMuaNguyenVatLieu.AutoSize = true;
            this.btnMuaNguyenVatLieu.Location = new System.Drawing.Point(3, 3);
            this.btnMuaNguyenVatLieu.Name = "btnMuaNguyenVatLieu";
            this.btnMuaNguyenVatLieu.Size = new System.Drawing.Size(161, 84);
            this.btnMuaNguyenVatLieu.TabIndex = 0;
            this.btnMuaNguyenVatLieu.Text = "Mua nguyên vật liệu";
            this.btnMuaNguyenVatLieu.UseVisualStyleBackColor = true;
            this.btnMuaNguyenVatLieu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.AutoSize = true;
            this.btnBanHang.Location = new System.Drawing.Point(320, 3);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(161, 84);
            this.btnBanHang.TabIndex = 1;
            this.btnBanHang.Text = "Bán hàng";
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnQuanLyKho
            // 
            this.btnQuanLyKho.AutoSize = true;
            this.btnQuanLyKho.Location = new System.Drawing.Point(3, 172);
            this.btnQuanLyKho.Name = "btnQuanLyKho";
            this.btnQuanLyKho.Size = new System.Drawing.Size(161, 84);
            this.btnQuanLyKho.TabIndex = 2;
            this.btnQuanLyKho.Text = "Quản lý kho";
            this.btnQuanLyKho.UseVisualStyleBackColor = true;
            this.btnQuanLyKho.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnQuanLyDoanhThu
            // 
            this.btnQuanLyDoanhThu.AutoSize = true;
            this.btnQuanLyDoanhThu.Location = new System.Drawing.Point(314, 171);
            this.btnQuanLyDoanhThu.Name = "btnQuanLyDoanhThu";
            this.btnQuanLyDoanhThu.Size = new System.Drawing.Size(161, 84);
            this.btnQuanLyDoanhThu.TabIndex = 3;
            this.btnQuanLyDoanhThu.Text = "Quản lý doanh thu";
            this.btnQuanLyDoanhThu.UseVisualStyleBackColor = true;
            this.btnQuanLyDoanhThu.Click += new System.EventHandler(this.btnQuanLyDoanhThu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMuaNguyenVatLieu);
            this.panel1.Controls.Add(this.btnQuanLyKho);
            this.panel1.Controls.Add(this.btnQuanLyDoanhThu);
            this.panel1.Controls.Add(this.btnBanHang);
            this.panel1.Location = new System.Drawing.Point(172, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 258);
            this.panel1.TabIndex = 4;
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Brown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMuaNguyenVatLieu;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnQuanLyKho;
        private System.Windows.Forms.Button btnQuanLyDoanhThu;
        private System.Windows.Forms.Panel panel1;
    }
}