using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCG
{
    [Serializable]
    public class Skin
    {
        public string skin_name { get; set; }
        public Bitmap skin_preview { get; set; }

        public Skin() { }

    }
}
