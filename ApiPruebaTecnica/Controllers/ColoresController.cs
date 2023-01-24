using ApiPruebaTecnica.Models;
using ApiPruebaTecnica.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiPruebaTecnica.Controllers
{    
    [Route("api/[controller]")]
    [ApiController]
    public class ColoresController : ControllerBase
    {
        public IConfiguration _configuration;

        public ColoresController(IConfiguration configuration)
        {
            _configuration= configuration;  
        }

        [HttpGet]
        public ActionResult<List<Colores>> GetColores()
        {
            try
            {
                ColoresRepository coloresRepository = new ColoresRepository(_configuration);                
                return Ok(coloresRepository.GetColores());
            }
            catch(Exception ex)
            {
                return BadRequest();
            }            
        }
    }
}
