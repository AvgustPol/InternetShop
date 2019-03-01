using System.ComponentModel.DataAnnotations;

namespace LearningAspNetCore_InternetShop.Models
{
    public class ServiceType : Entity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}