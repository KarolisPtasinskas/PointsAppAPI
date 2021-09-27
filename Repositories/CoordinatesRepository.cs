using Microsoft.EntityFrameworkCore;
using PointsAppWebAPI.Data;
using PointsAppWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PointsAppWebAPI.Repositories
{
    public class CoordinatesRepository
    {
        private readonly PointsAppContext _context;

        public CoordinatesRepository(PointsAppContext context)
        {
            _context = context;
        }

        public async Task<List<Coordinate>> GetAll()
        {
            return await _context.Coordinates.ToListAsync();
        }

        public async Task<Coordinate> GetById(int id)
        {
            return await _context.Coordinates.FindAsync(id);
        }

        public async Task Post(Coordinate coordinate)
        {
            await _context.Coordinates.AddAsync(coordinate);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Coordinate coordinate)
        {
            _context.Remove(coordinate);
            await _context.SaveChangesAsync();
        }
    }
}
