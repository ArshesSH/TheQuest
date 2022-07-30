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
        protected Status status;
        protected Point curPos;

        public Actor(Status status_in, Point startPos)
        {
            status = status_in;
            curPos = startPos;
        }

        virtual public void Move( TileMap tileMap, Point dir )
        {
            Point nextPos = tileMap.GetNextPos( curPos, dir );
            if( tileMap.CanMove(nextPos))
            {
                curPos = nextPos;
            }
        }
    }
}
