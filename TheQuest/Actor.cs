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
        
        public Point Pos
        {
            get { return pos.P; }
        }
        public Actor( PointVec startPos )
        {
            pos = startPos;
        }
        public Actor( Status status, PointVec startPos)
        {
            this.status = status;
            pos = startPos;
        }

        public void Move( PointVec dir, MyRect screenRect )
        {
            PointVec nextPos = pos + dir * status.Speed;
            if ( screenRect.IsContains( nextPos.P ) )
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
        public bool IsNearby(PointVec pos, int distanceSq)
        {
            return pos.GetDistanceSq() <= distanceSq;
        }
        public void Attack(PointVec dir, Actor target, Random random )
        {
            PointVec targetDir = target.pos - pos;
            if( IsNearby(target.pos, status.Range * status.Range ) )
            {
                if ( dir.IsEqual( targetDir.GetNormalized() ) ) 
                {
                    target.Damaged( status.Damage, random );
                }
            }
        }
    }
}
