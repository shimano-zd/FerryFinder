using System;

namespace FerryFinder.Models
{
    public class FerryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Length { get; set; }
        public decimal Draft { get; set; }
        public decimal Width { get; set; }
        public int PassengerCapacity { get; set; }
        public int VehicleCapacity { get; set; }
        public decimal MaxSpeed { get; set; }
        public ShipType ShipType { get; set; }
        public string Image { get; set; }
        public Action OnClick { get; set; }
    }
}
