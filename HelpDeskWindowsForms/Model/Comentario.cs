using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskWindowsForms.Model
{
    public class Comentario
    {
        public int Id { get; set; }
        public required string Texto { get; set; }
        public DateTime DataComentario { get; set; }

        public int ChamadoId { get; set; }
        public Chamado? Chamado { get; set; }

        public int AutorId { get; set; }
        public Usuario? Autor { get; set; }
    }
}