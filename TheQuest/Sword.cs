using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    class Sword : Weapon
    {        
        public Sword(Game game, PointVec pos )
            :
            base(game, new Status( 0, 3, 0, 10 ), pos, 1, false )
        { }

        public override string Name { get { return "Sword"; } }
        public override void Effect( PointVec dir, Random random )
        {
            PointVec dirCW;
            PointVec dirCCW;
            if(dir.IsEqual(PointVec.DirUp))
            {
                dirCCW = PointVec.DirLeft;
                dirCW = PointVec.DirRight;
            }
            else if(dir.IsEqual(PointVec.DirRight))
            {
                dirCCW = PointVec.DirUp;
                dirCW = PointVec.DirDown;
            }
            else if(dir.IsEqual(PointVec.DirDown))
            {
                dirCCW = PointVec.DirRight;
                dirCW = PointVec.DirLeft;
            }
            else
            {
                dirCCW = PointVec.DirDown;
                dirCW = PointVec.DirUp;
            }
            DamageEnemy(dir, status.Range, status.Damage, random);
            DamageEnemy(dirCCW, status.Range, status.Damage, random);
            DamageEnemy(dirCW, status.Range, status.Damage, random);
        }
    }
}
