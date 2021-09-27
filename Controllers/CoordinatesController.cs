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
            return await _service.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Coordinate>> GetById(int id)
        {
            return await _service.GetById(id);
        }

        [HttpPost("{x}, {y}, {cooList}")]
        public async Task Post(int x, int y, int cooList)
        {
            await _service.Post(x, y, cooList);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _service.Delete(id);
        }
    }
}
