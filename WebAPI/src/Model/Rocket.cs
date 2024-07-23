//Model describe rocket object
namespace WebAPI.Model
{
    public class Rocket
    {
        public Guid Id { get; set; }
        public string SerialNumber { get; set; }
        public string FunyName { get; set; }
        public long FuelCapacity { get; set; }
        public long FuelLevel { get; set; }
        public string Manufacturer { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public SpaceObjectPosition Position { get; set; }

    }
}