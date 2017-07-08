﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrismDemo.Models;
using Xamarin.Forms;

namespace PrismDemo.ValueConverters
{
    public class TodoStatusToIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if ((TodoStatus) value == TodoStatus.Open)
                {
                    return ImageSource.FromResource("PrismDemo.Resources.stateopen.png");
                }
                else if ((TodoStatus) value == TodoStatus.InProgress)
                {
                    return ImageSource.FromResource("PrismDemo.Resources.stateinprogress.png");
                }
                else if ((TodoStatus) value == TodoStatus.Closed)
                {
                    return ImageSource.FromResource("PrismDemo.Resources.stateclosed.png");
                }
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
			return default(TodoStatus);
        }
    }
}
