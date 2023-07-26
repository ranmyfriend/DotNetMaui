using System;
using System.Globalization;

namespace MVVMDemo.MVVM.Converters
{
	public class BoolConverter: IValueConverter
	{
        //Here we are converting string(Data.Married) to bool value to set into checkbox!
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var answer = value.ToString();
            if(answer == "YES")
            {
                return true;
            }
            return false;
        }

        //Here we are updating this string to Data.Married Property!
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var boolean = (bool)value;
            if(boolean)
            {
                return "YES";
            }
            return "NO";
        }
    }
}

