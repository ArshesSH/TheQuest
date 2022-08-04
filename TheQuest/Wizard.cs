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
        private const int attackRange = 10;
        private const int searchRange = 10;

        public Wizard( Game game, PointVec pos )
         :
        base( game, new Status( maxHP, damage, speed * game.TileSize, attackRange ), pos, searchRange )
        { }

        public override void Move( Random random )
        {
            PointVec playerDir = FindPlayerDir( game.GamePlayer.Pos );

            if ( random.Next( 0, 2 ) == 0 )
            {
                PointVec.GetRandomDir( random );
            }
            else
            {
                base.Move( playerDir );
            }

            if ( IsNearby( game.GamePlayer.Pos, status.Range ) )
            {
                base.Move( playerDir );
            }
        }
    }
}
