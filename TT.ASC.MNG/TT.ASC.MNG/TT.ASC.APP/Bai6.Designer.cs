namespace TT.ASC.MNG.TT.ASC.APP
{
    partial class Bai6
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_KetQua = new System.Windows.Forms.TextBox();
            this.btn_Chon = new System.Windows.Forms.Button();
            this.txt_Nam = new System.Windows.Forms.TextBox();
            this.lb_nam = new System.Windows.Forms.Label();
            this.txt_Thang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kết quả ngày:";
            // 
            // txt_KetQua
            // 
            this.txt_KetQua.Location = new System.Drawing.Point(253, 132);
            this.txt_KetQua.Name = "txt_KetQua";
            this.txt_KetQua.Size = new System.Drawing.Size(54, 22);
            this.txt_KetQua.TabIndex = 12;
            // 
            // btn_Chon
            // 
            this.btn_Chon.Location = new System.Drawing.Point(162, 80);
            this.btn_Chon.Name = "btn_Chon";
            this.btn_Chon.Size = new System.Drawing.Size(75, 36);
            this.btn_Chon.TabIndex = 11;
            this.btn_Chon.Text = "Chọn";
            this.btn_Chon.UseVisualStyleBackColor = true;
            this.btn_Chon.Click += new System.EventHandler(this.btn_Chon_Click);
            // 
            // txt_Nam
            // 
            this.txt_Nam.Location = new System.Drawing.Point(448, 38);
            this.txt_Nam.Name = "txt_Nam";
            this.txt_Nam.Size = new System.Drawing.Size(198, 22);
            this.txt_Nam.TabIndex = 10;
            // 
            // lb_nam
            // 
            this.lb_nam.AutoSize = true;
            this.lb_nam.Location = new System.Drawing.Point(391, 44);
            this.lb_nam.Name = "lb_nam";
            this.lb_nam.Size = new System.Drawing.Size(39, 16);
            this.lb_nam.TabIndex = 9;
            this.lb_nam.Text = "Năm:";
            // 
            // txt_Thang
            // 
            this.txt_Thang.Location = new System.Drawing.Point(162, 38);
            this.txt_Thang.Name = "txt_Thang";
            this.txt_Thang.Size = new System.Drawing.Size(198, 22);
            this.txt_Thang.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tháng:";
            // 
            // Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 217);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_KetQua);
            this.Controls.Add(this.btn_Chon);
            this.Controls.Add(this.txt_Nam);
            this.Controls.Add(this.lb_nam);
            this.Controls.Add(this.txt_Thang);
            this.Controls.Add(this.label1);
            this.Name = "Bai6";
            this.Text = "Ngày cuối tháng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_KetQua;
        private System.Windows.Forms.Button btn_Chon;
        private System.Windows.Forms.TextBox txt_Nam;
        private System.Windows.Forms.Label lb_nam;
        private System.Windows.Forms.TextBox txt_Thang;
        private System.Windows.Forms.Label label1;
    }
}