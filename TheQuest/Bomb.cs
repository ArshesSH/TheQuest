using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    class Bomb : Item
    {
        private int remainTime = 5;
        public Bomb( Game game, PointVec pos, int count )
            :
        base( game, new Status(0,10,0,5*game.TileSize), pos, count, true )
        { }
        public override string Name { get { return "Bomb"; } }
        public override void Effect( PointVec dir, Random random )
        {

        }

    }
}
