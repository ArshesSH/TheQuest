using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    abstract class Enemy : Actor
    {
        private int searchDistance;
        public Enemy( Game game, Status status, PointVec pos, int searchDistance )
            :
            base( game, status, pos )
        {
            this.searchDistance = searchDistance;
        }

        public abstract void Move( Random random );

        protected bool IsPlayerInRange()
        {
            return IsNearby( game.GamePlayer.Pos, searchDistance * searchDistance );
        }
        protected PointVec FindPlayerDir( PointVec playerPos )
        {
            PointVec dir;
            if ( playerPos.P.X > pos.P.X + searchDistance ) 
            {
                dir = PointVec.DirRight;
            }
            else if ( playerPos.P.X < pos.P.X + searchDistance )
            {
                dir = PointVec.DirLeft;
            }
            else if ( playerPos.P.Y > pos.P.Y + searchDistance )
            {
                dir = PointVec.DirUp;
            }
            else
            {
                dir = PointVec.DirDown;
            }
            return dir;
        }
    }
}
