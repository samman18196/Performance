using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Pages.JoinLicenseAssets
{
    public class DeleteModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public DeleteModel(tbkkData.Models.tbkkDataContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            JoinLicenseAsset = await _context.JoinLicenseAsset.FindAsync(id);

            if (JoinLicenseAsset != null)
            {
                _context.JoinLicenseAsset.Remove(JoinLicenseAsset);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
