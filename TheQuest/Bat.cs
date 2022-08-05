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

        public Bat(Game game, PointVec pos)
            :
            base(game, new Status(maxHP, damage, speed * game.TileSize, 1 * game.TileSize ), pos, 5 * game.TileSize)
        { }

        public override void Move(Random random)
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

            if ( IsPlayerInRange(status.Range) )
            {
                game.GamePlayer.Damaged( status.Damage, random );
            }
        }
    }
}
