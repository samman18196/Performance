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
    public class DetailsModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public DetailsModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

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
    }
}
