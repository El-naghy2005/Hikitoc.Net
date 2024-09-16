using hikitocAPI.Data;
using hikitocAPI.Models.Domain;
using hikitocAPI.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace hikitocAPI.Controllers
{
    [Route("api/[controller]")]  //Localhost:port/api/solarsystem
    [ApiController]
    public class SolarSystemsController : ControllerBase
    {
        private readonly HikitocDbContext hikitocDbcontext;

        public SolarSystemsController(HikitocDbContext hikitocDbcontext)
        {
            this.hikitocDbcontext = hikitocDbcontext;
        }
        // GET ALL SOLAR SYSTEM
        [HttpGet]
        public IActionResult getAll()
        {
            var SolarSystems = hikitocDbcontext.SolarSystems.ToList();

            var solarSystemsDto = SolarSystems.Select(SolarSystem => new SolarSystemDto()
            {
                Id = SolarSystem.Id,
                Code = SolarSystem.Code,
                Name = SolarSystem.Name,
                Image = SolarSystem.Image,
                
            }).ToList();

            return Ok(new { Message = "success From GetAll action method" , Data = solarSystemsDto});
        }

        // GET 1 SOLAR SYSTEM BY ID
        //[HTTPGET("{id}")]
        [HttpGet]
        [Route("{id : Guid}")] // localhost:port/api/solarsystems/{id}
        public IActionResult GetById([FromRoute] Guid id)
        {
            var solarSystemsingle = hikitocDbcontext.SolarSystems.SingleOrDefault(item => item.Id == id);

            if (solarSystemsingle == null)
            {
                return NotFound(new { Message = "No solar System found!" });
            }
            var solarSystemsDto = new SolarSystemDto
            {
                Id = solarSystemsingle.Id,
                Code = solarSystemsingle.Code,
                Name = solarSystemsingle.Name,
                Image = solarSystemsingle.Image,
            };

            return Ok(new { Message = "1 solar system found", Data = solarSystemsDto });
        }
    }
}
