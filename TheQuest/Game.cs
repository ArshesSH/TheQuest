using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class Game
    {
        private Rectangle screenRect;
        private TileMap tileMap;
        private Player player;
        public Player GamePlayer
        {
            get { return player; }
        }

        public Game(Rectangle rect)
        {
            screenRect = rect;
            tileMap = new TileMap( 5, 5, 50 );
            player = new Player( new Status( 3, 0, 1 ), new Point( 0, 0 ) );
        }

        public void UpdateModel()
        {
            
        }
        public void PlayerMove(Point dir)
        {
            player.Move( tileMap, dir );
            
        }
        public void PlayerAttack(Point dir)
        {

        }

        public Point GetActorPos(Actor actor)
        {
            return actor.GetRealPos(tileMap);
        }

        public bool IsRectOverlapWith( Rectangle lhs, Rectangle rhs )
        {
            return lhs.Top < rhs.Bottom && lhs.Bottom > rhs.Top && lhs.Left < rhs.Right && lhs.Right > rhs.Left;
        }
        public bool IsRectContains( Rectangle rect, Point pos )
        {
            return pos.X >= rect.Left && pos.X <= rect.Right && pos.Y >= rect.Top && pos.Y <= rect.Bottom;
        }
        public bool IsRectContains(Rectangle lhs, Rectangle rhs)
        {
            return rhs.Top >= lhs.Top && rhs.Bottom <= lhs.Bottom && rhs.Left >= lhs.Left && rhs.Right <= lhs.Right;
        }

    }
}
