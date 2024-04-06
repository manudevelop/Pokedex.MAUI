namespace PokeApiSharp.Models
{
    public class ApiCollection
    {
        public int count { get; set; }
        public IEnumerable<Auxiliar.BaseNameUrl> results { get; set; }
    }
}
