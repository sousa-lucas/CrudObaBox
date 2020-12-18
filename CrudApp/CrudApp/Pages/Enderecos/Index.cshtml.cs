using System;
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
    public class IndexModel : PageModel
    {
        private readonly CrudApp.Data.CrudAppContext _context;

        public IndexModel(CrudApp.Data.CrudAppContext context)
        {
            _context = context;
        }

        public IList<Endereco> Endereco { get;set; }

        public async Task OnGetAsync()
        {
            Endereco = await _context.Endereco.ToListAsync();
        }
    }
}
