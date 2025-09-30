using CPC_API.Models;
using CPC_API.Models.Entities;
using CPC_API.Services.Interfaces;

namespace CPC_API.Services
{
    public class ProvinceService : IBaseService<Province>
    {
        readonly ProvinceContext _context;

        public ProvinceService(ProvinceContext context)
        {
            _context = context;
        }

        public List<Province> GetAll()
        {
            return _context.Provinces.ToList();
        }

        public Province? GetById(int id)
        {
            return _context.Provinces.Find(id);
        }

        public List<Province> GetByCountryId(int countryId)
        {
            List<Province> provinces = new List<Province>();

            foreach (var province in _context.Provinces)
                if (province.CountryId == countryId)
                    provinces.Add(province);
            
            return provinces;
        }

        public string Add(Province entity)
        {
            _context.Add(entity);
            _context.SaveChanges();

            return "Province Added Successfully!";
        }

        public string Update(Province entity)
        {
            Province? province = _context.Provinces.Find(entity.Id);

            if (province is null) return "Province not Found!";

            province.Name = entity.Name;
            province.ModificationDate = entity.ModificationDate;
            province.CountryId = entity.CountryId;

            _context.SaveChanges();

            return "Province Updated Successfully!";
        }

        public string Delete(int id)
        {
            Province? province = _context.Provinces.Find(id);

            if (province is null) return "Province not Found!";

            _context.Provinces.Remove(province);
            _context.SaveChanges();

            return "Province Deleted Successfully!";
        }
    }
}
