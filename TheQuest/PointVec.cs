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

        public static readonly PointVec DirUp = new PointVec( 0, -1 );
        public static readonly PointVec DirDown = new PointVec( 0, 1 );
        public static readonly PointVec DirLeft = new PointVec( -1, 0 );
        public static readonly PointVec DirRight = new PointVec( 1, 0 );

        public enum Direction
        {
            Up,
            Down,
            Left,
            Right,
            Count
        }

        public static PointVec GetDirection( Direction dir )
        {
            PointVec direction;
            switch (dir)
            {
                case Direction.Up:
                {
                    direction = DirUp;
                    break;
                }
                case Direction.Down:
                {
                    direction = DirDown;
                    break;
                }
                case Direction.Left:
                {
                    direction = DirLeft;
                    break;
                }
                case Direction.Right:
                {
                    direction = DirRight;
                    break;
                }
                default:
                {
                    direction = new PointVec();
                    break;
                }
            }
            return direction;
        }

        public static PointVec GetRandomDir( Random random )
        {
            Direction dir = (Direction)random.Next( (int)Direction.Up, (int)Direction.Count );
            return GetDirection( dir );
        }

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
        public double GetLengthSq()
        {
            return P.X * P.X + P.Y * P.Y;
        }
        public double GetLength()
        {
            return Math.Sqrt(GetLengthSq() );
        }
        public PointVec GetNormalized()
        {
            int newX = 0;
            int newY = 0;
            int dist = (int)GetLength();
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
