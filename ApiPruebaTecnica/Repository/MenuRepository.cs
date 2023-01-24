using ApiPruebaTecnica.Models;
using Microsoft.AspNetCore.Components;
using System.Text.Json;

namespace ApiPruebaTecnica.Repository
{    
    public class MenuRepository
    {
        public IConfiguration _configuration;
        public string urlData { get; set; }
        public MenuRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            urlData = configuration.GetValue<string>("DataFiles:UrlMenu");
        }

        public List<Menu> GetMenu()
        {
            string Data = File.ReadAllText(urlData);
            return JsonSerializer.Deserialize<List<Menu>>(Data); ;
        }
    }
}
