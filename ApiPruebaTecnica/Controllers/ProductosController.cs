using ApiPruebaTecnica.Models;
using ApiPruebaTecnica.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPruebaTecnica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        public IConfiguration _configuration;
        public string _rootPath;

        public ProductosController(IConfiguration configuration, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            _configuration = configuration;
            _rootPath = env.ContentRootPath;
        }

        [HttpGet]
        public ActionResult<List<Producto>> GetProducto()
        {
            try
            {
                ProductosRepository productosRepository = new ProductosRepository(_configuration);
                return Ok(productosRepository.GetProductos());
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public ActionResult<List<Menu>> PostSaveProducto([FromBody]Producto producto)
        {
            try
            {
                ProductosRepository productosRepository = new ProductosRepository(_configuration);    
                return Ok(productosRepository.SaveProducto(producto));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
