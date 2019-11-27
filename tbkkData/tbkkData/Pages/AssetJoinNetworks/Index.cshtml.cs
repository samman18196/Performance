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
    public class IndexModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public IndexModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        public IList<AssetJoinNetwork> AssetJoinNetwork { get;set; }

        public async Task OnGetAsync()
        {
            AssetJoinNetwork = await _context.AssetJoinNetworks.ToListAsync();
        }
    }
}
