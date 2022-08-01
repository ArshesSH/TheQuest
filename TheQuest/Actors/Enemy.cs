using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    abstract class Enemy : Actor
    {
        public Enemy( Status status, PointVec pos )
            :
            base( status, pos )
        { }

    }
}
