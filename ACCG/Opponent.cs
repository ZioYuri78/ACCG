using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCG
{
    [Serializable]
    public class Opponent
    {

        public int ID { get; set; }
        public Car model { get; set; }
        public string setup { get; set; }
        public int ai_level { get; set; }
        public string skin { get; set; }
        public string name { get; set; }
        public string nationality { get; set; }

        public Opponent() 
        {

        }



    }
}
