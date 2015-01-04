using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCG
{
    [Serializable]
    public class Session
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int type { get; set; }   
        /*
         *  PRACTICE = 1 
         *  QUALIFY = 2
         *  RACE = 3
         *  HOTLAP = 4
         *  TIMEATTACK = 5
         *  DRIFT = 6
         *  DRAG = 7
        */
        public string spawn_set { get; set;}
        public int duration_minutes { get; set; }
        public int laps { get; set; }


        public Session()
        {
            this.duration_minutes = 0;
            this.laps = 0;
        }
    }
}
