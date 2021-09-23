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
    public class DeleteModel : PageModel
    {
        private readonly Project_Crud.Data.Project_CrudContext _context;

        public DeleteModel(Project_Crud.Data.Project_CrudContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Livro Livro { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Livro = await _context.Livro.FirstOrDefaultAsync(m => m.Id_Livro == id);

            if (Livro == null)
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

            Livro = await _context.Livro.FindAsync(id);

            if (Livro != null)
            {
                _context.Livro.Remove(Livro);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
