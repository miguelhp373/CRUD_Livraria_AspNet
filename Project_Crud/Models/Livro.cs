using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Crud.Models
{
    public class Livro
    {
        [Key]//anotação para identificar a chave primária
        public int Id_Livro { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Editora { get; set; }
        public int Isbn { get; set; }
        public int Ano { get; set; }
        [Required]
        public string Autor { get; set; }
        public double Preco { get; set; }
        public string Categoria { get; set; }
    }
}
