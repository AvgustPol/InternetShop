using LearningAspNetCore_InternetShop.Data;
using LearningAspNetCore_InternetShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearningAspNetCore_InternetShop.Pages.ServiceTypes
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;

        public IndexModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool IsAnyServiceType => ServiceTypes.Count > 0;
        public IList<ServiceType> ServiceTypes { get; set; }

        public async Task<IActionResult> OnGet()
        {
            ServiceTypes = await _dbContext.ServiceTypes.ToListAsync();
            return Page();
        }
    }
}