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

        public Ghost( Game game, PointVec pos )
         :
        base( game, new Status( maxHP, damage, speed * game.TileSize, 1 * game.TileSize), pos, 5 * game.TileSize)
        { }

        public override void Move( Random random )
        {
            if ( IsPlayerInRange( status.Range ) )
            {
                game.GamePlayer.Damaged( status.Damage, random );
            }
            else if( random.Next( 0, 3 ) < 1 )
            {
                PointVec playerDir = FindPlayerDir( game.GamePlayer.Pos );
                base.Move( playerDir );
            }
        }
    }
}
