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
    public partial class Bai11 : Form
    {
        public Bai11()
        {
            InitializeComponent();
        }
        //tách họ tên
        private void btn_Tach_Click(object sender, EventArgs e)
        {
            if(XyLyBai11.isChuaNhap(txt_NhapHoTen.Text))
            {
                lb_KetQua.Text = XyLyBai11.TachHoTen(txt_NhapHoTen.Text);
            }   
            else
            {
                return;
            }    
        }
    }
}
