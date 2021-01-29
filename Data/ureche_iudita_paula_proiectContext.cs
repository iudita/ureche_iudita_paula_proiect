using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ureche_iudita_paula_proiect.Models;

namespace ureche_iudita_paula_proiect.Data
{
    public class ureche_iudita_paula_proiectContext : DbContext
    {
        public ureche_iudita_paula_proiectContext (DbContextOptions<ureche_iudita_paula_proiectContext> options)
            : base(options)
        {
        }

        public DbSet<ureche_iudita_paula_proiect.Models.Banca> Banca { get; set; }

        public DbSet<ureche_iudita_paula_proiect.Models.Client> Client { get; set; }

        public DbSet<ureche_iudita_paula_proiect.Models.Serviciu> Serviciu { get; set; }
    }
}
