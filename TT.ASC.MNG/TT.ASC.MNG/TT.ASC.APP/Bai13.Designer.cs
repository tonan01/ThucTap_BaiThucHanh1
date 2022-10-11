namespace TT.ASC.MNG.TT.ASC.APP
{
    partial class Bai13
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
            this.btn_VietHoa = new System.Windows.Forms.Button();
            this.lb_KetQua = new System.Windows.Forms.Label();
            this.txt_NhapChuoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_VietHoa
            // 
            this.btn_VietHoa.Location = new System.Drawing.Point(55, 72);
            this.btn_VietHoa.Name = "btn_VietHoa";
            this.btn_VietHoa.Size = new System.Drawing.Size(75, 23);
            this.btn_VietHoa.TabIndex = 10;
            this.btn_VietHoa.Text = "Viết Hoa";
            this.btn_VietHoa.UseVisualStyleBackColor = true;
            this.btn_VietHoa.Click += new System.EventHandler(this.btn_VietHoa_Click);
            // 
            // lb_KetQua
            // 
            this.lb_KetQua.AutoSize = true;
            this.lb_KetQua.Location = new System.Drawing.Point(167, 79);
            this.lb_KetQua.Name = "lb_KetQua";
            this.lb_KetQua.Size = new System.Drawing.Size(52, 16);
            this.lb_KetQua.TabIndex = 9;
            this.lb_KetQua.Text = "Kết quả";
            // 
            // txt_NhapChuoi
            // 
            this.txt_NhapChuoi.Location = new System.Drawing.Point(170, 38);
            this.txt_NhapChuoi.Name = "txt_NhapChuoi";
            this.txt_NhapChuoi.Size = new System.Drawing.Size(550, 22);
            this.txt_NhapChuoi.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhập Chuỗi:";
            // 
            // Bai13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 141);
            this.Controls.Add(this.btn_VietHoa);
            this.Controls.Add(this.lb_KetQua);
            this.Controls.Add(this.txt_NhapChuoi);
            this.Controls.Add(this.label1);
            this.Name = "Bai13";
            this.Text = "Viết hoa chữ cái đầu tiên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_VietHoa;
        private System.Windows.Forms.Label lb_KetQua;
        private System.Windows.Forms.TextBox txt_NhapChuoi;
        private System.Windows.Forms.Label label1;
    }
}