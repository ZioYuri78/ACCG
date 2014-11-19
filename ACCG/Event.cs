using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCG
{
    [Serializable]
    public class Event
    {
        public List<Session> session_list { get; set; }
        public List<Opponent> opponents_list { get; set; }   // Only for single events
        public int ID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int ambient_temperature { get; set; }
        public int time { get; set; }
        public bool practice { get; set; }
        public bool qualifying { get; set; }
        public string track { get; set; }
        public int numberOfCars { get; set; }
        public bool penalties { get; set; }
        public bool isEdited { get; set; }
        public int dynamic_track_preset { get; set; }
        public Bitmap previewImage { get; set; } // 250x125
        
       

        public Event()
        {

        }

        public Event(int ID, string name, string description)
        {
            this.ID = ID;
            this.name = name;
            this.description = description;
        }
        
    }
}
