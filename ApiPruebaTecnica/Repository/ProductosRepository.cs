using ApiPruebaTecnica.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text.Json;
using System.Xml.Linq;

namespace ApiPruebaTecnica.Repository
{

    public class ProductosRepository
    {
        public IConfiguration _configuration;
        public string urlData { get; set; }
        public ProductosRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            urlData = configuration.GetValue<string>("DataFiles:UrlProductos");
        }

        public List<Producto> GetProductos()
        {
            string Data = File.ReadAllText(urlData);
            return JsonSerializer.Deserialize<List<Producto>>(Data);
        }

        public bool SaveProducto(Producto producto)
        {
            try
            {
                string newId = Guid.NewGuid().ToString();
                producto.id = newId;         
                List<Producto> ListProductos = new List<Producto>();
                string Data = File.ReadAllText(urlData);
                ListProductos = JsonSerializer.Deserialize<List<Producto>>(Data);                
                ListProductos.Add(producto);                
                File.WriteAllText(urlData, JsonSerializer.Serialize<List<Producto>>(ListProductos));
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }


        }
    }

}
