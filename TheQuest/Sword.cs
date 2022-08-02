using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    class Sword : Weapon
    {        
        public Sword(Game game, PointVec pos )
            :
            base(game, new Status( 0, 3, 0, 10 ), pos, 1, false )
        { }

        public override string Name { get { return "Sword"; } }
        public override void Effect( PointVec dir, Random random )
        {
            
        }
    }
}
