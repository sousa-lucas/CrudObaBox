﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CrudApp.Data;
using CrudApp.Models;

namespace CrudApp.Pages.Enderecos
{
    public class DeleteModel : PageModel
    {
        private readonly CrudApp.Data.CrudAppContext _context;

        public DeleteModel(CrudApp.Data.CrudAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Endereco Endereco { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Endereco = await _context.Endereco.FirstOrDefaultAsync(m => m.Id == id);

            if (Endereco == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Endereco = await _context.Endereco.FindAsync(id);

            if (Endereco != null)
            {
                _context.Endereco.Remove(Endereco);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
