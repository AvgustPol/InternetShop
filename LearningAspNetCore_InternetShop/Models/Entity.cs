using System.ComponentModel.DataAnnotations;

namespace LearningAspNetCore_InternetShop.Models
{
    /// <summary>
    /// Just an abstract class for creating a batabase abstraction
    /// </summary>
    public abstract class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}