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
    public class DetailsModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public DetailsModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

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
    }
}
