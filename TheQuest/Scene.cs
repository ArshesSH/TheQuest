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

        SceneStart(int tileRow, int tileCol, int tileSize)
        {
            tileMap = new TileMap( tileRow, tileCol, tileSize );
        }
        public void Update()
        {

        }
    }

}
