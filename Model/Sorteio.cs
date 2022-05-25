using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManager.Model
{
    public class Sorteio
    {
        public int idSorteio { get; set; }
        public int idSorteioUsuario { get; set; }
        public int idSorteioTime { get; set; }
        public int divisao { get; set; }
        public int contagemDivisao { get; set; }
        public int contagemTime { get; set; }
        public int contagemUsuario { get; set; }
        public Usuario usuario { get; set; }
        public Time time { get; set; }
        public Sorteio()
        {
            this.usuario = new Usuario();
            this.time = new Time();
        }
    }
}
