using CPC_API.Models;
using CPC_API.Models.Entities;

namespace CPC_API.Services
{
    public class CountryService : Interfaces.IBaseService<Country>
    {
        readonly CountryContext _context;

        public CountryService(CountryContext context)
        {
            _context = context;
        }

        public List<Country> GetAll()
        {
            return _context.Countries.ToList();
        }

        public Country? GetById(int id)
        {
            return _context.Countries.Find(id);
        }

        public string Add(Country entity)
        {
            _context.Add(entity);
            _context.SaveChanges();

            return "Country Added Successfully!";
        }

        public string Update(Country entity)
        {
            Country? country = _context.Countries.Find(entity.Id);

            if (country is null) return "Country not Found!";

            country.Name = entity.Name;
            country.ModificationDate = entity.ModificationDate;
            country.Code = entity.Code;

            _context.SaveChanges();

            return "Country Updated Successfully!";
        }

        public string Delete(int id)
        {
            Country? country = _context.Countries.Find(id);

            if (country is null) return "Country not Found!";

            _context.Countries.Remove(country);
            _context.SaveChanges();

            return "Country Deleted Successfully!";
        }
    }
}
