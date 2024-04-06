using PokeApiSharp.Models;
using System.Globalization;

namespace Pokedex.MAUI.Converters
{
    public class PokemonTypeJoinConvert : IValueConverter
    {
        public object? Convert(object? value, System.Type targetType, object? parameter, CultureInfo culture)
        {
            var aux = value as IEnumerable<Auxiliar.Lang>;
            return string.Join("/", aux.Select(p => p.name));
        }

        public object? ConvertBack(object? value, System.Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
