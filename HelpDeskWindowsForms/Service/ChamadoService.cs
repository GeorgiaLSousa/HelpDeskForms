using HelpDeskWindowsForms.Model;
using HelpDeskWindowsForms.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDeskWindowsForms.Service
{
    public class ChamadoService
    {
        private readonly ChamadoRepository _chamadoRepository;

        public ChamadoService(ChamadoRepository chamadoRepository)
        {
            _chamadoRepository = chamadoRepository;
        }

        public void CriarChamado(Chamado chamado)
        {
            if (string.IsNullOrWhiteSpace(chamado.Titulo))
                throw new Exception("Informe o título.");

            if (string.IsNullOrWhiteSpace(chamado.Descricao))
                throw new Exception("Informe a descrição.");

            if (string.IsNullOrWhiteSpace(chamado.Prioridade))
                throw new Exception("Informe a prioridade.");

            if (string.IsNullOrWhiteSpace(chamado.Categoria))
                throw new Exception("Informe a categoria.");

            chamado.Status = "Aberto";
            chamado.DataAbertura = DateTime.Now;

            _chamadoRepository.SalvarChamado(chamado);
        }

        public List<Chamado> ObterChamadosPorUsuario(int usuarioId)
        {
            return _chamadoRepository.ObterChamadosPorUsuario(usuarioId);
        }

        public List<Chamado> ObterTodosChamados()
        {
            return _chamadoRepository.ObterTodosChamados();
        }
    }
}
