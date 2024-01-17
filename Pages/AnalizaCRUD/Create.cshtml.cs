using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect_Cicioc_Daniela_Naomi.Data;
using Proiect_Cicioc_Daniela_Naomi.Models;

namespace Proiect_Cicioc_Daniela_Naomi.Pages.AnalizaCRUD
{
    public class CreateModel : PageModel
    {
        private readonly Proiect_Cicioc_Daniela_Naomi.Data.Proiect_Cicioc_Daniela_NaomiContext _context;

        public CreateModel(Proiect_Cicioc_Daniela_Naomi.Data.Proiect_Cicioc_Daniela_NaomiContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["LaborantID"] = new SelectList(_context.Laborant, "ID", "Nume_Laborant");
            return Page();
        }

        [BindProperty]
        public Analiza Analiza { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Analiza.Add(Analiza);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
