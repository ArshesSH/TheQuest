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
        protected Point curTilePos;

        public Actor( Point startTilePos )
        {
            curTilePos = startTilePos;
        }
        public Actor( Status status_in, Point startTilePos )
        {
            status = status_in;
            curTilePos = startTilePos;
        }
        public Point GetRealPos(TileMap tileMap)
        {
            return tileMap.GetRealPos( curTilePos );
        }
        virtual public void Move( TileMap tileMap, Point dir )
        {
            Point nextPos = tileMap.GetNextPos( curTilePos, dir );
            if ( tileMap.CanMove( nextPos ) )
            {
                curTilePos = nextPos;
            }
        }
    }
}
