using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TT.ASC.MNG.TT.ASC.DATA
{
    internal static class XyLyBai13
    {
        #region Kiểm tra chưa nhập
        public static bool isChuaNhap(string HoTen)
        {
            if (HoTen.Length == 0)
            {
                MessageBox.Show("Chuỗi không được để trống", "Thông Báo");
                return false;
            }
            return true;
        }
        #endregion
        #region Viết hoa chữ cái đầu tiên
        public static string VietHoaChuCaiDau(string Chuoi)
        {
            string str = "";
            //Chuyển chuỗi thành mảng
            List<string> listVietHoa = Chuoi.Split(' ').ToList();
            for (int i = 0; i < listVietHoa.Count; i++)
            {
                string s=listVietHoa[i];
                if(s.Length>0)
                {
                    //Viết hoa chữ cái đầu tiên và chữ cái phía sau viết thường
                    listVietHoa[i] = s.Substring(0, 1).ToUpper() + s.Substring(1).ToLower();
                }    
            }
            //Chuyển mảng thành chuổi
            str=String.Join(" ", listVietHoa);
            return str;
        }
        #endregion
    }
}
