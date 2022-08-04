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
        private const int attackRange = 1;
        private const int searchRange = 5;

        public Ghoul( Game game, PointVec pos )
         :
        base( game, new Status( maxHP, damage, speed * game.TileSize, attackRange * game.TileSize), pos, searchRange * game.TileSize)
        { }

        public override void Move( Random random )
        {
            PointVec playerDir = FindPlayerDir( game.GamePlayer.Pos );

            if( status.HitPoint == 1)
            {
                if ( random.Next( 0, 3 ) < 2 )
                {
                    game.GamePlayer.Damaged( status.Damage, random );
                }
            }

            if ( IsNearby((pos - game.GamePlayer.Pos), status.Range ) )
            {
                base.Move( playerDir );
            }
        }
    }
}
