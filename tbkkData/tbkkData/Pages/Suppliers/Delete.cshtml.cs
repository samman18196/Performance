﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Pages.Suppliers
{
    public class DeleteModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public DeleteModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Supplier Supplier { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Supplier = await _context.Supplier.FirstOrDefaultAsync(m => m.SupplierID == id);

            if (Supplier == null)
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

            Supplier = await _context.Supplier.FindAsync(id);

            if (Supplier != null)
            {
                _context.Supplier.Remove(Supplier);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
