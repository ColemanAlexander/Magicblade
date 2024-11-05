using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magicblade
{
    public class Player
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Energy { get; set; }
        public Deck Deck { get; set; }
        public int BuffMultiplier { get; set; } = 1;
        public int DeBuffMultiplier { get; set; } = 1;

        public List<Card> Hand { get; set; }

        public void Draw() {
            
        }

    }
}
