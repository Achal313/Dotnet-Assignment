using _29Jul.Models;

namespace _29Jul.Services
{
    public class VehicleService : IVehicleService
    {
        private static List<Vehicle> vehicles = new List<Vehicle>()
        {
            new Vehicle
            {
                Id = 1,
                VehicleName = "Swift",
                Brand = "Maruti",
                ModelYear = 2023,
                Price = 800000
            },

            new Vehicle
            {
                Id = 2,
                VehicleName = "Creta",
                Brand = "Hyundai",
                ModelYear = 2024,
                Price = 1500000
            },

            new Vehicle
            {
                Id = 3,
                VehicleName = "Nexon",
                Brand = "Tata",
                ModelYear = 2024,
                Price = 1200000
            }
        };

        public List<Vehicle> GetVehicles()
        {
            return vehicles;
        }

        public Vehicle? GetVehicle(int id)
        {
            return vehicles.FirstOrDefault(v => v.Id == id);
        }

        public Vehicle? GetVehicleByName(string name)
        {
            return vehicles.FirstOrDefault(v => v.VehicleName == name);
        }

        public Vehicle AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
            return vehicle;
        }
    }
}