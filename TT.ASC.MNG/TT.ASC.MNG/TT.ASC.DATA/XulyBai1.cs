using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TT.ASC.MNG.TT.ASC.DATA
{
    public static class  XulyBai1
    {
        #region Kiểm tra chưa nhập
        public static bool KTraChuaNhap(string nNgay, string nThang, string nNam)
        {
            if(nNgay.Length==0)
            {
                MessageBox.Show("Chưa nhập ngày", "Thông Báo");
                return false;
            }
            if (nThang.Length == 0)
            {
                MessageBox.Show("Chưa nhập tháng", "Thông Báo");
                return false;
            }
            if (nNam.Length == 0)
            {
                MessageBox.Show("Chưa nhập Năm", "Thông Báo");
                return false;
            }
            return true;
        }
        #endregion

        //Định dạng
        #region Định dạng ngày tháng năm, giờ phút giây
        public static string DinhDang(DateTime dateTime)
        {
            return String.Format("{0:dd/MM/yyyy HH:mm:ss}", dateTime);
        }
        #endregion

        #region Ngày Tháng Năm tự nhập
        public static string DinhDangNgayThangNam(int nNgay,int nThang,int nNam)
        {
            //chuyển đổi
            DateTime dt =new  DateTime(nNam,nThang,nNgay);
            return DinhDang(dt);
        }
        #endregion

        #region Ngày hiện tại
        public static string ThoiGianHienTai()
        {
            DateTime dt = DateTime.Now;
            return DinhDang(dt);
        }
        #endregion
    }
}
