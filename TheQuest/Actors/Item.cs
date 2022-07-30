using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    abstract class Item : Actor
    {
        private readonly int maxCnt;
        private int curCnt;
        private bool isConsumable;

        Item(int cnt, bool consumable)
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
