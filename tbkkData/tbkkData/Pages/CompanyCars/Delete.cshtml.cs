using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Pages.CompanyCars
{
    public class DeleteModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public DeleteModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CompanyCar CompanyCar { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CompanyCar = await _context.CompanyCar.FirstOrDefaultAsync(m => m.CompanyCarID == id);

            if (CompanyCar == null)
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

            CompanyCar = await _context.CompanyCar.FindAsync(id);

            if (CompanyCar != null)
            {
                _context.CompanyCar.Remove(CompanyCar);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
