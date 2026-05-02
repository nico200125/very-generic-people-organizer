using Avalonia.Data.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizador.Convertidores
{
    internal class CIstring : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is int ci)
            {
                string s = ci.ToString().PadLeft(8, '0');
                // Formato uruguayo: X.XXX.XXX-X
                return $"{s[..1]}.{s[1..4]}.{s[4..7]}-{s[7]}";
            }
            return value;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
