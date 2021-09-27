namespace PointsAppWebAPI.Models
{
    public class Coordinate
    {
        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int? CoordinatesListId { get; set; }
        public CoordinatesList CoordinatesList { get; set; }
    }
}
