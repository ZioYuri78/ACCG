using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCG
{
    [Serializable]
    public class Car
    {
        public string model { get; set; }

        public List<Skin> skins { get; set; }
        

        public Car()
        {
            this.model = "";
            this.skins = new List<Skin>();
        }
                
    }
}
