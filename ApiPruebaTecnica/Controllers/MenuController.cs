using ApiPruebaTecnica.Models;
using ApiPruebaTecnica.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace ApiPruebaTecnica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        public IConfiguration _configuration;

        public MenuController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public ActionResult<List<Menu>> GetMenu()
        {
            try
            {
                    MenuRepository menuRepository = new MenuRepository(_configuration);
                    return Ok(menuRepository.GetMenu());
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
