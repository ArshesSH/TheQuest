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
        private Item equippedItem;
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
            if( equippedItem != null )
            {
                equippedItem.Use(dir, random);
            }
        }

        new public void Move(PointVec dir)
        {
            base.Move( dir );
            if( !game.ItemInRoom.IsPickedUp )
            {
                if((game.ItemInRoom.Pos - pos).GetDistanceSq() <= 20)
                {
                    game.ItemInRoom.PickUp();
                }
            }
        }

        public void Equip(string weaponName)
        {
            foreach(Item item in inventory)
            {
                if(item.Name == weaponName)
                {
                    equippedItem = item;
                }
            }
        }
    }
}
