using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EcommerceBackend.Services;
using EcommerceBackend.Models.API;
using Microsoft.AspNetCore.Authorization;
using EcommerceBackend.DTOs;
using EcommerceBackend.Models.Entities;
using EcommerceBackend.Data;

namespace EcommerceBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        readonly JWTService _jwtService;
        //private readonly AppDbContext dbContext;


        public AdminController(JWTService jwtService)
        {
            _jwtService = jwtService;
        }

        //public AdminController(AppDbContext dbContext)
        //{
        //    this.dbContext = dbContext;
        //}

        // POST: api/Admin/Login
        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<ActionResult<LoginResponseModel>> Login(LoginRequestModel request)
        {
            var response = await _jwtService.Authenticate(request);
            
            if (response is null)
            {
                return Unauthorized(new { message = "Unauthorized Access!" });
            }

            return response;
        }

        // POST: [Normal]
        //[HttpPost]
        //public IActionResult AddUser(UserDTO userDto)
        //{
        //    var user = new User()
        //    {
        //        Name = userDto.Name,
        //        Password = userDto.Password,
        //    };

        //    dbContext.Users.Add(user);
        //    dbContext.SaveChanges();

        //    return Ok(user);
        //}
    }
}
