using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace DnsFromPpk.Converter
{
    class ConverterForImage: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int val = int.Parse(value.ToString());
            if (val < 200)
                return "/1.jpg";
            else if (val < 1500)
                return "/hot.jpg";
            else if (val < 3000)
                return "/hot2.jpg";
            else
                return "/hot3.jpg";

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
