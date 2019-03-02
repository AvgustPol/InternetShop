using LearningAspNetCore_InternetShop.Data;
using LearningAspNetCore_InternetShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace LearningAspNetCore_InternetShop.Pages.ServiceTypes
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;

        public CreateModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [TempData]
        public string Message { get; set; }

        [BindProperty]
        public ServiceType ServiceType { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await _dbContext.ServiceTypes.AddAsync(ServiceType);
            await _dbContext.SaveChangesAsync();
            Message = $"Added a new ServiceType with name {ServiceType.Name}";
            return RedirectToPage("Index");
        }
    }
}