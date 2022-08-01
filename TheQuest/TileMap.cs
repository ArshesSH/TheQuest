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
        public enum Tile
        {
            Empty,
            Player,
            Enemy,
            Item
        }
        
        private List<Tile> tiles;
        private readonly int tileRow;
        private readonly int tileCol;

        public readonly int tileSize;
        public List<Tile> Tiles
        {
            get { return tiles; }
            set { tiles = Tiles; }
        }

        public TileMap(int row, int col, int size)
        {
            tileRow = row;
            tileCol = col;
            tileSize = size;
            tiles = new List<Tile>( row * col );
        }

        public bool CanMove(Point pos)
        {
            return IsTileStateAt( pos, Tile.Empty );
        }
        public bool IsTileStateAt( Point pos, Tile state)
        {
            return tiles[ConvertToIndex( pos )] == state;
        }
        public Point GetNextPos(Point pos, Point dir)
        {
            return new Point( pos.X + dir.X, pos.Y + dir.Y );
        }
        public bool FindAround(Point pos, int distance, Tile target)
        {
            for( int y = pos.Y - distance; y < pos.Y + distance; ++y )
            {
                for(int x = pos.X - distance; x < pos.X + distance; ++x )
                {
                    if( IsTileStateAt(new Point(x, y), target) )
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public Point GetRealPos(Point tilePos)
        {
            return new Point( tilePos.X * tileSize, tilePos.Y * tileSize );
        }

        private int ConvertToIndex( Point pos )
        {
            return tileRow * pos.Y + pos.X;   
        }
        private Point ConvertToPos( int index )
        {
            int x = index % tileRow;
            int y = index / tileRow;
            return new Point( x, y );
        }
    }
}
