using CodeFirstApproach.Models.Entities;

namespace CodeFirstApproach.Services.Interfaces
{
    public interface ICarService
    {
        public List<Car> GetCars();
        public string AddCar(Car car);
        public string UpdateCar(Car car);
        public string DeleteCar(Car car);
    }
}
