using ApiPruebaTecnica.Models;
using static System.Net.Mime.MediaTypeNames;
using System.Text.Json;
using System;
using Microsoft.AspNetCore.Components;

namespace ApiPruebaTecnica.Repository
{
    public class ColoresRepository
    {
        public IConfiguration _configuration;
        public string urlData { get; set; }
        public ColoresRepository(IConfiguration configuration) {
            _configuration = configuration; 
            urlData = configuration.GetValue<string>("DataFiles:UrlColores");
        }

        public List<Colores> GetColores()
        {
            string Data = File.ReadAllText(urlData);        
            return JsonSerializer.Deserialize<List<Colores>>(Data); ;
        }
    }
}
