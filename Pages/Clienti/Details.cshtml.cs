﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ureche_iudita_paula_proiect.Data;
using ureche_iudita_paula_proiect.Models;

namespace ureche_iudita_paula_proiect.Pages.Clienti
{
    public class DetailsModel : PageModel
    {
        private readonly ureche_iudita_paula_proiect.Data.ureche_iudita_paula_proiectContext _context;

        public DetailsModel(ureche_iudita_paula_proiect.Data.ureche_iudita_paula_proiectContext context)
        {
            _context = context;
        }

        public Client Client { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Client = await _context.Client.FirstOrDefaultAsync(m => m.ID == id);

            if (Client == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
