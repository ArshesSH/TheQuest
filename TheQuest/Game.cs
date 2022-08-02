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
        private int level = 0;
        public MyRect ScreenRect { get { return screenRect; } }
        public Player GamePlayer { get { return player; } }
        public List<Enemy> Enemies;

        public Game( MyRect rect )
        {
            screenRect = rect;
            player = new Player( this, new Status( 3, 0, 50, 0 ), new PointVec( 100, 60 ) );
        }

        public void UpdateEnemies(Random random)
        {
            foreach( Enemy enemy in Enemies )
            {
                enemy.Move( random );
            }
        }
        public void PlayerMove(PointVec dir, Random random)
        {
            player.Move( dir );
            UpdateEnemies( random );
        }
        public void PlayerAttack(PointVec dir, Random random)
        {

        }

        public Point GetActorPos(Actor actor)
        {
            return actor.Pos.P;
        }

    }
}
