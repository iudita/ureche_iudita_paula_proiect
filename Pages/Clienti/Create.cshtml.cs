﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ureche_iudita_paula_proiect.Data;
using ureche_iudita_paula_proiect.Models;

namespace ureche_iudita_paula_proiect.Pages.Clienti
{
    public class CreateModel : PageModel
    {
        private readonly ureche_iudita_paula_proiect.Data.ureche_iudita_paula_proiectContext _context;

        public CreateModel(ureche_iudita_paula_proiect.Data.ureche_iudita_paula_proiectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Client Client { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Client.Add(Client);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}