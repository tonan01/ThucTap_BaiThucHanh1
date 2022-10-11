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
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }
        //ngày đầu tiên trong tuần
        private void btn_Chon_Click(object sender, EventArgs e)
        {
            int firstDay=0;
            firstDay = XyLyBai7.NgayDauTienCuaTuan(dateTimePicker1.Value);
            txt_KetQua.Text = firstDay.ToString();
        }
    }
}
