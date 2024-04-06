using PokeApiSharp.Models;

namespace PokeApiSharp.Repositories
{
    public class TypeRepository : BaseRepository
    {
        public async Task<Models.Type> GetAsync(int id)
            => await GetAsync<Models.Type>("type", null, id.ToString());
        public async Task<Models.Type> GetAsync(string name)
            => await GetAsync<Models.Type>("type", null, name);
    }
}
