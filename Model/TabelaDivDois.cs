using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManager.Model
{
    public class TabelaDivDois
    {
        public int idTabelaDivDois { get; set; }
        public int idTabelaDivDoisSorteio { get; set; }
        public Sorteio sorteio { get; set; }
        public Usuario usuario { get; set; }
        public Time time { get; set; }
        public TabelaDivDois()
        {
            this.sorteio = new Sorteio();
            this.usuario = new Usuario();
            this.time = new Time();
        }
    }
}
