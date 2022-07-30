using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    interface Scene
    {
        void Update();
    }

    class SceneStart : Scene
    {
        private TileMap tileMap;

        SceneStart(int row, int col)
        {
            tileMap = new TileMap( row, col );
        }
        public void Update()
        {

        }
    }

}
