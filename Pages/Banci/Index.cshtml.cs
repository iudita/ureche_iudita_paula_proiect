﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ureche_iudita_paula_proiect.Data;
using ureche_iudita_paula_proiect.Models;

namespace ureche_iudita_paula_proiect.Pages.Banci
{
    public class IndexModel : PageModel
    {
        private readonly ureche_iudita_paula_proiect.Data.ureche_iudita_paula_proiectContext _context;

        public IndexModel(ureche_iudita_paula_proiect.Data.ureche_iudita_paula_proiectContext context)
        {
            _context = context;
        }

        public IList<Banca> Banca { get;set; }

        public async Task OnGetAsync()
        {
            Banca = await _context.Banca.ToListAsync();
        }
    }
}
