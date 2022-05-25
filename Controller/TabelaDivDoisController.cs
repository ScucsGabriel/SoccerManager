using SoccerManager.DAO;
using SoccerManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManager.Controller
{
    public class TabelaDivDoisController
    {
        public TabelaDivDois InserirTabelaDivDois(List<Sorteio> sorteiosSelecionadosDivDois)
        {
            return new TabelaDivDoisDB().InserirTabelaDivDois(sorteiosSelecionadosDivDois);
        }
        public TabelaDivDois ExcluirTabelaDivDois()
        {
            return new TabelaDivDoisDB().ExcluirTabelaDivDois();
        }
        public List<TabelaDivDois> GerarTabelaDiv2()
        {
            return new TabelaDivDoisDB().GerarTabelaDiv2();
        }
        public List<Sorteio> ConsultarTodoSorteio()
        {
            return new SorteioDB().ConsultarTodoSorteio();
        }
        public Sorteio ContarSorteioPorDivisao(int divisao)
        {
            return new SorteioDB().ContarSorteioPorDivisao(divisao);
        }
        public Sorteio ConsultarSorteioPorTime(int idTime)
        {
            return new SorteioDB().ConsultarSorteioPorTime(idTime);
        }
        public Sorteio ConsultarSorteioPorUsuario(int idUsu)
        {
            return new SorteioDB().ConsultarSorteioPorUsuario(idUsu);
        }
    }
}