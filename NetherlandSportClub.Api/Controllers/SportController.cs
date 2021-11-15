using Microsoft.AspNetCore.Mvc;
using NetherlandSportClub.Core;
using NetherlandSportClub.Service.Contracts;

namespace NetherlandSportClub.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportController : ControllerBase
    {
        private readonly ISportService _sportService;
        public SportController(ISportService sportService)
        {
            _sportService = sportService;
        }

        [HttpGet]
        public IActionResult GetSports()
        {
            return Ok(_sportService.GetSports());
        }

        [HttpPost]
        public IActionResult AddSport(Sport sport)
        {
            return Ok(_sportService.AddSport(sport));
        }

        [HttpPut]
        public IActionResult UpdateSport(Sport sport)
        {
            return Ok(_sportService.Update(sport));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            _sportService.Delete(id);
            return NoContent();
        }            
    }
}
