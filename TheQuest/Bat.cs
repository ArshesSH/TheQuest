using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class Bat : Enemy
    {
        private const int maxHP = 6;
        private const int damage = 2;
        private const int speed = 1;

        public Bat(Point pos)
            :
            base(new Status(maxHP, damage, speed), pos)
        { }
    }
}
