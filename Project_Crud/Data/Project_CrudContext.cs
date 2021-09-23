using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_Crud.Models;

namespace Project_Crud.Data
{
    public class Project_CrudContext : DbContext
    {
        public Project_CrudContext (DbContextOptions<Project_CrudContext> options)
            : base(options)
        {
        }

        public DbSet<Project_Crud.Models.Livro> Livro { get; set; }
    }
}
