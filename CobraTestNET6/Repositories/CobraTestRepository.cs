using CobraTestNET6.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace CobraTestNET6.Repositories
{
    public class CobraTestRepository : ICobraTestRepository
    {
        private readonly CobraTestContext _context;
    
        public CobraTestRepository(CobraTestContext context)
        {
            _context = context;
        }

        public async Task<Car> CreateCar(Car car)
        {
           await _context.Cars.AddAsync(car);
           await _context.SaveChangesAsync();

            return car;
        }

        public async Task<bool> DeleteCar(int id)
        {
            var exists = await _context.Cars.AnyAsync(c => c.Id == id);

            if (exists)
            {
                _context.Remove(new Car() { Id = id });
                await _context.SaveChangesAsync();
                
                return true;
            }
            else
            {
                return false;
            }

            
        }

        public async Task<Car> GetCarById(int id)
        {
            return await _context.Cars.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<List<Car>> GetCars()
        {
            return await _context.Cars.ToListAsync();
        }

        public async Task<bool> UpdateCar(Car car)
        {
            var exists = await _context.Cars.AnyAsync(c => c.Id == car.Id);

            if (!exists)
            {
                return false;
            }
            else
            {
                var myCar = await _context.Cars.FirstOrDefaultAsync(c=> c.Id == car.Id);
                myCar = car;

                _context.Update(myCar);
                await _context.SaveChangesAsync();

                return true;
            }


        }
    }
}
