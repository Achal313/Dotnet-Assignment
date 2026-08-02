using _29Jul.Models;

namespace _29Jul.Services
{
    public interface IVehicleService
    {
        List<Vehicle> GetVehicles();

        Vehicle? GetVehicle(int id);

        Vehicle? GetVehicleByName(string name);

        Vehicle AddVehicle(Vehicle vehicle);
    }
}