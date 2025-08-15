using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EcommerceBackend.Services;
using EcommerceBackend.Models.API;
using Microsoft.AspNetCore.Authorization;

namespace EcommerceBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        readonly JWTService _jwtService;

        public AdminController(JWTService jwtService)
        {
            _jwtService = jwtService;
        }

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
    }
}
