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
        public int SerachDistance { get { return searchDistance; } }
        public Enemy( Game game, Status status, PointVec pos, int searchDistance )
            :
            base( game, status, pos )
        {
            this.searchDistance = searchDistance;
        }

        public abstract void Move( Random random );

        protected bool IsPlayerInRange(int distance)
        {
            return IsNearby( (pos - game.GamePlayer.Pos), distance );
        }
        protected PointVec FindPlayerDir( PointVec playerPos )
        {
            PointVec dir;
            if ( playerPos.P.X > pos.P.X + game.TileSize ) 
            {
                dir = PointVec.DirRight;
            }
            else if ( playerPos.P.X < pos.P.X + game.TileSize )
            {
                dir = PointVec.DirLeft;
            }
            else if ( playerPos.P.Y < pos.P.Y + game.TileSize )
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
