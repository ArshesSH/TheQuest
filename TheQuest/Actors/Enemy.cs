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
        protected int range;
        protected Random random;

        public Enemy( Status status, Point pos )
            :
            base( status, pos )
        { }

        new virtual public void Move( TileMap tileMap, Point dir )
        { 

            if( !tileMap.FindAround(curTilePos, range, TileMap.Tile.Player ))
            {
                base.Move( tileMap, dir );
            }
        }
    }
}
