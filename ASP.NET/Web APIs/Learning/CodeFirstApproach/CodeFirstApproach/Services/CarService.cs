using CodeFirstApproach.Models;
using CodeFirstApproach.Models.Entities;
using CodeFirstApproach.Services.Interfaces;

namespace CodeFirstApproach.Services
{
    public class CarService : ICarService
    {
        private readonly CarContext context;

        // Constructor to initialize the context
        public CarService(CarContext context)
        {
            this.context = context;
        }

        // Methods to handle car operations
        
        // Get: api/car
        public List<Car> GetCars()
        {
            return context.Cars.ToList();
        }

        // Post: api/car
        public string AddCar(Car car)
        {
            context.Cars.Add(car);
            context.SaveChanges();
            return "Car added successfully!";
        }

        // Update: api/car
        public string UpdateCar(Car car)
        {
            var existingCar = context.Cars.Find(car.Id);
            // Check if the car exists
            if (existingCar == null)
                return "Car not found!";

            // Update the car details
            existingCar.Name = car.Name;
            existingCar.Model = car.Model;
            existingCar.Price = car.Price;
            context.SaveChanges();
            return "Car updated successfully!";
        }

        // Delete: api/car
        public string DeleteCar(Car car)
        {
            var existingCar = context.Cars.Find(car.Id);
            // Check if the car exists
            if (existingCar == null)
                return "Car not found!";

            // Remove the car from the database
            context.Cars.Remove(existingCar);
            context.SaveChanges();
            return "Car removed successfully!";
        }
    }
}
