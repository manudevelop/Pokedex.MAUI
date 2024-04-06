namespace PokeApiSharp.Models
{
    public class Auxiliar
    {
        public class Lang
        {
            public string name { get; set; }
            public BaseNameUrl language { get; set; }
        }
        public class BaseName : BaseModel
        {
            public string name { get; set; }
        }
        public class BaseNameUrl : BaseName
        {
            public string url { get; set; }
        }
    }
}
