using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    class Ghoul : Enemy
    {
        private const int maxHP = 10;
        private const int damage = 4;
        private const int speed = 1;

        public Ghoul( Game game, PointVec pos )
         :
        base( game, new Status( maxHP, damage, speed * game.TileSize, 1 * game.TileSize), pos, 5 * game.TileSize)
        { }

        public override void Move( Random random )
        {
            PointVec playerDir = FindPlayerDir( game.GamePlayer.Pos );

            if( status.HitPoint >= 1)
            {
                if ( random.Next( 0, 3 ) < 2 )
                {
                    if( IsPlayerInRange (SerachDistance))
                    {
                        base.Move( playerDir );
                    }
                    if ( IsPlayerInRange( status.Range ) )
                    {
                        game.GamePlayer.Damaged( status.Damage, random );
                    }
                }
            }
        }
    }
}
