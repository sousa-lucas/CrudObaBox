using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CrudApp.Data;
using CrudApp.Models;

namespace CrudApp.Pages.Lojas
{
    public class DetailsModel : PageModel
    {
        private readonly CrudApp.Data.CrudAppContext _context;

        public DetailsModel(CrudApp.Data.CrudAppContext context)
        {
            _context = context;
        }

        public Loja Loja { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Loja = await _context.Loja.FirstOrDefaultAsync(m => m.Id == id);

            if (Loja == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
