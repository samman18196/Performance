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
    public class IndexModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public IndexModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        public IList<JoinLicenseAsset> JoinLicenseAsset { get;set; }

        public async Task OnGetAsync()
        {
            JoinLicenseAsset = await _context.JoinLicenseAsset.ToListAsync();
        }
    }
}
