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
        public string spawn_set { get; set;}
        public int duration_minutes { get; set; }
        public int laps { get; set; }


        public Session()
        {

        }
    }
}
