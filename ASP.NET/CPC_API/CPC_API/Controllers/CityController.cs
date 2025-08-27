using CPC_API.Models.Entities;
using CPC_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CPC_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        readonly CityService service;

        public CityController(CityService service)
        {
            this.service = service;
        }

        [HttpGet("GetAllCities")]
        public List<City> GetAll()
        {
            return service.GetAll();
        }

        [HttpGet("GetByCityId")]
        public City? GetById(int id)
        {
            return service.GetById(id);
        }

        [HttpGet("GetByProvinceId")]
        public List<City> GetByProvinceId(int id)
        {
            return service.GetByProvinceId(id);
        }

        [HttpGet("GetByCountryId")]
        public List<City> GetByCountryId(int id)
        {
            return service.GetByCountryId(id);
        }

        [HttpPost("AddCity")]
        public string Add(City city)
        {
            return service.Add(city);
        }

        [HttpPut("UpdateCity")]
        public string Update(City city)
        {
            return service.Update(city);
        }

        [HttpDelete("DeleteCity")]
        public string Delete(int id)
        {
            return service.Delete(id);
        }
    }
}
