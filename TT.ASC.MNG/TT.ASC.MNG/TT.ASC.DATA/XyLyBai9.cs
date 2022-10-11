using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TT.ASC.MNG.TT.ASC.DATA
{
    internal static class XyLyBai9
    {
        #region Kiểm tra chưa nhập
        public static bool isChuaNhap(string Chuoi)
        {
            if (Chuoi.Length == 0)
            {
                MessageBox.Show("Nhập chuổi không được để trống", "Thông Báo");
                return false;
            }
            return true;
        }
        #endregion

        #region Đếm khoảng trắng
        public static int DemKhoangTrang(string Chuoi)
        {
            int dem = 0;
            string s;
            for(int i=0;i<Chuoi.Length;i++)
            {
                s = Chuoi.Substring(i,1);//lấy ký tự vi trí i số lượng 1
                if(s==" ")//khoảng trắng
                {
                    dem++;
                }    
            }
            return dem;
        }
        #endregion

    }
}
