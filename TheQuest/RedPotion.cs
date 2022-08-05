using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    class RedPotion : Potion
    {
        public RedPotion(Game game, PointVec pos)
            :
            base(game, new Status(0,10,0,0), pos, 1)
        { }
        public override string Name { get { return "RedPotion"; } }
    }
}
