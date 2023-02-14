using AutoMapper;
using CobraTestNET6.DTOs;
using CobraTestNET6.Entities.Models;
using CobraTestNET6.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CobraTestNET6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarservice _carService;
        private readonly IMapper _mapper;
        public CarController(ICarservice carService, IMapper mapper)
        {
            _carService= carService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<List<Car>>> Get()
        {
            return await _carService.GetCars();
        }

        [HttpGet("{id:int}", Name = "GetCarById")]
        public async Task<ActionResult<Car>> Get(int id)
        {
            return await _carService.GetCar(id);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Car car, int id)
        {
            var res = await _carService.UpdateCar(car);
            if (!res) 
                return NotFound(car.Id);
            else
                return Ok(car);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var res = await _carService.DeleteCar(id);
            if (!res)
                return NotFound(id);
            else
                return Ok(id);
        }
        
        
        [HttpPost]
        public async Task<ActionResult<CarDTO>> Post([FromBody] CarDTO car)
        {
            var newCar = await _carService.AddCar(_mapper.Map<Car>(car));

            return _mapper.Map<CarDTO>(newCar) ;
        }
    }

    

}
