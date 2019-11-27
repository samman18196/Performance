using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Pages.AssetJoinNetworks
{
    public class DeleteModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public DeleteModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AssetJoinNetwork AssetJoinNetwork { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AssetJoinNetwork = await _context.AssetJoinNetworks.FirstOrDefaultAsync(m => m.AssetJoinNetworkID == id);

            if (AssetJoinNetwork == null)
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

            AssetJoinNetwork = await _context.AssetJoinNetworks.FindAsync(id);

            if (AssetJoinNetwork != null)
            {
                _context.AssetJoinNetworks.Remove(AssetJoinNetwork);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
