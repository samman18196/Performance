﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Pages.Repairs
{
    public class DeleteModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public DeleteModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Repair Repair { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Repair = await _context.Repair.FirstOrDefaultAsync(m => m.RepairID == id);

            if (Repair == null)
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

            Repair = await _context.Repair.FindAsync(id);

            if (Repair != null)
            {
                _context.Repair.Remove(Repair);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
