using Microsoft.EntityFrameworkCore;
using PointsAppWebAPI.Data;
using PointsAppWebAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointsAppWebAPI.Repositories
{
    public class CoordinatesListRepository
    {
        private readonly PointsAppContext _context;

        public CoordinatesListRepository(PointsAppContext context)
        {
            _context = context;
        }

        public async Task<CoordinatesList> GetById(int id)
        {
            return await _context.CoordinatesLists.FindAsync(id);
        }
        public async Task<List<CoordinatesList>> GetAll()
        {
            return await _context.CoordinatesLists.ToListAsync();
        }

        public async Task<List<Coordinate>> GetCoordinates(int id)
        {
            //var cordList = await _context.CoordinatesLists.Where(i => i.Id == id).Include(c => c.Coordinates).Select(o => o.Coordinates).ToListAsync();

            //var cordList = await _context.CoordinatesLists.Where(i => i.Id == id).Include(c => c.Coordinates).ToListAsync();
            //var listOfCorrds = cordList.Select(c => c.Coordinates).ToList();

            //var coordList = await _context.CoordinatesLists.Include(c => c.Coordinates).FirstOrDefaultAsync(i => i.Id == id);
            //var listOfCoords = coordList.Coordinates;

            var cordList = await _context.CoordinatesLists.Where(i => i.Id == id).Include(o => o.Coordinates).SelectMany(c => c.Coordinates).ToListAsync();

            return cordList;
        }

        public async Task Post(CoordinatesList coordinatesList)
        {
            _context.CoordinatesLists.Add(coordinatesList);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(CoordinatesList cooList)
        {
            _context.Remove(cooList);
            await _context.SaveChangesAsync();
        }
    }
}
