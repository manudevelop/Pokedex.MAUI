using PokeApiSharp.Models;

namespace PokeApiSharp.Repositories
{
    public class SpecieRepository : BaseRepository
    {
        public async Task<Specie> GetAsync(int id)
            => await GetAsync<Specie>("pokemon-species", null, id.ToString());
        public async Task<Specie> GetAsync(string name)
            => await GetAsync<Specie>("pokemon-species", null, name);
    }
}
