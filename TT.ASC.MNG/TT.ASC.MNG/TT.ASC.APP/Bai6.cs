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
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void btn_Chon_Click(object sender, EventArgs e)
        {
            if (XyLyBai6.isChuaNhap(txt_Thang.Text, txt_Nam.Text))
            {
                txt_KetQua.Text = XyLyBai6.NgayCuoiCungCuaThang(int.Parse(txt_Thang.Text), int.Parse(txt_Nam.Text)).ToString();
            }
            else
            {
                return;
            }
        }
    }
}
