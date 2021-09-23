using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Project_Crud.Data;
using Project_Crud.Models;

namespace Project_Crud.Pages.Livros
{
    public class IndexModel : PageModel
    {
        private readonly Project_Crud.Data.Project_CrudContext _context;

        public IndexModel(Project_Crud.Data.Project_CrudContext context)
        {
            _context = context;
        }

        public IList<Livro> Livro { get;set; }

        public async Task OnGetAsync()
        {
            Livro = await _context.Livro.ToListAsync();
        }
    }
}
