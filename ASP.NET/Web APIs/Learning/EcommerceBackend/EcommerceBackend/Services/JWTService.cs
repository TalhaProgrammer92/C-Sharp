using EcommerceBackend.Data;
using EcommerceBackend.Models.API;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EcommerceBackend.Services
{
    public class JWTService
    {
        readonly AppDbContext _dbContext;
        readonly IConfiguration _config;

        // Constructor
        public JWTService(AppDbContext dbContext, IConfiguration config)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(_dbContext));
            _config = config;
        }

        public async Task<LoginResponseModel?> Authenticate(LoginRequestModel model)
        {
            if (string.IsNullOrEmpty(model.UserName) || string.IsNullOrEmpty(model.Password))
                return null;

            // Check if the user exists
            var userAccount = await _dbContext.Admins
                .FirstOrDefaultAsync(a => a.UserName == model.UserName);
            if (userAccount is null) return null;

            var issuer = _config["JWTConfig:Issuer"];
            var audience = _config["JWTConfig:Audience"];
            var key = _config["JWTConfig:Key"];
            var tokenValidityInMinutes = _config.GetValue<int>("JWTConfig:TokenValidityInMinutes");
            var tokenExpiryTimeStamp = DateTime.UtcNow.AddMinutes(tokenValidityInMinutes);

            var tokenDiscriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(JwtRegisteredClaimNames.Name, model.UserName)
                }),
                Expires = tokenExpiryTimeStamp,
                Issuer = issuer,
                Audience = audience,
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key)),
                    SecurityAlgorithms.HmacSha512Signature),
                //SecurityAlgorithms.HmacSha256Signature),
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var securityToken = tokenHandler.CreateToken(tokenDiscriptor);
            var accessToken = tokenHandler.WriteToken(securityToken);

            return new LoginResponseModel
            {
                UserName = model.UserName,
                Token = accessToken,
                ExpiresIn = (int)(tokenExpiryTimeStamp - DateTime.UtcNow).TotalSeconds
            };
        }
    }
}
