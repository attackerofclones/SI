﻿using System;
using System.Windows;
using System.Windows.Data;

namespace SIGame.Converters
{
    public sealed class RowHeightConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var starHeight = (double)value > 170 ? 10.0 : 30.0;
            return new GridLength(starHeight, GridUnitType.Star);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
