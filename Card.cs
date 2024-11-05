using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magicblade
{
    public class Card
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int Effect { get; set; }

        public int Cost { get; set; }
    }

}
