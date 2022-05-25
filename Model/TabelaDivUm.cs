using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManager.Model
{
    public class TabelaDivUm
    {
        public int idTabelaDivUm { get; set; }
        public int idTabelaDivUmSorteio { get; set; }
        public Sorteio sorteio { get; set; }
        public Usuario usuario { get; set; }
        public Time time { get; set; }
        public TabelaDivUm()
        {
            this.sorteio = new Sorteio();
            this.usuario = new Usuario();
            this.time = new Time();
        }
    }
}
