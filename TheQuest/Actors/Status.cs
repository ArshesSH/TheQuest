using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    class Status
    {
        public int HitPoint;
        public int Damage;
        public int Speed;

        Status(int hitPoint, int damage, int speed)
        {
            HitPoint = hitPoint;
            Damage = damage;
            Speed = speed;
        }
    }
}
