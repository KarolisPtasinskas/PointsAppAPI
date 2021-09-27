using Microsoft.AspNetCore.Mvc;
using PointsAppWebAPI.Models;
using PointsAppWebAPI.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PointsAppWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoordinatesListController : ControllerBase
    {
        private readonly CoordinatesListService _service;

        public CoordinatesListController(CoordinatesListService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<CoordinatesList>>> GetAll()
        {
            return Ok(await _service.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Coordinate>>> GetCoordinates(int id)
        {
            var coordList = await _service.GetCoordinates(id);

            if (coordList == null)
            {
                return NotFound();
            }

            return Ok(coordList);
        }


        [HttpPost]
        public async Task Post(CoordinatesList coordinateList)
        {
            await _service.Post(coordinateList);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return NoContent();        }
    }
}
