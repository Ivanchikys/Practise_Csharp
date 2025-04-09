using System;
using System.Globalization;
using System.Windows.Data;

namespace TeacherJournal
{
    public class LessThanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double average && double.TryParse(parameter.ToString(), out double threshold))
            {
                return average < threshold && average > 0;
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}