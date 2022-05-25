using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManager.Model
{
    public class Time
    {
        public int idTime { get; set; }
        public string time { get; set; }
        public string timeAtivo { get; set; }
        public override string ToString()
        {
            return this.time;
        }
    }
}
