using Microsoft.AspNetCore.Mvc;
using PointsAppWebAPI.Models;
using PointsAppWebAPI.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PointsAppWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoordinatesController : ControllerBase
    {
        private readonly CoordinatesService _service;
        public CoordinatesController(CoordinatesService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Coordinate>>> GetAll()
        {
            return Ok(await _service.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Coordinate>> GetById(int id)
        {
            var coord = await _service.GetById(id);

            if (coord == null)
            {
                return NotFound();
            }

            return Ok(coord);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Coordinate coordinate)
        {
            await _service.Post(coordinate);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return NoContent();
        }
    }
}
