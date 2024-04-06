namespace PokeApiSharp.Models
{
    public class Type
    {
        public string name { get; set; }
        public int id { get; set; }
        public IEnumerable<Auxiliar.Lang> names { get; set; }
    }
}
