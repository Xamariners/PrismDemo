using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrismDemo.Models;
using Xamarin.Forms;

namespace PrismDemo.ValueConverters
{
    public class TodoStatusToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if ((TodoStatus)value == TodoStatus.Open)
                {
                    return "Open";
                }
                else if ((TodoStatus)value == TodoStatus.InProgress)
                {
                    return "In Progress";
                }
                else if ((TodoStatus)value == TodoStatus.Closed)
                {
                    return "Closed";
                }
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
			return Enum.Parse(typeof(TodoStatus), ((string)value).Replace(" ", ""));
        }
    }
}
