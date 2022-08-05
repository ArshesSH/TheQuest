using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    class Mace : Weapon
    {
        public Mace( Game game, PointVec pos )
            :
            base( game, new Status( 0, 6, 0, 6 * game.TileSize ), pos, 1, false )
        { }

        public override string Name { get { return "Mace"; } }
        public override void Effect( PointVec dir, Random random )
        {
            DamageEnemy( PointVec.DirLeft, status.Range, status.Damage, random );
            DamageEnemy( PointVec.DirUp, status.Range, status.Damage, random );
            DamageEnemy( PointVec.DirRight, status.Range, status.Damage, random );
            DamageEnemy( PointVec.DirDown, status.Range, status.Damage, random );
        }
    }
}
