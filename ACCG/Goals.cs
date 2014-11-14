using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCG
{
    [Serializable]
    class Goals
    {
        public int points { get; set; }
        public int tier_1 { get; set; }
        public int tier_2 { get; set; }
        public int tier_3 { get; set; }

        public Goals()
        {

        }

        public Goals(int points, int tier_1, int tier_2, int tier_3)
        {
            this.points = points;
            this.tier_1 = tier_1;
            this.tier_2 = tier_2;
            this.tier_3 = tier_3;
        }


    }
}
