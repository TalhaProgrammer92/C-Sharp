using CPC_API.Models;
using CPC_API.Models.Entities;
using CPC_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CPC_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinceController : ControllerBase
    {
        readonly ProvinceService service;

        public ProvinceController(ProvinceService service)
        {
            this.service = service;
        }

        [HttpGet("GetAllProvinces")]
        public List<Province> GetAll()
        {
            return service.GetAll();
        }

        [HttpGet("GetProvinceById")]
        public Province? GetById(int id)
        {
            return service.GetById(id);
        }

        [HttpGet("GetByCountryId")]
        public List<Province> GetByCountryId(int id)
        {
            return service.GetByCountryId(id);
        }

        [HttpPost("AddProvince")]
        public string Add(Province province)
        {
            return service.Add(province);
        }

        [HttpPut("UpdateProvince")]
        public string Update(Province province)
        {
            return service.Update(province);
        }

        [HttpDelete("DeleteProvince")]
        public string Delete(int id)
        {
            return service.Delete(id);
        }
    }
}
