using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT.ASC.MNG.TT.ASC.APP
{
    internal static class XyLyBai7
    {
        #region Trả về ngày đầu của tuần
        public static int NgayDauTienCuaTuan(DateTime dateTime)
        {
            //Ngày đầu tuần               ví đụ thứ 3 là    -2   +   1 =  -1 giảm lại 1 ngày là thứ 2
            var monday = dateTime.AddDays(-(int)dateTime.DayOfWeek + (int)DayOfWeek.Monday);
            return monday.Day;
        }
        #endregion
    }
}
