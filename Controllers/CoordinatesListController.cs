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
            return await _service.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Coordinate>>> GetCoordinates(int id)
        {
            return await _service.GetCoordinates(id);
        }


        [HttpPost("{name}")]
        public async Task Post(string name)
        {
            await _service.Post(name);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _service.Delete(id);
        }
    }
}
