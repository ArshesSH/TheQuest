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
        //private Item equippedItem;
        private int equippedIdx = -1;
        public int EquippedIdx { get { return equippedIdx; } }
        private List<Item> inventory = new List<Item>();
        public List<string> Items
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Item item in inventory)
                {
                    names.Add(item.Name);
                }
                return names;
            }
        }
        public Player( Game game, Status status, PointVec pos )
            :
            base( game, status, pos )
        {}

        public void Attack(PointVec dir, Random random)
        {
            //if( equippedItem != null )
            //{
            //    equippedItem.Use(dir, random);
            //}
            if( equippedIdx != -1)
            {
                inventory[equippedIdx].Use( dir, random );
                if( inventory[equippedIdx].Count <= 0 )
                {
                    inventory.RemoveAt( equippedIdx );
                    equippedIdx = -1;
                }
            }
        }

        new public void Move(PointVec dir)
        {
            base.Move( dir );
            if( !game.ItemInRoom.IsPickedUp )
            {
                //if((game.ItemInRoom.Pos - pos).GetDistanceSq() <= 20)
                if (game.ItemInRoom.Pos.IsEqual(pos))
                {
                    game.ItemInRoom.PickUp();
                    inventory.Add( game.ItemInRoom );
                }
            }
        }

        public void Equip(string weaponName)
        {
            //foreach(Item item in inventory)
            //{
            //    if ( item.Name == weaponName )
            //    {
            //        equippedItem = item;
            //    }
            //}

            for(int i = 0; i < inventory.Count; ++i )
            {
                if(inventory[i].Name == weaponName)
                {
                    equippedIdx = i;
                }
            }
        }
    }
}
