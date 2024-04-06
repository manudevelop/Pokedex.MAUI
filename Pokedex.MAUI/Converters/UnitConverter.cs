using System.Globalization;

namespace Pokedex.MAUI.Converters
{
    public class UnitConverter : IValueConverter
    {
        public object? Convert(object? value, System.Type targetType, object? parameter, CultureInfo culture)
        {
            double x = double.Parse(value.ToString().Replace(".", ","));
            double y = double.Parse(parameter.ToString().Replace(".", ","));
            

            return Math.Round(x * y, 2);
        }

        public object? ConvertBack(object? value, System.Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
