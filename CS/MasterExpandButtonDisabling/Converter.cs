using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Data;
using System.Globalization;
using System.Windows.Media;

namespace MasterExpandButtonDisabling {
    public class Converter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (parameter != null) {
                string param = parameter.ToString();
                if (value is Task && param.Equals("BoolConversion")) {
                    Task rw = (Task)value;
                    return rw.Steps.Count > 0 ? true : false;
                }
            }
            if (value is Task) {
                Task rw = (Task)value;
                return rw.Steps.Count > 0 ? new SolidColorBrush(Colors.DarkBlue) : new SolidColorBrush(Colors.Gray);
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture) {
            return value;
        }
    }
}
