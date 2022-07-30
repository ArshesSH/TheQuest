using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    class Vei2
    {
        public int X;
        public int Y;

        public Vei2( int x, int y )
        {
            X = x;
            Y = y;
        }
        
        public static Vei2 operator +( Vei2 lhs, Vei2 rhs )
        {
            return new Vei2( lhs.X + rhs.X, lhs.Y + rhs.Y );
        }
        public static Vei2 operator -( Vei2 lhs, Vei2 rhs )
        {
            return new Vei2( lhs.X - rhs.X, lhs.Y - rhs.Y );
        }
        public static Vei2 operator *( Vei2 lhs, int rhs )
        {
            return new Vei2( lhs.X * rhs, lhs.Y * rhs);
        }
    }
}
