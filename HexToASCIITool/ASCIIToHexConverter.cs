using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace HexToASCIITool
{
    public class ASCIIToHexConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string str = value as string;

            char[] chars = str.ToCharArray();
            
            string ret = "";
            foreach (var item in chars)
            {
                try
                {
                    ret += string.Format("0x{0:X02} ", (int)item);
                }
                catch
                {
                    ret += "* ";
                }
            }

            return ret;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
