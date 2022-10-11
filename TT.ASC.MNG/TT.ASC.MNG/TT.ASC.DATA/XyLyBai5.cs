using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TT.ASC.MNG.TT.ASC.DATA
{
    internal static class XyLyBai5
    {
        #region Kiểm tra chưa nhập
        public static bool isChuaNhap(string nThang, string nNam)
        {
            if (nThang.Length == 0)
            {
                MessageBox.Show("Ký tự không được để trống", "Thông Báo");
                return false;
            }
            if (nNam.ToString().Length == 0)
            {
                MessageBox.Show("Số lượng không được để trống", "Thông Báo");
                return false;
            }
            if (int.Parse(nThang)<1 || int.Parse(nThang)>12)
            {
                MessageBox.Show("Tháng phải trong khỏa 1-12", "Thông Báo");
                return false;
            }
            return true;
        }
        #endregion

        #region Trả về ngày đầu tiên của tháng
        public static int NgayDauTienCuaThang(int nThang,int nNam)
        {
            DateTime dt = new DateTime(nNam, nThang, 1);
            dt = dt.AddDays((-dt.Day) + 1);//trả về ngày đầu 
            return dt.Day;
        }
        #endregion
    }
}
