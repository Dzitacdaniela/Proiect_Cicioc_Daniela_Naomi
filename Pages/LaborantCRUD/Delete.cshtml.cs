using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Cicioc_Daniela_Naomi.Data;
using Proiect_Cicioc_Daniela_Naomi.Models;

namespace Proiect_Cicioc_Daniela_Naomi.Pages.LaborantCRUD
{
    public class DeleteModel : PageModel
    {
        private readonly Proiect_Cicioc_Daniela_Naomi.Data.Proiect_Cicioc_Daniela_NaomiContext _context;

        public DeleteModel(Proiect_Cicioc_Daniela_Naomi.Data.Proiect_Cicioc_Daniela_NaomiContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Laborant Laborant { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laborant = await _context.Laborant.FirstOrDefaultAsync(m => m.ID == id);

            if (laborant == null)
            {
                return NotFound();
            }
            else
            {
                Laborant = laborant;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laborant = await _context.Laborant.FindAsync(id);
            if (laborant != null)
            {
                Laborant = laborant;
                _context.Laborant.Remove(Laborant);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
