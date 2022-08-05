using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    class Wizard : Enemy
    {
        private const int maxHP = 5;
        private const int damage = 6;
        private const int speed = 1;

        public Wizard( Game game, PointVec pos )
         :
        base( game, new Status( maxHP, damage, speed * game.TileSize, 10 * game.TileSize), pos, 20 * game.TileSize)
        { }

        public override void Move( Random random )
        {
            PointVec playerDir = FindPlayerDir( game.GamePlayer.Pos );
            if ( IsPlayerInRange( SerachDistance ) )
            {
                base.Move( playerDir );
                if( IsPlayerInRange( status.Range ) )
                {
                    game.GamePlayer.Damaged( status.Damage, random );
                }
            }
            else if ( random.Next( 0, 2 ) == 0 )
            {
                PointVec.GetRandomDir( random );
            }
            else
            {
                base.Move( playerDir );
            }
        }
    }
}
