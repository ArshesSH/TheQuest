using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class Game
    {
        private MyRect screenRect;
        private Player player;
        private int level = 0;
        public MyRect ScreenRect { get { return screenRect; } }
        public Player GamePlayer { get { return player; } }
        public List<Enemy> Enemies;
        public Item ItemInRoom;
        public readonly int TileSize = 50;

        public Game( MyRect rect )
        {
            screenRect = rect;
            player = new Player( this, new Status( 3, 0, TileSize, 0 ), new PointVec( 100, 60 ) );
        }

        public void UpdateEnemies(Random random)
        {
            foreach( Enemy enemy in Enemies )
            {
                enemy.Move( random );
            }
        }
        public void PlayerMove(PointVec dir, Random random)
        {
            player.Move( dir );
            UpdateEnemies( random );
        }
        public void PlayerAttack(PointVec dir, Random random)
        {
            player.Attack(dir, random);
            foreach(Enemy enemy in Enemies)
            {
                enemy.Move(random);
            }
        }
        private PointVec GetRandomLocation(Random random)
        {
            return new PointVec( screenRect.Rect.Left + random.Next( screenRect.Rect.Right / TileSize - screenRect.Rect.Left / TileSize ) * TileSize,
                screenRect.Rect.Top + random.Next( screenRect.Rect.Bottom / TileSize - screenRect.Rect.Top / TileSize ) * TileSize );
        }
        public void NewLevel(Random random)
        {
            level++;
            switch(level)
            {
                case 1:
                {
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    ItemInRoom = new Sword(this, GetRandomLocation(random));
                    break;
                }    
            }
        }
        public void Equip(string weaponName)
        {
            player.Equip(weaponName);
        }
        public bool CheckPlayerInventory(string weaponName)
        {
            return player.Items.Contains(weaponName);
        }

        public Point GetActorPos(Actor actor)
        {
            return actor.Pos.P;
        }
    }
}
