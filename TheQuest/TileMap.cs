using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class TileMap
    {
        public enum TileState
        {
            Empty,
            CanNotMove
        }
        List<TileState> tiles;


        public TileMap(int row, int col)
        {
            tiles = new List<TileState>( row * col );
        }
    }
}
