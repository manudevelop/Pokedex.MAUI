namespace PokeApiSharp.Repositories
{
    public class PokemonApiRepositories
    {
        public readonly PokemonRepository Pokemons;
        public readonly SpecieRepository Species;
        public readonly TypeRepository Types;

        public PokemonApiRepositories()
        {
            Pokemons = new PokemonRepository();
            Species = new SpecieRepository();
            Types = new TypeRepository();
        }
    }
}
