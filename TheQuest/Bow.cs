using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    class Bow : Weapon
    {
        public Bow( Game game, PointVec pos )
            :
            base( game, new Status( 0, 1, 0, 10 * game.TileSize ), pos, 1, false )
        { }

        public override string Name { get { return "Bow"; } }
        public override void Effect( PointVec dir, Random random )
        {
            DamageEnemy( dir, status.Range, status.Damage, random );
        }
    }
}
