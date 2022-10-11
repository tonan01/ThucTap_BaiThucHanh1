namespace TT.ASC.MNG.TT.ASC.APP
{
    partial class Bai10
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
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.btn_KiemTra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(240, 80);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(286, 22);
            this.txt_Email.TabIndex = 1;
            // 
            // btn_KiemTra
            // 
            this.btn_KiemTra.Location = new System.Drawing.Point(330, 126);
            this.btn_KiemTra.Name = "btn_KiemTra";
            this.btn_KiemTra.Size = new System.Drawing.Size(75, 23);
            this.btn_KiemTra.TabIndex = 2;
            this.btn_KiemTra.Text = "Kiểm tra";
            this.btn_KiemTra.UseVisualStyleBackColor = true;
            this.btn_KiemTra.Click += new System.EventHandler(this.btn_KiemTra_Click);
            // 
            // Bai10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 206);
            this.Controls.Add(this.btn_KiemTra);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label1);
            this.Name = "Bai10";
            this.Text = "Kiểm tra tính đúng đăng của địa chỉ Email";
            this.Load += new System.EventHandler(this.Bai10_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Button btn_KiemTra;
    }
}