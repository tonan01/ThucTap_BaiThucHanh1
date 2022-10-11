using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TT.ASC.MNG.TT.ASC.DATA
{
    internal static class XyLyBai10
    {
        #region Kiểm tra chưa nhập
        public static bool isChuaNhap(string nEmail)
        {
            if (nEmail.Length == 0)
            {
                MessageBox.Show("Nhập chuổi không được để trống", "Thông Báo");
                return false;
            }
            return true;
        }
        #endregion

        #region Kiểm tra email
        public static bool isEmail(string email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);//nếu không phải là mail sẽ bị lỗi và chạy xuống catch
                return true;//là email
            }
            catch
            {
               return false;//không la email
            }
        }
        #endregion
    }
}
