using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCG
{
    [Serializable]
    public class Goals
    {
        public string type { get; set; }    // POSITION, POINTS, TIME
        public string points { get; set; }
        public string ranking { get; set; }
        public string tier_1 { get; set; }  // Bronze medal
        public string tier_2 { get; set; }  // Silver medal
        public string tier_3 { get; set; }  // Gold medal

        public Goals() 
        {
            this.type = "";
            this.points = "";
            this.ranking = "";
            this.tier_1 = "";
            this.tier_2 = "";
            this.tier_3 = "";
        
        }
        

    }
}
