namespace TT.ASC.MNG.TT.ASC.APP
{
    partial class Bai4
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
            this.txt_KyTu = new System.Windows.Forms.TextBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_RanDom = new System.Windows.Forms.Button();
            this.txt_KetQua = new System.Windows.Forms.TextBox();
            this.btn_Copy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ký tự random:";
            // 
            // txt_KyTu
            // 
            this.txt_KyTu.Location = new System.Drawing.Point(155, 60);
            this.txt_KyTu.Name = "txt_KyTu";
            this.txt_KyTu.Size = new System.Drawing.Size(194, 22);
            this.txt_KyTu.TabIndex = 1;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(497, 60);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(194, 22);
            this.txt_SoLuong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "số lượng ký tự:";
            // 
            // btn_RanDom
            // 
            this.btn_RanDom.Location = new System.Drawing.Point(56, 147);
            this.btn_RanDom.Name = "btn_RanDom";
            this.btn_RanDom.Size = new System.Drawing.Size(83, 23);
            this.btn_RanDom.TabIndex = 4;
            this.btn_RanDom.Text = "RanDom";
            this.btn_RanDom.UseVisualStyleBackColor = true;
            this.btn_RanDom.Click += new System.EventHandler(this.btn_RanDom_Click);
            // 
            // txt_KetQua
            // 
            this.txt_KetQua.Location = new System.Drawing.Point(155, 148);
            this.txt_KetQua.Name = "txt_KetQua";
            this.txt_KetQua.Size = new System.Drawing.Size(482, 22);
            this.txt_KetQua.TabIndex = 5;
            // 
            // btn_Copy
            // 
            this.btn_Copy.Location = new System.Drawing.Point(643, 148);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(48, 23);
            this.btn_Copy.TabIndex = 6;
            this.btn_Copy.Text = "Copy";
            this.btn_Copy.UseVisualStyleBackColor = true;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 218);
            this.Controls.Add(this.btn_Copy);
            this.Controls.Add(this.txt_KetQua);
            this.Controls.Add(this.btn_RanDom);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_KyTu);
            this.Controls.Add(this.label1);
            this.Name = "Bai4";
            this.Text = "Random ký tự";
            this.Load += new System.EventHandler(this.Bai4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_KyTu;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_RanDom;
        private System.Windows.Forms.TextBox txt_KetQua;
        private System.Windows.Forms.Button btn_Copy;
    }
}