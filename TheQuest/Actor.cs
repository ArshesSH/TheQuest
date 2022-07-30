using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    abstract class Actor
    {
        private Status status;
        private int tilePos;

        public abstract void Move();
        public abstract void Act();
    }
}
