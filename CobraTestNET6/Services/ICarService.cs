using CobraTestNET6.Entities.Models;

namespace CobraTestNET6.Services
{
    public interface ICarservice
    {
        Task <List<Car>> GetCars();
        Task<Car> AddCar (Car car);

        Task<bool> UpdateCar (Car car);
        Task<bool> DeleteCar (int id);

        Task<Car> GetCar(int id);
    }
}
