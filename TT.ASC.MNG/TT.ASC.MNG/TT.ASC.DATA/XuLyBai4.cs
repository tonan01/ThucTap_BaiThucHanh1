using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TT.ASC.MNG.TT.ASC.DATA
{
    internal static class XuLyBai4
    {
        #region Kiểm tra chưa nhập
        public static bool isChuaNhap(string KyTu,int SoLuong)
        {
            if (KyTu.Length == 0)
            {
                MessageBox.Show("Ký tự không được để trống", "Thông Báo");
                return false;
            }
            if (SoLuong.ToString().Length == 0)
            {
                MessageBox.Show("Số lượng không được để trống", "Thông Báo");
                return false;
            }
            if(SoLuong <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Thông Báo");
                return false;
            }    
            return true;
        }
        #endregion

        #region RanDom ký tự
        public static string RanDomKyTy(string KyTu,int SoLuong)
        {
            string[] s=new string[SoLuong];
            Random r = new Random();
            //random ký tự
            for(int i=0;i<SoLuong;i++)
            {
                s[i] = KyTu[r.Next(KyTu.Length)].ToString();//lấy ra 1 ký tự bất kỳ trong mảng s
            }
            //chuyển mảng thành chuổi
            string kq = string.Join("", s);
            return kq;
        }
        #endregion
    }
}
