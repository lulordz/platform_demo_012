using Data;
using Data.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace PlatformDemo.Pages
{
    public class CustomersModel : PageModel
    {
        private readonly PlatformDemoContext _context;

        public CustomersModel(PlatformDemoContext context)
        {
            _context = context;
        }

        public IList<Customer> Customers { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            //Customers = await _context.Customers.ToListAsync();
            Customers = _context.Customers.Include(c => c.Orders).ToList();
            return Page();
        }
    }
}
