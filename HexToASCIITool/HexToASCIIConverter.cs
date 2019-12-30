using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Data;

namespace HexToASCIITool
{
    public class HexToASCIIConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string str = value as string;

            char[] splitChars = { ' ', ',' };
            string[] strs = str.Split(splitChars);

            string ret = "";
            foreach (var item in strs)
            {
                try
                {
                    if(Regex.IsMatch(item, "^0x[0-9,a-f,A-F]{2}$"))
                    {
                        ret += string.Format("{0:s}", (char)int.Parse(item.Substring(2, 2), NumberStyles.HexNumber));
                    }
                    else if (Regex.IsMatch(item, "^[0-9,a-f,A-F]{2}$"))
                    {
                        ret += string.Format("{0:s}", (char)int.Parse(item, NumberStyles.HexNumber));
                    }
                    else
                    {
                        ret += "*";
                    }
                }
                catch
                {
                    ret += "*";
                }
                ret += " ";
            }

            return ret;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
