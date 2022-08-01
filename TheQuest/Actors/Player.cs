using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class Player : Actor
    {
        public Player( Status status, Point pos )
            :
            base( status, pos )
        { }

        public override void Move( TileMap tileMap, Point dir )
        {
            base.Move( tileMap , dir );
            if ( tileMap.IsTileStateAt( curTilePos, TileMap.Tile.Item ) ) 
            {

            }
        }
        
    }
}
