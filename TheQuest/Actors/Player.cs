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

        public override void Move( TileMap tileMap, Point dir )
        {
            base.Move( tileMap , dir );
            if ( tileMap.IsTileStateAt( curPos, TileMap.Tile.Item ) ) 
            {

            }
        }
        
    }
}
