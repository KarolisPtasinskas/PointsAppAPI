using PointsAppWebAPI.Models;
using PointsAppWebAPI.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PointsAppWebAPI.Services
{
    public class CoordinatesService
    {
        private readonly CoordinatesRepository _repository;

        public CoordinatesService(CoordinatesRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Coordinate>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<Coordinate> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task Post(Coordinate coordinate)
        {
            await _repository.Post(coordinate);
        }

        public async Task Delete(int id)
        {
            var coordinate = await _repository.GetById(id);
            await _repository.Delete(coordinate);
        }
    }
}
