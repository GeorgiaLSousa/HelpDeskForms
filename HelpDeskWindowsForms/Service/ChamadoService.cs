using HelpDeskWindowsForms.Model;
using HelpDeskWindowsForms.Repositories;
using System;
using System.Collections.Generic;

namespace HelpDeskWindowsForms.Service
{
    public class ChamadoService
    {
        private readonly ChamadoRepositories chamadoRepositories;

        public ChamadoService(ChamadoRepositories chamadoRepositories)
        {
            this.chamadoRepositories = chamadoRepositories;
        }

        public void CriarChamado(Chamado chamado)
        {
            if (SessaoUsuario.UsuarioLogado == null)
            {
                throw new Exception("Usuário não está logado.");
            }

            chamado.Solicitante = SessaoUsuario.UsuarioLogado;
            chamado.Status = StatusChamado.Aberto;

            chamadoRepositories.SalvarChamado(chamado);
        }

        public List<Chamado> ListarChamadosAbertos()
        {
            return chamadoRepositories.chamadoAberto();
        }

        public List<Chamado> ListarChamadosAnalista()
        {
            if (SessaoUsuario.UsuarioLogado == null)
            {
                throw new Exception("Usuário não está logado.");
            }

            return chamadoRepositories.chamadoAnalista(SessaoUsuario.UsuarioLogado);
        }

        public List<Chamado> ListaChamadoUsuario()
        {
            if (SessaoUsuario.UsuarioLogado == null)
            {
                throw new Exception("Usuário não está logado.");
            }

            return chamadoRepositories.chamadoUsuario(SessaoUsuario.UsuarioLogado);
        }

        public List<Chamado> TodosChamados()
        {
            if (SessaoUsuario.UsuarioLogado == null)
            {
                throw new Exception("Usuário não está logado.");
            }

            return chamadoRepositories.todosChamados(SessaoUsuario.UsuarioLogado);
        }

        public void AtualizarChamado(Chamado chamado)
        {
            if (SessaoUsuario.UsuarioLogado == null)
            {
                throw new Exception("Usuário não está logado.");
            }

            chamadoRepositories.AtualizarChamado(chamado, SessaoUsuario.UsuarioLogado);
        }

        public Chamado DetalhesChamado(long id)
        {
            if (id <= 0)
            {
                throw new Exception("ID de chamado inválido.");
            }

            return chamadoRepositories.DetalhesChamado(id);
        }

        public Chamado AtenderChamado(long id)
        {
            if (SessaoUsuario.UsuarioLogado == null)
            {
                throw new Exception("Usuário não está logado.");
            }

            if (id <= 0)
            {
                throw new Exception("ID de chamado inválido.");
            }

            return chamadoRepositories.atenderChamado(id, SessaoUsuario.UsuarioLogado);
        }

        // MÉTODOS ADICIONADOS PARA SUA UI

        public List<Chamado> ObterTodosChamados()
        {
            return TodosChamados();
        }

        public List<Chamado> ObterChamadosPorUsuario()
        {
            return ListaChamadoUsuario();
        }
    }
}