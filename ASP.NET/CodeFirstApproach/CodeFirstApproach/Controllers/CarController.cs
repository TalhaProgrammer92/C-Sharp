using CodeFirstApproach.Models;
using CodeFirstApproach.Models.Entities;
using CodeFirstApproach.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstApproach.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService carService;

        // Constructor to initialize the car service
        public CarController(ICarService carService)
        {
            this.carService = carService;
        }

        // API Endpoints
        // Get: api/car/GetCars
        [HttpGet("GetCars")]
        public List<Car> GetCars() => carService.GetCars();

        // Post: api/car/AddCar
        [HttpPost("AddCar")]
        public string AddCar(Car car) => carService.AddCar(car);

        // Put: api/car/UpdateCar
        [HttpPut("UpdateCar")]
        public string UpdateCar(Car car) => carService.UpdateCar(car);

        // Delete: api/car/RemoveCar
        [HttpDelete("RemoveCar")]
        public string DeleteCar(Car car) => carService.DeleteCar(car);

        //// Attribute
        //private readonly CarContext context;

        //// Constructor
        //public CarController(CarContext context)
        //{
        //    this.context = context;
        //}

        //// Get: api/car
        //[HttpGet]
        //[Route("GetCars")]
        //public List<Car> GetCars()
        //{
        //    // Fetching all cars from the database
        //    //var cars = context.Cars.ToList();
        //    //return Ok(cars);
        //    return context.Cars.ToList();
        //}

        //// Post: api/car
        //[HttpPost]
        //[Route("AddCar")]
        //public string AddCar(Car car)
        //{
        //    // Adding a new car to the database
        //    context.Cars.Add(car);
        //    context.SaveChanges();

        //    // Returning a success message
        //    return "Car added successfully!";
        //}

        //// Delete: api/car
        //[HttpDelete]
        //[Route("RemoveCar")]
        //public string DeleteCar(Car car)
        //{
        //    // Checking if the car exists in the database
        //    var existingCar = context.Cars.Find(car.Id);

        //    if (existingCar == null)
        //    {
        //        return "Car not found!";
        //    }

        //    // Removing the car from the database
        //    context.Cars.Remove(existingCar);
        //    context.SaveChanges();

        //    // Returning a success message
        //    return "Car removed successfully!";
        //}

        //// Update: api/car
        //[HttpPut]
        //[Route("UpdateCar")]
        //public string UpdateCar(Car car)
        //{
        //    // Checking if the car exists in the database
        //    var existingCar = context.Cars.Find(car.Id);

        //    if (existingCar == null)
        //    {
        //        return "Car not found!";
        //    }

        //    // Updating the car details
        //    existingCar.Name = car.Name;
        //    existingCar.Model = car.Model;
        //    existingCar.Price = car.Price;
        //    context.SaveChanges();

        //    // Returning a success message
        //    return "Car updated successfully!";
        //}
    }
}