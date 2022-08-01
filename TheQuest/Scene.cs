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
        public abstract void Update( Game game );

    }

    class SceneStart : Scene
    {
        public override void Update( Game game )
        {
        }
    }

}
