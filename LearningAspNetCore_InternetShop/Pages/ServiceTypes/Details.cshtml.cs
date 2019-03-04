using LearningAspNetCore_InternetShop.Data;
using LearningAspNetCore_InternetShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LearningAspNetCore_InternetShop.Pages.ServiceTypes
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;

        public DetailsModel(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public ServiceType ServiceType { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ServiceType = await _dbContext.ServiceTypes.FirstOrDefaultAsync(m => m.Id == id);

            if (ServiceType == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}