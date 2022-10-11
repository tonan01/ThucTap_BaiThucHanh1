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
    public partial class Bai10 : Form
    {
        public Bai10()
        {
            InitializeComponent();
        }

        private void btn_KiemTra_Click(object sender, EventArgs e)
        {
            if(XyLyBai10.isChuaNhap(txt_Email.Text))//đã nhập
            {
                if(XyLyBai10.isEmail(txt_Email.Text))//Là email
                {
                    MessageBox.Show("Là Email","Thông báo");
                    return;
                }
                else//Không Phải Email
                {
                    MessageBox.Show("Không phải Email", "Thông báo");
                    return;
                }    
            }   
            else//Chưa nhập
            {
                return;
            }    
        }

        private void Bai10_Load(object sender, EventArgs e)
        {

        }
    }
}
