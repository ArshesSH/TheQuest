using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    abstract class Weapon : Item
    {
        public Weapon( Game game, Status status, PointVec pos, int cnt, bool consumable )
            :
            base( game, status, pos, cnt, consumable )
        { }

        protected bool DamageEnemy( PointVec dir, int radius, int damage, Random random )
        {
            for ( int distance = 0; distance < radius; ++distance )
            {
                foreach ( Enemy enemy in game.Enemies )
                {
                    if ( IsNearby( enemy.Pos - game.GamePlayer.Pos, radius ) )
                    {
                        enemy.Damaged( status.Damage, random );
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
