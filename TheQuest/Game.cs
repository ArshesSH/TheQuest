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
        private MyRect screenRect;

        private Player player;
        public MyRect ScreenRect { get { return screenRect; } }
        public Player GamePlayer { get { return player; } }

        public Game( MyRect rect )
        {
            screenRect = rect;
            player = new Player( this, new Status( 3, 0, 50, 0 ), new PointVec( 100, 60 ) );
        }

        public void UpdateModel()
        {
            
        }
        public void PlayerMove(PointVec dir)
        {
            player.Move( dir );
        }
        public void PlayerAttack(PointVec dir)
        {

        }

        public Point GetActorPos(Actor actor)
        {
            return actor.Pos.P;
        }

    }
}
