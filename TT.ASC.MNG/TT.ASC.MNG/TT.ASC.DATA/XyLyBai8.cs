using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT.ASC.MNG.TT.ASC.APP
{
    internal static class XyLyBai8
    {
        #region Trả về ngày cuối của tuần
        public static int NgayDCuoiCuaTuan(DateTime dateTime)
        {
            //Ngày cuối của tuần            ví đụ thứ 4 là    -3   +   6 =  3 Tăng thêm 3 ngày là thứ 7
            var sunday = dateTime.AddDays(-(int)dateTime.DayOfWeek + (int)DayOfWeek.Saturday);
            return sunday.Day;
        }
        #endregion
    }
}
