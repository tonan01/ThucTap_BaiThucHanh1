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
    public partial class Bai12 : Form
    {
        public Bai12()
        {
            InitializeComponent();
        }
        //Floor
        private void btn_LamTronFloor_Click(object sender, EventArgs e)
        {
            if(XyLyBai12.isChuaNhap(double.Parse(txt_NhapSoThapPhan_Floor.Text)))
            {
                lb_KetQuaFloor.Text= XyLyBai12.LamTronFloor(double.Parse(txt_NhapSoThapPhan_Floor.Text)).ToString();
            } 
            else
            {
                return;
            }    
        }
        //Truncate
        private void btn_LamTronTruncate_Click(object sender, EventArgs e)
        {
            if (XyLyBai12.isChuaNhap(double.Parse(txt_NhapSoThapPhanTruncate.Text)))
            {
                lb_KetQuaTruncate.Text = XyLyBai12.LamTronTruncate(double.Parse(txt_NhapSoThapPhanTruncate.Text)).ToString();
            }
            else
            {
                return;
            }
        }
        //Ceiling
        private void btn_LamTronCeiling_Click(object sender, EventArgs e)
        {
            if (XyLyBai12.isChuaNhap(double.Parse(txt_NhapSoThapPhanCiling.Text)))
            {
                lb_KetQuaCeiling.Text = XyLyBai12.LamTronCeiling(double.Parse(txt_NhapSoThapPhanCiling.Text)).ToString();
            }
            else
            {
                return;
            }
        }
        //Round mặc định
        private void btn_LamTronRound_Click(object sender, EventArgs e)
        {
            if (XyLyBai12.isChuaNhap(double.Parse(txt_NhapSoThapPhanRound.Text)))
            {
                lb_KetQuaRound.Text = XyLyBai12.LamTronRound(double.Parse(txt_NhapSoThapPhanRound.Text)).ToString();
            }
            else
            {
                return;
            }
        }
        //Round tùy ý
        private void btn_LamTronRoundTuyY_Click(object sender, EventArgs e)
        {
            if (XyLyBai12.isChuaNhapRoundTuyY(double.Parse(txt_NhapSoThapPhanRound.Text),int.Parse(txt_SoLuongLamTronRound.Text)))
            {
                lb_KetQuaRound.Text = XyLyBai12.LamTronRoundTuyY(double.Parse(txt_NhapSoThapPhanRound.Text),int.Parse(txt_SoLuongLamTronRound.Text)).ToString();
            }
            else
            {
                return;
            }
        }
    }
}
