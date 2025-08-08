namespace EcommerceBackend.Models.API
{
    public class LoginResponseModel
    {
        // Attributes
        public string? UserName { get; set; }
        public string? Token { get; set; }
        public int ExpiresIn { get; set; }
    }
}
