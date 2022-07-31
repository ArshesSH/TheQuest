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
        private int speed;

        public int HitPoint { get { return hitPoint; } }
        public int Damage { get { return damage; } }
        public int Speed { get { return speed; } }

        public Status()
            :
            this(0,0,0)
        { }
        public Status(int hitPoint_in, int speed_in )
        {
            hitPoint = hitPoint_in;
            speed = speed_in;
        }
        public Status( int hitPoint_in, int damage_in, int speed_in )
        {
            hitPoint = hitPoint_in;
            damage = damage_in;
            speed = speed_in;
        }

        public bool IsDead()
        {
            return hitPoint <= 0;
        }
    }
}
