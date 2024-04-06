using Microsoft.Maui.Graphics.Converters;
using PokeApiSharp.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.MAUI.Converters
{
    public class ColorConverter : IValueConverter
    {
        public object? Convert(object? value, System.Type targetType, object? parameter, CultureInfo culture)
        {
            ColorTypeConverter converter = new ColorTypeConverter();
            return (Color)(converter.ConvertFromInvariantString(value.ToString()));
        }

        public object? ConvertBack(object? value, System.Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
