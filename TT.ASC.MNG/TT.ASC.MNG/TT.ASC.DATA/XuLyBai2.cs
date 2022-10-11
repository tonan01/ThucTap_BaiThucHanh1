using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TT.ASC.MNG.TT.ASC.DATA
{
    internal static class XuLyBai2
    {
        #region Kiểm tra chưa nhập
        public static bool KTraChuaNhap(string DaySo)
        {
            if (DaySo.Length == 0)
            {
                MessageBox.Show("Chưa nhập số", "Thông Báo");
                return false;
            }
            return true;
        }
        #endregion

        #region Đọc số
        public static string DocSo(double DaySo, bool suffix = true)
        {
            //nếu là số không
            if (DaySo == 0)
            {
                return "Không";
            }
            string[] unitNumbers = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] placeValues = new string[] { "", "nghìn", "triệu", "tỷ" };
            // false số dương
            bool isNegative = false;

            // Chuyển đổi số thập phân thành số nguyên và đổi thành string ví dụ là 123.123 => "123"
            string sNumber = DaySo.ToString("#");
            //ép kiểu
            double number = Convert.ToDouble(sNumber);
            //Nếu là số am
            if (number < 0)
            {
                number = -number;
                sNumber = number.ToString();
                //true là số âm
                isNegative = true;
            }


            int ones, tens, hundreds;
            //vị trí
            int positionDigit = sNumber.Length;   // last -> first

            string result = " ";


            if (positionDigit == 0)
            {
                result = unitNumbers[0] + result;
            }
            else
            {
                // 0:      
                // 1: nghìn 
                // 2: triệu 
                // 3: tỷ    
                int placeValue = 0;

                while (positionDigit > 0)
                {
                    //kiểm tra trăm chục và 1 đơn vị
                    tens = hundreds = -1;
                    //Đơn vị
                    ones = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                    positionDigit--;
                    if (positionDigit > 0)
                    {
                        //Chục
                        tens = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                        positionDigit--;
                        if (positionDigit > 0)
                        {
                            //Trăm
                            hundreds = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                            positionDigit--;
                        }
                    }
                    //Thêm đơn vị "nghìn", "triệu", "tỷ"
                    if ((ones > 0) || (tens > 0) || (hundreds > 0) || (placeValue == 3))
                    {
                        result = placeValues[placeValue] + result;
                    }

                    placeValue++;//qua mỗi vòng sẽ tăng lên để lên 0: "", 1: "nghìn", 2:"triệu", 3:"tỷ"
                    if (placeValue > 3) //Vượt qua tỷ nó sẽ trở lại nghìn và tiếp tục tăng lên
                    { 
                        placeValue = 1; 
                    }
                    //Đọc các số đơn vị 
                    if ((ones == 1) && (tens > 1)) //Đọc số 1 khi có hàng chục > 1 vì 1 dọc là mười
                        result = "mốt " + result;
                    else
                    {
                        if ((ones == 5) && (tens > 0))//Đọc số 5 khi có hàng chục >0 vì 0 là 05 or 105 đọc là năm
                            result = "lăm " + result;
                        else if (ones > 0)//Đọc đơn vị bình thường
                            result = unitNumbers[ones] + " " + result;
                    }
                    //Đọc Hàng chục 
                    if (tens < 0)//không có hàng chục
                    {
                        break;
                    }
                    else//Có hàng chục
                    {
                        if ((tens == 0) && (ones > 0)) result = "lẻ " + result; //Hàng chục = 0
                        if (tens == 1) result = "mười " + result; //Hàng chục là 1
                        if (tens > 1) result = unitNumbers[tens] + " mươi " + result; //Hàng chục >1
                    }
                    //Đọc hàng trăm
                    if (hundreds < 0)//không có hàng trăm
                    {
                        break;
                    }
                    else//Có hàng trăm
                    {
                        if ((hundreds > 0) || (tens > 0) || (ones > 0))
                            result = unitNumbers[hundreds] + " trăm " + result;
                    }
                    result = " " + result;
                }
            }
            //Loại bỏ khoảng trắng
            result = result.Trim();
            //nếu số âm
            if (isNegative)
            {
                //Thêm Trừ phía trước
                result = "Trừ " + result;
            }
            return result;

        }
        #endregion
    }
}
