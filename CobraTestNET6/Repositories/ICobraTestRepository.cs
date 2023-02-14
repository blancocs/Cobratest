using CobraTestNET6.Entities.Models;

namespace CobraTestNET6.Repositories
{
    public interface ICobraTestRepository
    {
        Task<List<Car>> GetCars();

        Task<Car> CreateCar(Car car);
        Task<bool> DeleteCar(int id);
        Task<bool> UpdateCar(Car car);

        Task<Car> GetCarById(int id);
    }
}
