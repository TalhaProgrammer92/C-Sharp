using CodeFirstApproach.Models;
using CodeFirstApproach.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstApproach.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        // Attribute
        private readonly CarContext context;

        // Constructor
        public CarController(CarContext context)
        {
            this.context = context;
        }

        // Get: api/car
        [HttpGet]
        [Route("GetCars")]
        public List<Car> GetCars()
        {
            // Fetching all cars from the database
            //var cars = context.Cars.ToList();
            //return Ok(cars);
            return context.Cars.ToList();
        }

        // Post: api/car
        [HttpPost]
        [Route("AddCar")]
        public string AddCar(Car car)
        {
            // Adding a new car to the database
            context.Cars.Add(car);
            context.SaveChanges();
            
            // Returning a success message
            return "Car added successfully!";
        }
    }
}
