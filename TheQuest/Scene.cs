using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    abstract class Scene
    {


        public Scene( int tileRow, int tileCol, int tileSize )
        {
            tileMap = new TileMap( tileRow, tileCol, tileSize );
            player = new Player( new Status( 3, 0, 1 ), new Point( 50, 50 ) );
        }

        public abstract void Update();

    }

    class SceneStart : Scene
    {
        public SceneStart()
        public override void Update()
        {
            
        }
    }

}
