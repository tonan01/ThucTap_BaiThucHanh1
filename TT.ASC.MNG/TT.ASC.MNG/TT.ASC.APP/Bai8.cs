using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TT.ASC.MNG.TT.ASC.APP
{
    public partial class Bai8 : Form
    {
        public Bai8()
        {
            InitializeComponent();
        }
        //ngày cuối tuần
        private void btn_Chon_Click(object sender, EventArgs e)
        {
            txt_KetQua.Text = XyLyBai8.NgayDCuoiCuaTuan(dateTimePicker1.Value).ToString();
        }
    }
}
