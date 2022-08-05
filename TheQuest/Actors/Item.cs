using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    abstract class Item : Actor
    {
        private readonly int maxCnt;
        private int curCnt;
        public int Count { get { return curCnt; } }
        private bool isConsumable;
        private bool isPickedUp;
        public bool IsPickedUp { get { return isPickedUp; } }
        public Item( Game game, Status status, PointVec pos, int cnt, bool consumable)
            :
            base(game, status, pos)
        {
            maxCnt = cnt;
            curCnt = maxCnt;
            isConsumable = consumable;
            isPickedUp = false;
        }
        public abstract string Name { get; }
        public void PickUp()
        {
            isPickedUp = true;
        }
        public void Use( PointVec dir, Random random )
        {
            if( isConsumable)
            {
                if( curCnt > 0)
                {
                    Effect(dir, random);
                    curCnt--;
                }
            }
            else
            {
                Effect(dir, random);
            }
        }

        public abstract void Effect( PointVec dir, Random random );
    }
}
