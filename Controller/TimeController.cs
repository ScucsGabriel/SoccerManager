using SoccerManager.DAO;
using SoccerManager.Model;
using System.Collections.Generic;

namespace SoccerManager.Controller
{
    public class TimeController
    {
        public Time InserirTime(string time, string timeAtivo)
        {
            return new TimeDB().InserirTime(time, timeAtivo);
        }

        public List<Time> ConsultarTime(string time)
        {
            return new TimeDB().ConsultarTime(time);
        }
        public List<Time> ConsultarTimePorId(int idTime)
        {
            return new TimeDB().ConsultarTimePorId(idTime);
        }
        public List<Time> ConsultarTodoTime()
        {
            return new TimeDB().ConsultarTodoTime();
        }
        public List<Time> ConsultarTodoTimeAtivo()
        {
            return new TimeDB().ConsultarTodoTimeAtivo();
        }

        public Time ExcluirTime(int idTime)
        {
            return new TimeDB().ExcluirTime(idTime);
        }

        public List<Time> EditarTime(int idTime, string time, string timeAtivo)
        {
            return new TimeDB().EditarTime(idTime, time, timeAtivo);
        }
    }
}
