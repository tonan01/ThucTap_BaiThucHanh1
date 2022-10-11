using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TT.ASC.MNG.TT.ASC.DATA
{
    internal static class XyLyBai12
    {
        #region Kiểm tra chưa nhập Round tùy ý
        public static bool isChuaNhapRoundTuyY(double SoThapPhan,int SoLuongLamTron)
        {
            if (SoThapPhan.ToString().Length == 0)
            {
                MessageBox.Show("Nhập số thập phân không được để trống", "Thông Báo");
                return false;
            }
            if (SoLuongLamTron.ToString().Length == 0)
            {
                MessageBox.Show("Số lượng làm tròn không được để trống", "Thông Báo");
                return false;
            }
            if (SoLuongLamTron <= 0)
            {
                MessageBox.Show("Số lượng làm tròn phải lơn hơn 0", "Thông Báo");
                return false;
            }
            return true;
        }
        #endregion

        #region Kiểm tra chưa nhập
        public static bool isChuaNhap(double SoThapPhan)
        {
            if (SoThapPhan.ToString().Length == 0)
            {
                MessageBox.Show("Nhập số thập phân không được để trống", "Thông Báo");
                return false;
            }
            return true;
        }
        #endregion

        //Hàm làm tròn xuống
        #region Làm tròn Floor
        public static double LamTronFloor(double SoThapPhan)
        {
           double LTFloor= Math.Floor(SoThapPhan);
            return LTFloor;
        }
        #endregion

        //Làm tròn lên hoặc xuống về phía không.
        #region Làm tròn Truncate
        public static double LamTronTruncate(double SoThapPhan)
        {
            double LTTruncate = Math.Truncate(SoThapPhan);
            return LTTruncate;
        }
        #endregion

        //Làm tròn có thể chỉnh số lượng làm tròn
        #region Làm tròn Round tùy ý
        public static double LamTronRoundTuyY(double SoThapPhan, int SoLuongLamTron)
        {
            double LTRoundTuyY = Math.Round(SoThapPhan,SoLuongLamTron);
            return LTRoundTuyY;
        }
        #endregion

        //Làm tròn mặc định  các số từ 0,1,2,3,4,5 sẽ làm tròn về 0 và số 6,7,8,9 làm tròn về 1
        #region Làm tròn Round 
        public static double LamTronRound(double SoThapPhan)
        {
            double LTRound = Math.Round(SoThapPhan);
            return LTRound;
        }
        #endregion

        //Làm tròn lên 
        #region Làm tròn Ceiling tùy ý
        public static double LamTronCeiling(double SoThapPhan)
        {
            double LTCeiling = Math.Ceiling(SoThapPhan);
            return LTCeiling;
        }
        #endregion
    }
}
