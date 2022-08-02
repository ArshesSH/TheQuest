using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class Player : Actor
    {
        public List<Item> Inventory = new List<Item>();
        //public List<string> Weapons
        //{
        //    get
        //    {
        //        List<string> names = new List<string>();
        //        foreach ()
        //    }
        //}
        public Player( Game game, Status status, PointVec pos )
            :
            base( game, status, pos )
        {}

        public void Attack(PointVec dir, Random random)
        {

        }

        new public void Move(PointVec dir)
        {
            base.Move( dir );
        }
    }
}
