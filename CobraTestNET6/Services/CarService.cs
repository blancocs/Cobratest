using CobraTestNET6.Entities.Models;
using CobraTestNET6.Repositories;

namespace CobraTestNET6.Services
{
    public class Carservice : ICarservice
    {
        private readonly ICobraTestRepository _repository;

        public Carservice (ICobraTestRepository repo)
        {
            _repository = repo;
        }

        public async Task<Car> AddCar(Car car)
        {
            return await _repository.CreateCar(car);
        }

        public async Task<bool> DeleteCar(int id)
        {
            return await _repository.DeleteCar(id);
        }

        public async Task<Car> GetCar(int id)
        {
            return await _repository.GetCarById(id);
        }

        public async Task<List<Car>> GetCars()
        {
            return await _repository.GetCars();
        }

        public async Task<bool> UpdateCar(Car car)
        {
            return await _repository.UpdateCar(car);
        }
    }
}
