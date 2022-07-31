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

        private Scene curScene;

        public Game(Rectangle rect)
        {
            screenRect = rect;
            curScene = new SceneStart()
        }

    }
}
