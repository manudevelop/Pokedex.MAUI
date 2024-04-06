namespace PokeApiSharp.Models
{
    public class PokemonSprite : PokemonBaseSprite
    {
        public Dictionary<string, PokemonBaseSprite> other { get; set; }
    }
}
