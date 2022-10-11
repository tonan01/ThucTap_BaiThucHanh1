namespace TT.ASC.MNG.TT.ASC.APP
{
    partial class Bai3
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
            this.lb_KetQua = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_doc = new System.Windows.Forms.Button();
            this.txt_SoTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_KetQua
            // 
            this.lb_KetQua.AutoSize = true;
            this.lb_KetQua.Location = new System.Drawing.Point(332, 129);
            this.lb_KetQua.Name = "lb_KetQua";
            this.lb_KetQua.Size = new System.Drawing.Size(61, 16);
            this.lb_KetQua.TabIndex = 9;
            this.lb_KetQua.Text = "Bấm đọc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kết quả :";
            // 
            // btn_doc
            // 
            this.btn_doc.Location = new System.Drawing.Point(374, 82);
            this.btn_doc.Name = "btn_doc";
            this.btn_doc.Size = new System.Drawing.Size(75, 23);
            this.btn_doc.TabIndex = 7;
            this.btn_doc.Text = "Đọc";
            this.btn_doc.UseVisualStyleBackColor = true;
            this.btn_doc.Click += new System.EventHandler(this.btn_doc_Click);
            // 
            // txt_SoTien
            // 
            this.txt_SoTien.Location = new System.Drawing.Point(271, 34);
            this.txt_SoTien.Name = "txt_SoTien";
            this.txt_SoTien.Size = new System.Drawing.Size(315, 22);
            this.txt_SoTien.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhập số tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "VND";
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 274);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_KetQua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_doc);
            this.Controls.Add(this.txt_SoTien);
            this.Controls.Add(this.label1);
            this.Name = "Bai3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đọc số tiền";
            this.Load += new System.EventHandler(this.Bai3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_KetQua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_doc;
        private System.Windows.Forms.TextBox txt_SoTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}