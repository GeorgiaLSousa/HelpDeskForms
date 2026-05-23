using HelpDeskWindowsForms.Model;
using HelpDeskWindowsForms.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDeskWindowsForms.Service
{
    public class UsuarioService
    {

        public readonly UsuarioRepository usuarioRepository;

        public UsuarioService(UsuarioRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }

        public void CriarUsuario(Usuario usuario)
        {
            if (!usuario.Email.Contains("@"))
            {
                throw new Exception("Email inválido. O email deve conter '@'.");
            }

            else if (usuario.Senha.Length < 8)
            {
                throw new Exception("A senha deve ter no mínimo 8 caracteres.");
            }

            usuarioRepository.SalvarUsuario(usuario);
        }

        public Usuario Login(string email, string senha)
        {
            return usuarioRepository.Login(email, senha);
        }

    }
}
