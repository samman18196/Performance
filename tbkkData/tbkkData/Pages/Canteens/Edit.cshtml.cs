using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Pages.Canteens
{
    public class EditModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public EditModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Canteen Canteen { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Canteen = await _context.Canteen.FirstOrDefaultAsync(m => m.CanteenID == id);

            if (Canteen == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Canteen).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CanteenExists(Canteen.CanteenID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CanteenExists(int id)
        {
            return _context.Canteen.Any(e => e.CanteenID == id);
        }
    }
}
