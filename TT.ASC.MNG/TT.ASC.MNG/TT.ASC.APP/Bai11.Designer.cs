namespace TT.ASC.MNG.TT.ASC.APP
{
    partial class Bai11
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NhapHoTen = new System.Windows.Forms.TextBox();
            this.lb_KetQua = new System.Windows.Forms.Label();
            this.btn_Tach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập họ tên:";
            // 
            // txt_NhapHoTen
            // 
            this.txt_NhapHoTen.Location = new System.Drawing.Point(188, 44);
            this.txt_NhapHoTen.Name = "txt_NhapHoTen";
            this.txt_NhapHoTen.Size = new System.Drawing.Size(550, 22);
            this.txt_NhapHoTen.TabIndex = 1;
            // 
            // lb_KetQua
            // 
            this.lb_KetQua.AutoSize = true;
            this.lb_KetQua.Location = new System.Drawing.Point(185, 85);
            this.lb_KetQua.Name = "lb_KetQua";
            this.lb_KetQua.Size = new System.Drawing.Size(52, 16);
            this.lb_KetQua.TabIndex = 2;
            this.lb_KetQua.Text = "Kết quả";
            // 
            // btn_Tach
            // 
            this.btn_Tach.Location = new System.Drawing.Point(73, 78);
            this.btn_Tach.Name = "btn_Tach";
            this.btn_Tach.Size = new System.Drawing.Size(75, 23);
            this.btn_Tach.TabIndex = 6;
            this.btn_Tach.Text = "Tách";
            this.btn_Tach.UseVisualStyleBackColor = true;
            this.btn_Tach.Click += new System.EventHandler(this.btn_Tach_Click);
            // 
            // Bai11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 141);
            this.Controls.Add(this.btn_Tach);
            this.Controls.Add(this.lb_KetQua);
            this.Controls.Add(this.txt_NhapHoTen);
            this.Controls.Add(this.label1);
            this.Name = "Bai11";
            this.Text = "Hàm cắt chuỗi họ tên ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NhapHoTen;
        private System.Windows.Forms.Label lb_KetQua;
        private System.Windows.Forms.Button btn_Tach;
    }
}