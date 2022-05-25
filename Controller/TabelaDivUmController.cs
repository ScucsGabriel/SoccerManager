using SoccerManager.DAO;
using SoccerManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManager.Controller
{
    public class TabelaDivUmController
    {
        public TabelaDivUm InserirTabelaDivUm(List<Sorteio> sorteiosSelecionados)
        {
            return new TabelaDivUmDB().InserirTabelaDivUm(sorteiosSelecionados);
        }
        public TabelaDivUm ExcluirTabelaDivUm()
        {
            return new TabelaDivUmDB().ExcluirTabelaDivUm();
        }
        public List<TabelaDivUm> GerarTabelaDiv1()
        {
            return new TabelaDivUmDB().GerarTabelaDiv1();
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