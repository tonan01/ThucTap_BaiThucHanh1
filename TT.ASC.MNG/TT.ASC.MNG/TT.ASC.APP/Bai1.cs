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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }
        //ngày nhập tự truyền vào
        private void btn_DinhDang_Click(object sender, EventArgs e)
        {
            if (XulyBai1.KTraChuaNhap(txt_Ngay.Text, txt_Thang.Text, txt_Nam.Text))//đã nhập đủ
            {
                string dTime = "";
                //lấy ra ngày đa nhập
                dTime = XulyBai1.DinhDangNgayThangNam(int.Parse(txt_Ngay.Text), int.Parse(txt_Thang.Text), int.Parse(txt_Nam.Text));
                txt_KetQuaDinhDang.Text = dTime;
            }
            else//chưa nhập đủ
            {
                return;
            }
        }
        //ngày mặc định
        private void btn_ThoiGianHienTai_Click(object sender, EventArgs e)
        {
            string dTime = "";
            //lấy ngày mặc định trong máy
            dTime = XulyBai1.ThoiGianHienTai();
            txt_KetQuaDinhDang.Text = dTime;
        }
    }
}
