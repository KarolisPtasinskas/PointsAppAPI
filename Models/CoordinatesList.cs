using System;
using System.Collections.Generic;

namespace PointsAppWebAPI.Models
{
    public class CoordinatesList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Coordinate> Coordinates { get; set; }

        internal object Select(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
