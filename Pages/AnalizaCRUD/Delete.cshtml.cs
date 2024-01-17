﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Cicioc_Daniela_Naomi.Data;
using Proiect_Cicioc_Daniela_Naomi.Models;

namespace Proiect_Cicioc_Daniela_Naomi.Pages.AnalizaCRUD
{
    public class DeleteModel : PageModel
    {
        private readonly Proiect_Cicioc_Daniela_Naomi.Data.Proiect_Cicioc_Daniela_NaomiContext _context;

        public DeleteModel(Proiect_Cicioc_Daniela_Naomi.Data.Proiect_Cicioc_Daniela_NaomiContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Analiza Analiza { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var analiza = await _context.Analiza.FirstOrDefaultAsync(m => m.ID == id);

            if (analiza == null)
            {
                return NotFound();
            }
            else
            {
                Analiza = analiza;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var analiza = await _context.Analiza.FindAsync(id);
            if (analiza != null)
            {
                Analiza = analiza;
                _context.Analiza.Remove(Analiza);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
