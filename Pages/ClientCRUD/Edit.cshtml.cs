﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proiect_Cicioc_Daniela_Naomi.Data;
using Proiect_Cicioc_Daniela_Naomi.Models;

namespace Proiect_Cicioc_Daniela_Naomi.Pages.ClientCRUD
{
    public class EditModel : PageModel
    {
        private readonly Proiect_Cicioc_Daniela_Naomi.Data.Proiect_Cicioc_Daniela_NaomiContext _context;

        public EditModel(Proiect_Cicioc_Daniela_Naomi.Data.Proiect_Cicioc_Daniela_NaomiContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Client Client { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client =  await _context.Client.FirstOrDefaultAsync(m => m.ID == id);
            if (client == null)
            {
                return NotFound();
            }
            Client = client;
           ViewData["AnalizeID"] = new SelectList(_context.Analiza, "ID", "Denumire_Analiza");
           ViewData["LaboratorID"] = new SelectList(_context.Laborator, "ID", "Adresa_Laborator");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Client).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientExists(Client.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ClientExists(int id)
        {
            return _context.Client.Any(e => e.ID == id);
        }
    }
}
