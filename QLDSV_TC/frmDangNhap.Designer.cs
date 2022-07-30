
namespace QLDSV_TC
{
    partial class frmDangNhap
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
            this.lbKhoa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.cbxKhoa = new System.Windows.Forms.ComboBox();
            this.lbTaiKhoan = new System.Windows.Forms.Label();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxSinhVien = new System.Windows.Forms.CheckBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbKhoa
            // 
            this.lbKhoa.AutoSize = true;
            this.lbKhoa.Location = new System.Drawing.Point(68, 52);
            this.lbKhoa.Name = "lbKhoa";
            this.lbKhoa.Size = new System.Drawing.Size(39, 17);
            this.lbKhoa.TabIndex = 0;
            this.lbKhoa.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 1;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(155, 94);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(336, 23);
            this.txtTaiKhoan.TabIndex = 2;
            // 
            // cbxKhoa
            // 
            this.cbxKhoa.FormattingEnabled = true;
            this.cbxKhoa.Location = new System.Drawing.Point(155, 49);
            this.cbxKhoa.Name = "cbxKhoa";
            this.cbxKhoa.Size = new System.Drawing.Size(336, 24);
            this.cbxKhoa.TabIndex = 3;
            this.cbxKhoa.SelectedIndexChanged += new System.EventHandler(this.cbxKhoa_SelectedIndexChanged);
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.AutoSize = true;
            this.lbTaiKhoan.Location = new System.Drawing.Point(68, 97);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(67, 17);
            this.lbTaiKhoan.TabIndex = 4;
            this.lbTaiKhoan.Text = "Tài khoản";
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Location = new System.Drawing.Point(68, 140);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(64, 17);
            this.lbMatKhau.TabIndex = 7;
            this.lbMatKhau.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(155, 137);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(336, 23);
            this.txtMatKhau.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 5;
            // 
            // checkBoxSinhVien
            // 
            this.checkBoxSinhVien.AutoSize = true;
            this.checkBoxSinhVien.Location = new System.Drawing.Point(155, 180);
            this.checkBoxSinhVien.Name = "checkBoxSinhVien";
            this.checkBoxSinhVien.Size = new System.Drawing.Size(85, 21);
            this.checkBoxSinhVien.TabIndex = 8;
            this.checkBoxSinhVien.Text = "Sinh Viên";
            this.checkBoxSinhVien.UseVisualStyleBackColor = true;
            this.checkBoxSinhVien.CheckedChanged += new System.EventHandler(this.checkBoxSinhVien_CheckedChanged);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(155, 229);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(96, 42);
            this.btnDangNhap.TabIndex = 9;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(291, 229);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 42);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 322);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.checkBoxSinhVien);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTaiKhoan);
            this.Controls.Add(this.cbxKhoa);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbKhoa);
            this.Name = "frmDangNhap";
            this.Text = "frmDangNhap";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.ComboBox cbxKhoa;
        private System.Windows.Forms.Label lbTaiKhoan;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxSinhVien;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
    }
}