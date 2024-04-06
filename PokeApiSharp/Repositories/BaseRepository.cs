using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeApiSharp.Repositories
{
    public abstract class BaseRepository
    {
        public readonly string BaseUrl;
        
        public BaseRepository()
        {
            BaseUrl = "https://pokeapi.co/api/v2";
        }

        public async Task<T> GetAsync<T>(string source, Dictionary<string, string> queryParameters, params string[] uriParameters)
            where T : class, new()
        {
            var url = buildUrl(source, queryParameters, uriParameters);
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                var json = await response.Content.ReadAsStringAsync();

                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    throw new Exception($"Error {response.StatusCode}: {json}");

                return JsonConvert.DeserializeObject<T>(json);
            }
        }

        string buildUrl(string source, Dictionary<string, string> queryParameters, params string[] uriParameters)
        {
            var uri = $"{BaseUrl}/{source}";

            if(uriParameters != null)
                uri += "/" + string.Join("/", uriParameters);

            if(queryParameters != null)
                uri += "/?" + string.Join("&", queryParameters.Select(p=>$"{p.Key}={p.Value}"));

            return uri ;
        }
    }
}
