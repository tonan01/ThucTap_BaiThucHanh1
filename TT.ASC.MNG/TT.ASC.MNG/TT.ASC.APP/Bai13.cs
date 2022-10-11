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
    public partial class Bai13 : Form
    {
        public Bai13()
        {
            InitializeComponent();
        }

        private void btn_VietHoa_Click(object sender, EventArgs e)
        {
            if(XyLyBai13.isChuaNhap(txt_NhapChuoi.Text))//Đã nhập
            {
                lb_KetQua.Text = XyLyBai13.VietHoaChuCaiDau(txt_NhapChuoi.Text);
            }   
            else//Chưa nhập
            {
                return;
            }    
        }
    }
}
