using HelpDeskWindowsForms.Data;
using HelpDeskWindowsForms.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDeskWindowsForms.Repositories
{
    public class ChamadoRepository
    {
        private readonly AppDbContext _context;
        public ChamadoRepository(AppDbContext context)
        {
            _context = context;
        }
        public void SalvarChamado(Chamado chamado)
        {
            _context.Chamados.Add(chamado);
            _context.SaveChanges();
        }
        public List<Chamado> ObterChamadosPorUsuario(int usuarioId)
        {
            return _context.Chamados
                .Where(chamado => chamado.UsuarioId == usuarioId)
                .ToList();
        }

        public List<Chamado> ObterTodosChamados()
        {
            return _context.Chamados.ToList();
        }
    }

}
