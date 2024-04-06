namespace PokeApiSharp.Models
{
    public class Pokemon
    {
        public string name { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public int id { get; set; }
        public Auxiliar.BaseNameUrl species { get; set; }
        public PokemonType[] types { get; set; }
        public PokemonSprite sprites { get; set; }
    }
}
