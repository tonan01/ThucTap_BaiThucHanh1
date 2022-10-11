namespace TT.ASC.MNG.TT.ASC.APP
{
    partial class Bai2
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
            this.txt_dayso = new System.Windows.Forms.TextBox();
            this.btn_doc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_KetQua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dãy số:";
            // 
            // txt_dayso
            // 
            this.txt_dayso.Location = new System.Drawing.Point(285, 45);
            this.txt_dayso.Name = "txt_dayso";
            this.txt_dayso.Size = new System.Drawing.Size(315, 22);
            this.txt_dayso.TabIndex = 1;
            // 
            // btn_doc
            // 
            this.btn_doc.Location = new System.Drawing.Point(388, 93);
            this.btn_doc.Name = "btn_doc";
            this.btn_doc.Size = new System.Drawing.Size(75, 23);
            this.btn_doc.TabIndex = 2;
            this.btn_doc.Text = "Đọc";
            this.btn_doc.UseVisualStyleBackColor = true;
            this.btn_doc.Click += new System.EventHandler(this.btn_doc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kết quả :";
            // 
            // lb_KetQua
            // 
            this.lb_KetQua.AutoSize = true;
            this.lb_KetQua.Location = new System.Drawing.Point(346, 140);
            this.lb_KetQua.Name = "lb_KetQua";
            this.lb_KetQua.Size = new System.Drawing.Size(82, 16);
            this.lb_KetQua.TabIndex = 4;
            this.lb_KetQua.Text = "Bấm đọc số ";
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 250);
            this.Controls.Add(this.lb_KetQua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_doc);
            this.Controls.Add(this.txt_dayso);
            this.Controls.Add(this.label1);
            this.Name = "Bai2";
            this.Text = "Đọc dãy số bất kỳ";
            this.Load += new System.EventHandler(this.Bai2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dayso;
        private System.Windows.Forms.Button btn_doc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_KetQua;
    }
}