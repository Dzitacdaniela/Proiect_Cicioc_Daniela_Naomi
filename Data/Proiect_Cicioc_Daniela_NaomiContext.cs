using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect_Cicioc_Daniela_Naomi.Models;

namespace Proiect_Cicioc_Daniela_Naomi.Data
{
    public class Proiect_Cicioc_Daniela_NaomiContext : DbContext
    {
        public Proiect_Cicioc_Daniela_NaomiContext (DbContextOptions<Proiect_Cicioc_Daniela_NaomiContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect_Cicioc_Daniela_Naomi.Models.Analiza> Analiza { get; set; } = default!;
        public DbSet<Proiect_Cicioc_Daniela_Naomi.Models.Client> Client { get; set; } = default!;
        public DbSet<Proiect_Cicioc_Daniela_Naomi.Models.Laborant> Laborant { get; set; } = default!;
        public DbSet<Proiect_Cicioc_Daniela_Naomi.Models.Laborator> Laborator { get; set; } = default!;
    }
}
