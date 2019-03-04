using LearningAspNetCore_InternetShop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LearningAspNetCore_InternetShop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CustomUser> CustomUsers { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
    }
}