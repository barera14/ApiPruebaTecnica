using ApiPruebaTecnica.Models;
using Microsoft.AspNetCore.Components;
using System.Text.Json;

namespace ApiPruebaTecnica.Repository
{    
    public class GradosRepository
    {
        public IConfiguration _configuration;
        public string urlData { get; set; }
        public GradosRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            urlData = configuration.GetValue<string>("DataFiles:UrlGrados");
        }

        public List<Grados> GetGrados()
        {
            string Data = File.ReadAllText(urlData);
            return JsonSerializer.Deserialize<List<Grados>>(Data); ;
        }
    }
}
