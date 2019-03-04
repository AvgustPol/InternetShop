using LearningAspNetCore_InternetShop.Data;
using LearningAspNetCore_InternetShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LearningAspNetCore_InternetShop.Pages.ServiceTypes
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;

        public DeleteModel(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ServiceType = await _dbContext.ServiceTypes.FindAsync(id);

            if (ServiceType != null)
            {
                _dbContext.ServiceTypes.Remove(ServiceType);
                await _dbContext.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}