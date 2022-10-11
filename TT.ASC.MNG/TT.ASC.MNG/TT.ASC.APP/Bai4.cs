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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void Bai4_Load(object sender, EventArgs e)
        {
            txt_KyTu.Text = "UVWXYZabcdef";
            txt_SoLuong.Text = "6";
        }
        //random ký tự
        private void btn_RanDom_Click(object sender, EventArgs e)
        {
            if(XuLyBai4.isChuaNhap(txt_KyTu.Text,int.Parse(txt_SoLuong.Text)))//nhập đủ
            {
                string s="";
                s = XuLyBai4.RanDomKyTy(txt_KyTu.Text, int.Parse(txt_SoLuong.Text));
                txt_KetQua.Text = s;
            }
            else//chưa nhập đủ
            {
                return;
            }
        }
        //copy
        private void btn_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txt_KetQua.Text);
        }
    }
}
