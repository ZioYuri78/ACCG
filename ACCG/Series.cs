using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCG
{
    [Serializable]
    public class Series
    {

        public List<Event> events_list { get; set; }
        public List<Opponent> opponents_list { get; set; }  // Only for championship
        public int events_gloabl_ID { get; set; }
        public int ID { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string requires { get; set; }
        public string points { get; set; }
        public Car model { get; set; }
        public string skin { get; set; }
        public string goalsPoints { get; set; } //placeholder
        public bool isGenerated { get; set; }
        public bool isEdited { get; set; }
        

        public Series()
        {
            this.events_list = new List<Event>();
        }

        public Series(int ID, string code, string name, string description, string requires, string points)
        {
            this.events_list = new List<Event>();
            this.ID = ID;
            this.code = code;
            this.name = name;
            this.description = description;
            this.requires = requires;
            this.points = points;
            
        }
    }
}
