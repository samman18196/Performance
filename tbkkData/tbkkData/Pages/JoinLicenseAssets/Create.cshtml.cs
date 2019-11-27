using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using tbkkData.Models;

namespace tbkkData.Pages.JoinLicenseAssets
{
    public class CreateModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public CreateModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public JoinLicenseAsset JoinLicenseAsset { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.JoinLicenseAsset.Add(JoinLicenseAsset);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}