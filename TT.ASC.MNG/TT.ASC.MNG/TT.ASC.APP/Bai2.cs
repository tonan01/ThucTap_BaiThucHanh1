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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        //Đọc số
        private void btn_doc_Click(object sender, EventArgs e)
        {
            if(XuLyBai2.KTraChuaNhap(txt_dayso.Text))
            {
                string s = "";
                s = XuLyBai2.DocSo(double.Parse(txt_dayso.Text));
                lb_KetQua.Text = s;
            }
            else
            {
                return;
            }    
        }

        private void Bai2_Load(object sender, EventArgs e)
        {
            txt_dayso.Text = "0";
        }
    }
}
