using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Cicioc_Daniela_Naomi.Data;
using Proiect_Cicioc_Daniela_Naomi.Models;

namespace Proiect_Cicioc_Daniela_Naomi.Pages.LaboratorCRUD
{
    public class DetailsModel : PageModel
    {
        private readonly Proiect_Cicioc_Daniela_Naomi.Data.Proiect_Cicioc_Daniela_NaomiContext _context;

        public DetailsModel(Proiect_Cicioc_Daniela_Naomi.Data.Proiect_Cicioc_Daniela_NaomiContext context)
        {
            _context = context;
        }

        public Laborator Laborator { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laborator = await _context.Laborator.FirstOrDefaultAsync(m => m.ID == id);
            if (laborator == null)
            {
                return NotFound();
            }
            else
            {
                Laborator = laborator;
            }
            return Page();
        }
    }
}
