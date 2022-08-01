using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class Bat : Enemy
    {
        private const int maxHP = 6;
        private const int damage = 2;
        private const int speed = 1;
        private const int range = 1;

        public Bat(Game game, PointVec pos)
            :
            base(game, new Status(maxHP, damage, speed, range ), pos, 5 )
        { }

        public override void Move(Random random)
        {
            PointVec playerDir = FindPlayerDir( game.GamePlayer.Pos );
            if ( random.Next( 1, 3 ) % 2 == 0 )
            {
                PointVec.GetRandomDir( random );
            }
            else
            {
                base.Move( playerDir );
            }

            if ( IsNearby( game.GamePlayer.Pos, status.Range ) )
            {
                Attack( playerDir, game.GamePlayer, random );
            }
        }
    }
}
