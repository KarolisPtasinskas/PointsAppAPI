using PointsAppWebAPI.Models;
using PointsAppWebAPI.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PointsAppWebAPI.Services
{
    public class CoordinatesListService
    {
        private readonly CoordinatesListRepository _repository;

        public CoordinatesListService(CoordinatesListRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<CoordinatesList>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<List<Coordinate>> GetCoordinates(int id)
        {
            return await _repository.GetCoordinates(id);
        }

        public async Task Post(string name)
        {
            var cooList = new CoordinatesList()
            {
                Name = name
            };
            await _repository.Post(cooList);
        }

        public async Task Delete(int id)
        {
            var cooList = await _repository.GetById(id);
            await _repository.Delete(cooList);
        }
    }
}
