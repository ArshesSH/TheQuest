using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    abstract class Potion : Item
    {
        public Potion( Game game, Status status, PointVec pos, int count )
            :
        base( game, status, pos, count, true )
        { }
        public override void Effect( PointVec dir, Random random )
        {
            game.GamePlayer.IncreaseHealth( status.Damage, random );
        }
    }
}
