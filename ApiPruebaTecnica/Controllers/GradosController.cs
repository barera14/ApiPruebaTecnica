using ApiPruebaTecnica.Models;
using ApiPruebaTecnica.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPruebaTecnica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradosController : ControllerBase
    {
        public IConfiguration _configuration;

        public GradosController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public ActionResult<List<Grados>> GetGrados()
        {
            try
            {
                GradosRepository gradosRepository = new GradosRepository(_configuration);
                return Ok(gradosRepository.GetGrados());
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
