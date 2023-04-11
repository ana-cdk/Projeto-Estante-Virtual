using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Livro
    {
        public string Titulo { get; set; }
        public Guid? LivroID { get; set; }
        public string Autor { get; set; }
        public int Paginas { get; set; }
        public string Status { get; set; }
        public int Nota { get; set; }
        public string Favorito { get; set; }
        public Guid? UsuarioID { get; set; }


        public Livro(string titulo, string autor, int paginas, string status, int nota, string favorito,
            Guid? usuarioID = null, Guid? livroID = null)
        {
            Titulo = titulo;
            Autor = autor;
            Paginas = paginas;
            Status = status;
            Nota = nota;
            Favorito = favorito;
            LivroID = livroID;
            UsuarioID = usuarioID;
        }
      
    }
}
