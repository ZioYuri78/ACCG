using System;
using System.Collections.Generic;
using System.Drawing;
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
        public int ID { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string requires { get; set; }
        public string points { get; set; }
        public Car car { get; set; }
        public Skin skin { get; set; }
        public Goals series_goals { get; set; }
        //public string goalsPoints { get; set; } //placeholder
        public bool isGenerated { get; set; }
        public bool isEdited { get; set; }
        public bool isSingleEvents { get; set; }
        public bool isChampionship { get; set; }
        public Bitmap previewImage { get; set; } // 206x206
        public Bitmap startImage { get; set; }   // 1240x560
        

        public Series()
        {
            this.events_list = new List<Event>();
            this.skin = new Skin();
            this.series_goals = new Goals();
        }

        
    }
}
