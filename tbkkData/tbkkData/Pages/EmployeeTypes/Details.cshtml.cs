﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Pages.EmployeeTypes
{
    public class DetailsModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public DetailsModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        public EmployeeType EmployeeType { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EmployeeType = await _context.EmployeeType.FirstOrDefaultAsync(m => m.EmployeeTypeID == id);

            if (EmployeeType == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
