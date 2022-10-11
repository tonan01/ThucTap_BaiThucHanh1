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
    public partial class Bai9 : Form
    {
        public Bai9()
        {
            InitializeComponent();
        }
        //đếm
        private void btn_Dem_Click(object sender, EventArgs e)
        {
            if (XyLyBai9.isChuaNhap(txt_Chuoi.Text))
            {
                //Hiện số khoảng trắng
                txt_SoKhoangTrang.Text= XyLyBai9.DemKhoangTrang(txt_Chuoi.Text).ToString();
            }
            else//chưa nhập đủ
            {
                return;
            }  
        }
    }
}
