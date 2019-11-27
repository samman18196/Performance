using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Pages.Points
{
    public class DetailsModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public DetailsModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        public Point Point { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Point = await _context.Point.FirstOrDefaultAsync(m => m.PointID == id);

            if (Point == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
