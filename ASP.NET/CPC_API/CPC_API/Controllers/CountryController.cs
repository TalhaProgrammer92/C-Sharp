using CPC_API.Services;
using CPC_API.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CPC_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        readonly CountryService countryService;

        // Initialize countryService
        public CountryController(CountryService countryService)
        {
            this.countryService = countryService;
        }

        // Get all countries list
        [HttpGet("GetAllCountries")]
        public List<Country> GetAll()
        {
            return countryService.GetAll();
        }

        // Get country by id
        [HttpGet("GetCountryById")]
        //[Route("{id}")]
        public Country? GetById(int id)
        {
            return countryService.GetById(id);
        }

        // Post a new country
        [HttpPost("AddCountry")]
        public string Add(Country country)
        {
            return countryService.Add(country);
        }

        // Update an existing country
        [HttpPut("UpdateCountry")]
        public string Update(Country country)
        {
            return countryService.Update(country);
        }

        // Remove a country
        [HttpDelete("DeleteCountry")]
        //[Route("{id}")]
        public string Delete(int id)
        {
            return countryService.Delete(id);
        }
    }
}
