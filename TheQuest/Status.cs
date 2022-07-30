using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    class Status
    {
        private int hitPoint;
        private int damage;

        public int Damage
        {
            get { return damage; }
            set { damage = Damage; }
        }
        public int HitPoint
        {
            get { return hitPoint; }
            set { hitPoint = HitPoint; }
        }
        Status(int hitPoint_in, int damage_in)
        {
            hitPoint = hitPoint_in;
            damage = damage_in;
        }
    }
}
