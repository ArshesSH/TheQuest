using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    abstract class Actor
    {
        protected PointVec pos;
        protected Status status;
        protected Game game;
        public Status ActorStatus { get { return status; } }

        public PointVec Pos
        {
            get { return pos; }
        }
        public Actor( Game game, PointVec startPos )
        {
            this.game = game;
            pos = startPos;
        }
        public Actor( Game game, Status status, PointVec startPos)
        {
            this.game = game;
            this.status = status;
            pos = startPos;
        }

        public void Move( PointVec dir )
        {
            PointVec nextPos = pos + dir * status.Speed;
            if ( game.ScreenRect.IsContains( nextPos.P ) )
            {
                pos = nextPos;
            }
        }
        public void Damaged( int damage, Random random )
        {
            status.Damaged( random.Next( 1, damage ));
        }
        public void IncreaseHealth( int health, Random random )
        {
            status.IncreaseHealth( random.Next( 1, health ) );
        }
        public bool IsNearby(PointVec pos, int distance)
        {
            return pos.GetLength() <= distance;
        }
    }
}
