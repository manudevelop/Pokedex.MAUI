using PokeApiSharp.Models;

namespace PokeApiSharp.Repositories
{
    public class PokemonRepository : BaseRepository
    {
        public async Task<ApiCollection> GetAllAsync(int offset, int limit)
            => await GetAsync<ApiCollection>("pokemon",
                new Dictionary<string, string>() {
                    { "limit", limit.ToString() },
                    { "offset", offset.ToString() }
                });
        public async Task<Pokemon> GetAsync(int id)
            => await GetAsync<Pokemon>("pokemon", null, id.ToString());
        public async Task<Pokemon> GetAsync(string name) 
            => await GetAsync<Pokemon>("pokemon", null, name);
    }
}
