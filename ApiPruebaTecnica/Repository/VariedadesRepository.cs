using ApiPruebaTecnica.Models;
using Microsoft.AspNetCore.Components;
using System.Text.Json;

namespace ApiPruebaTecnica.Repository
{    
    public class VariedadesRepository
    {
        public IConfiguration _configuration;
        public string urlData { get; set; }
        public VariedadesRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            urlData = configuration.GetValue<string>("DataFiles:UrlVariedades");
        }

        public List<Variedades> GetVarieades()
        {
            string Data = File.ReadAllText(urlData);
            return JsonSerializer.Deserialize<List<Variedades>>(Data); ;
        }
    }
}
