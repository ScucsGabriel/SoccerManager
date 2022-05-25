using SoccerManager.DAO;
using SoccerManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManager.Controller
{
    public class UsuarioController
    {
        public Usuario InserirUsuario(string nomeUsuario, string emailUsuario, string telefoneUsuario, string usuarioAtivo)
        {
            return new UsuarioDB().InserirUsuario(nomeUsuario, emailUsuario, telefoneUsuario, usuarioAtivo);
        }

        public List<Usuario> ConsultarUsuarioPorNome(string nomeUsuario)
        {
            return new UsuarioDB().ConsultarUsuarioPorNome(nomeUsuario);
        }

        public List<Usuario> ConsultarUsuarioPorEmail(string emailUsuario)
        {
            return new UsuarioDB().ConsultarUsuarioPorEmail(emailUsuario);
        }
        public List<Usuario> ConsultarUsuarioPorId(int idUsuario)
        {
            return new UsuarioDB().ConsultarUsuarioPorId(idUsuario);
        }
        public List<Usuario> ConsultarTodoUsuario()
        {
            return new UsuarioDB().ConsultarTodoUsuario();
        }
        public List<Usuario> ConsultarTodoUsuarioAtivo()
        {
            return new UsuarioDB().ConsultarTodoUsuarioAtivo();
        }

        public Usuario ExcluirUsuario(int idUsuario)
        {
            return new UsuarioDB().ExcluirUsuario(idUsuario);
        }

        public List<Usuario> EditarUsuario(int idUsuario, string nomeUsuario, string emailUsuario, string telefoneUsuario, string usuarioAtivo)
        {
            return new UsuarioDB().EditarUsuario(idUsuario, nomeUsuario, emailUsuario, telefoneUsuario, usuarioAtivo);
        }
    }
}
