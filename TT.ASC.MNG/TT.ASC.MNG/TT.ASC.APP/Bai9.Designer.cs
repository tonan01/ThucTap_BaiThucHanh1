namespace TT.ASC.MNG.TT.ASC.APP
{
    partial class Bai9
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
            this.txt_Chuoi = new System.Windows.Forms.TextBox();
            this.btn_Dem = new System.Windows.Forms.Button();
            this.txt_SoKhoangTrang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập chuỗi";
            // 
            // txt_Chuoi
            // 
            this.txt_Chuoi.Location = new System.Drawing.Point(237, 69);
            this.txt_Chuoi.Name = "txt_Chuoi";
            this.txt_Chuoi.Size = new System.Drawing.Size(285, 22);
            this.txt_Chuoi.TabIndex = 1;
            // 
            // btn_Dem
            // 
            this.btn_Dem.Location = new System.Drawing.Point(125, 122);
            this.btn_Dem.Name = "btn_Dem";
            this.btn_Dem.Size = new System.Drawing.Size(75, 23);
            this.btn_Dem.TabIndex = 2;
            this.btn_Dem.Text = "Đếm";
            this.btn_Dem.UseVisualStyleBackColor = true;
            this.btn_Dem.Click += new System.EventHandler(this.btn_Dem_Click);
            // 
            // txt_SoKhoangTrang
            // 
            this.txt_SoKhoangTrang.Location = new System.Drawing.Point(347, 123);
            this.txt_SoKhoangTrang.Name = "txt_SoKhoangTrang";
            this.txt_SoKhoangTrang.Size = new System.Drawing.Size(70, 22);
            this.txt_SoKhoangTrang.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số khoảng trắng:";
            // 
            // Bai9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 177);
            this.Controls.Add(this.txt_SoKhoangTrang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Dem);
            this.Controls.Add(this.txt_Chuoi);
            this.Controls.Add(this.label1);
            this.Name = "Bai9";
            this.Text = "Điếm Khoản trắng chuỗi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Chuoi;
        private System.Windows.Forms.Button btn_Dem;
        private System.Windows.Forms.TextBox txt_SoKhoangTrang;
        private System.Windows.Forms.Label label2;
    }
}