using ApiPruebaTecnica.Models;
using ApiPruebaTecnica.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPruebaTecnica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VariedadesController : ControllerBase
    {
        public IConfiguration _configuration;

        public VariedadesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public ActionResult<List<Grados>> GetGrados()
        {
            try
            {
                VariedadesRepository variedadesRepository = new VariedadesRepository(_configuration);
                return Ok(variedadesRepository.GetVarieades());
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
