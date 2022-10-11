using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TT.ASC.MNG.TT.ASC.DATA;

namespace TT.ASC.MNG.TT.ASC.APP
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }
        //đọc
        private void btn_doc_Click(object sender, EventArgs e)
        {
            if (XuLyBai3.KTraChuaNhap(txt_SoTien.Text))
            {
                string s = "";
                s = XuLyBai3.DocTien(double.Parse(txt_SoTien.Text));
                lb_KetQua.Text = s;
            }
            else
            {
                return;
            }
        }

        private void Bai3_Load(object sender, EventArgs e)
        {
            txt_SoTien.Text = "0";
        }
    }
}
