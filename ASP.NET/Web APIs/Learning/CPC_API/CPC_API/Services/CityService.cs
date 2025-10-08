using CPC_API.Models;
using CPC_API.Models.Entities;
using CPC_API.Services.Interfaces;

namespace CPC_API.Services
{
    public class CityService : IBaseService<City>
    {
        readonly CityContext _context;

        public CityService(CityContext context)
        {
            _context = context;
        }

        public List<City> GetAll()
        {
            return _context.Cities.ToList();
        }

        public City? GetById(int id)
        {
            return _context.Cities.Find(id);
        }

        public List<City> GetByCountryId(int countryId)
        {
            List<City> cities = new List<City>();

            foreach (var city in _context.Cities)
                if (city.CountryId == countryId)
                    cities.Add(city);

            return cities;
        }

        public List<City> GetByProvinceId(int provinceId)
        {
            List<City> cities = new List<City>();

            foreach (var city in _context.Cities)
                if (city.ProvinceId == provinceId)
                    cities.Add(city);

            return cities;
        }

        public string Add(City entity)
        {
            _context.Add(entity);
            _context.SaveChanges();

            return "City Added Successfully!";
        }

        public string Update(City entity)
        {
            City? city = _context.Cities.Find(entity.Id);

            if (city is null) return "City not Found!";

            city.Name = entity.Name;
            city.ModificationDate = entity.ModificationDate;
            city.CountryId = entity.CountryId;
            city.ProvinceId = entity.ProvinceId;

            _context.SaveChanges();

            return "City Updated Successfully!";
        }

        public string Delete(int id)
        {
            City? city = _context.Cities.Find(id);

            if (city is null) return "City not Found!";

            _context.Cities.Remove(city);
            _context.SaveChanges();

            return "City Deleted Successfully!";
        }
    }
}
