using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCG
{
    [Serializable]
    public class Car
    {
        public string model { get; set; }
        public List<string> skins = new List<string>();

        public Car()
        {

        }

        public Car(string model, List<string> skins)
        {
            this.model = model;
            this.skins = skins;
        }
    }
}
