using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EcommerceBackend.Services;

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
    }
}
