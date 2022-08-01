using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class PointVec
    {
        public Point P;

        public PointVec()
        {
            P.X = 0;
            P.Y = 0;
        }
        public PointVec( int x, int y )
        {
            P.X = x;
            P.Y = y;
        }
        public PointVec(Point p)
        {
            P = p;
        }
        
        public static PointVec operator +( PointVec lhs, PointVec rhs )
        {
            return new PointVec( lhs.P.X + rhs.P.X, lhs.P.Y + rhs.P.Y );
        }
        public static PointVec operator -( PointVec lhs, PointVec rhs )
        {
            return new PointVec( lhs.P.X - rhs.P.X, lhs.P.Y - rhs.P.Y );
        }
        public static PointVec operator *( PointVec lhs, int rhs )
        {
            return new PointVec( lhs.P.X * rhs, lhs.P.Y * rhs);
        }
        public static PointVec operator /( PointVec lhs, int rhs )
        {
            return new PointVec( lhs.P.X / rhs, lhs.P.Y / rhs );
        }
        public double GetDistanceSq()
        {
            return P.X * P.X + P.Y + P.Y;
        }
        public double GetDistance()
        {
            return Math.Sqrt( GetDistanceSq() );
        }
        public PointVec GetNormalized()
        {
            int newX = 0;
            int newY = 0;
            int dist = (int)GetDistance();
            if( dist != 0)
            {

                newX = P.X / dist;
                newY = P.Y / dist;
            }
            return new PointVec( newX, newY );
        }
        public bool IsEqual( PointVec rhs )
        {
            return P.X == rhs.P.X && P.Y == rhs.P.Y;
        }
    }
}
