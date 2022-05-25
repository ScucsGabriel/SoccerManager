using SoccerManager.DAO;
using SoccerManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManager.Controller
{
    public class SorteioController
    {
        public Sorteio InserirSorteio(int idUsu, int idTime, int divisao)
        {
            return new SorteioDB().InserirSorteio(idUsu, idTime, divisao);
        }
        public List<Sorteio> ConsultarTodoSorteio()
        {
            return new SorteioDB().ConsultarTodoSorteio();
        }
        public Sorteio ContarSorteioPorDivisao(int divisao)
        {
            return new SorteioDB().ContarSorteioPorDivisao(divisao);
        }
        public List<Sorteio> ContarSorteioDiv1()
        {
            return new SorteioDB().ContarSorteioDiv1();
        }
        public List<Sorteio> ContarSorteioDiv2()
        {
            return new SorteioDB().ContarSorteioDiv2();
        }
        public Sorteio ConsultarSorteioPorTime(int idTime)
        {
            return new SorteioDB().ConsultarSorteioPorTime(idTime);
        }
        public Sorteio ConsultarSorteioPorUsuario(int idUsu)
        {
            return new SorteioDB().ConsultarSorteioPorUsuario(idUsu);
        }
        public Sorteio ExcluirSorteio()
        {
            return new SorteioDB().ExcluirSorteio();
        }
    }
}
