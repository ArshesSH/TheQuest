using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    class Ghost : Enemy
    {
        private const int maxHP = 8;
        private const int damage = 3;
        private const int speed = 1;
        private const int attackRange = 1;
        private const int searchRange = 5;

        public Ghost( Game game, PointVec pos )
         :
        base( game, new Status( maxHP, damage, speed * game.TileSize, attackRange * game.TileSize), pos, searchRange * game.TileSize)
        { }

        public override void Move( Random random )
        {
            PointVec playerDir = FindPlayerDir( game.GamePlayer.Pos );
            if ( random.Next( 0, 3 ) < 1 )
            {
                base.Move( playerDir );
            }

            if ( IsNearby((pos - game.GamePlayer.Pos), status.Range ) )
            {
                game.GamePlayer.Damaged( status.Damage, random );
            }
        }
    }
}
