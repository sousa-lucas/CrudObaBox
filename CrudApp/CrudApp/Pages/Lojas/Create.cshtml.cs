using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CrudApp.Data;
using CrudApp.Models;

namespace CrudApp.Pages.Lojas
{
    public class CreateModel : PageModel
    {
        private readonly CrudApp.Data.CrudAppContext _context;

        public CreateModel(CrudApp.Data.CrudAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Loja Loja { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Loja.Add(Loja);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
