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
        private bool isConsumable;

        public Item(PointVec pos, int cnt, bool consumable)
            :
            base(pos)
        {
            maxCnt = cnt;
            curCnt = maxCnt;
            isConsumable = consumable;
        }

        public void UseItem()
        {
            if( isConsumable)
            {
                if( curCnt < 0)
                {
                    ItemEffect();
                    curCnt--;
                }
            }
            else
            {
                ItemEffect();
            }
        }

        public abstract void ItemEffect();
    }
}
