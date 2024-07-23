//class for describe position of object in space
namespace WebAPI.Model
{
    public class SpaceObjectPosition
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Altitude { get; set; }
        public double Velocity { get; set; }
        public double Acceleration { get; set; }
        public double Angle { get; set; }
    }
}