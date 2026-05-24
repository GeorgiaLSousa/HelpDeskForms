using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace HelpDeskWindowsForms.Model
{
    public class Chamado
    {
        public int Id { get; set; }

        public required string Titulo { get; set; }

        public required string Descricao { get; set; }

        public required string Prioridade { get; set; }

        public required string Categoria { get; set; }

        public required string Status { get; set; }

       public required DateTime DataAbertura { get; set; }

       public int UsuarioId { get; set; }
       
        public Usuario? Usuario { get; set; }

    }

    public enum Prioridade
    {
        Baixa,
        Media,
        Alta
    }

    public enum Categoria
    {
        Software,
        Hardware,
        Rede,
        Outro
    }

}