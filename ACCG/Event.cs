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
        public List<Opponent> opponents_list { get; set; }   // Only for single events (quick race)
        public int ID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int ambient_temperature { get; set; }
        public string weather { get; set; }
        public int time { get; set; }
        public bool practice { get; set; }  // Only for championship events
        public bool qualifying { get; set; }    // Only for championship events
        public string track { get; set; }
        public string track_layout { get; set; }
        public int numberOfCars { get; set; }   // Only for single events (quick race) or campionship events
        public int numberOfLaps { get; set; }   // Only for single events (quick race)
        public int start_position { get; set; } // Only for single events (quick race)
        public bool penalties { get; set; }
        public bool isEdited { get; set; }
        public bool isTimeAttack { get; set; }  // Only for single events
        public bool isQuickRace { get; set; }   // Only for single events
        public bool isHotlap { get; set; }      // Only for single events
        public int dynamic_track_preset { get; set; }
        public Bitmap previewImage { get; set; } // 250x125
        public Car event_car { get; set; }  // Only for single events
        public Skin event_car_skin { get; set; }    // Only for single events
        public Goals event_goals { get; set; }  // Only for single events
        
       

        public Event()
        {
            this.session_list = new List<Session>();
            this.opponents_list = new List<Opponent>();
            //this.previewImage = new Bitmap("");
            this.event_car = new Car();
            this.event_car_skin = new Skin();
            this.event_goals = new Goals();
        }

       
        
    }
}
