using Microsoft.AspNetCore.Identity;

namespace LearningAspNetCore_InternetShop.Models
{
    public class CustomUser : IdentityUser
    {
        public string FacebookLink { get; set; }
        public string Position { get; set; }
    }
}