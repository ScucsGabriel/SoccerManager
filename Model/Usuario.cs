using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManager.Model
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string nomeUsuario { get; set; }
        public string emailUsuario { get; set; }
        public string telefoneUsuario { get; set; }
        public string usuarioAtivo { get; set; }

        public override string ToString()
        {
            return this.nomeUsuario + " - " + this.emailUsuario;
        }
    }
}
