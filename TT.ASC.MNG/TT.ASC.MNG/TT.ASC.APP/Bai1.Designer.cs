namespace TT.ASC.MNG.TT.ASC.APP
{
    partial class Bai1
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
            this.btn_ThoiGianHienTai = new System.Windows.Forms.Button();
            this.txt_KetQuaDinhDang = new System.Windows.Forms.TextBox();
            this.btn_DinhDang = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Thang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Ngay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_ThoiGianHienTai
            // 
            this.btn_ThoiGianHienTai.Location = new System.Drawing.Point(83, 182);
            this.btn_ThoiGianHienTai.Name = "btn_ThoiGianHienTai";
            this.btn_ThoiGianHienTai.Size = new System.Drawing.Size(157, 27);
            this.btn_ThoiGianHienTai.TabIndex = 17;
            this.btn_ThoiGianHienTai.Text = "Thời Gian Hiện Tại";
            this.btn_ThoiGianHienTai.UseVisualStyleBackColor = true;
            this.btn_ThoiGianHienTai.Click += new System.EventHandler(this.btn_ThoiGianHienTai_Click);
            // 
            // txt_KetQuaDinhDang
            // 
            this.txt_KetQuaDinhDang.Location = new System.Drawing.Point(246, 182);
            this.txt_KetQuaDinhDang.Name = "txt_KetQuaDinhDang";
            this.txt_KetQuaDinhDang.Size = new System.Drawing.Size(307, 22);
            this.txt_KetQuaDinhDang.TabIndex = 16;
            // 
            // btn_DinhDang
            // 
            this.btn_DinhDang.Location = new System.Drawing.Point(361, 133);
            this.btn_DinhDang.Name = "btn_DinhDang";
            this.btn_DinhDang.Size = new System.Drawing.Size(93, 27);
            this.btn_DinhDang.TabIndex = 15;
            this.btn_DinhDang.Text = "Định dạng";
            this.btn_DinhDang.UseVisualStyleBackColor = true;
            this.btn_DinhDang.Click += new System.EventHandler(this.btn_DinhDang_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Năm:";
            // 
            // txt_Nam
            // 
            this.txt_Nam.Location = new System.Drawing.Point(578, 48);
            this.txt_Nam.Name = "txt_Nam";
            this.txt_Nam.Size = new System.Drawing.Size(100, 22);
            this.txt_Nam.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tháng:";
            // 
            // txt_Thang
            // 
            this.txt_Thang.Location = new System.Drawing.Point(361, 48);
            this.txt_Thang.Name = "txt_Thang";
            this.txt_Thang.Size = new System.Drawing.Size(100, 22);
            this.txt_Thang.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ngày:";
            // 
            // txt_Ngay
            // 
            this.txt_Ngay.Location = new System.Drawing.Point(151, 48);
            this.txt_Ngay.Name = "txt_Ngay";
            this.txt_Ngay.Size = new System.Drawing.Size(100, 22);
            this.txt_Ngay.TabIndex = 9;
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ThoiGianHienTai);
            this.Controls.Add(this.txt_KetQuaDinhDang);
            this.Controls.Add(this.btn_DinhDang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Nam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Thang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Ngay);
            this.Name = "Bai1";
            this.Text = "Định dạng ngày giờ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ThoiGianHienTai;
        private System.Windows.Forms.TextBox txt_KetQuaDinhDang;
        private System.Windows.Forms.Button btn_DinhDang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Nam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Thang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Ngay;
    }
}