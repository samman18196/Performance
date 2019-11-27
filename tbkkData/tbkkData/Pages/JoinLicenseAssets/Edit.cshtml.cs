using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Pages.JoinLicenseAssets
{
    public class EditModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public EditModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public JoinLicenseAsset JoinLicenseAsset { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            JoinLicenseAsset = await _context.JoinLicenseAsset.FirstOrDefaultAsync(m => m.JoinLicenseAssetID == id);

            if (JoinLicenseAsset == null)
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

            _context.Attach(JoinLicenseAsset).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JoinLicenseAssetExists(JoinLicenseAsset.JoinLicenseAssetID))
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

        private bool JoinLicenseAssetExists(int id)
        {
            return _context.JoinLicenseAsset.Any(e => e.JoinLicenseAssetID == id);
        }
    }
}
