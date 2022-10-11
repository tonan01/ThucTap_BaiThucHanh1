using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TT.ASC.MNG.TT.ASC.DATA
{
    internal static class XyLyBai11
    {
        #region Kiểm tra chưa nhập
        public static bool isChuaNhap(string HoTen)
        {
            if (HoTen.Length == 0)
            {
                MessageBox.Show("Họ tên không được để trống", "Thông Báo");
                return false;
            }
            return true;
        }
        #endregion

        #region Tách họ tên
        public static string TachHoTen(string HoTen)
        {
            //split tách những ky tự có khoảng trắng
            List<string> lstTen = HoTen.Split(' ').ToList();
            string Ten = lstTen.Last();
            lstTen.RemoveAt(lstTen.Count()-1);//xóa tên khỏi ds
            //chuyển list thành chuỗi
            string HovaTenDem = String.Join(" ", lstTen);
            return "Họ: " + HovaTenDem + "      Tên: " + Ten;
        }
        #endregion
    }
}
