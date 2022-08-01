using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class MyRect
    {
        public Rectangle Rect;

        public MyRect(Rectangle rect)
        {
            Rect = rect;
        }
        public MyRect( int x, int y, int width, int height )
        {
            Rect = new Rectangle( x, y, width, height );
        }

        public bool IsOverlapWith( Rectangle rhs )
        {
            return Rect.Top < rhs.Bottom && Rect.Bottom > rhs.Top && Rect.Left < rhs.Right && Rect.Right > rhs.Left;
        }
        public bool IsOverlapWith( MyRect rhs )
        {
            return IsOverlapWith( rhs.Rect );
        }
        public bool IsContains( Point pos )
        {
            bool a =  pos.X >= Rect.Left;
            a = pos.X <= Rect.Right;
            a = pos.Y >= Rect.Top;
            a = pos.Y <= Rect.Bottom;

            return pos.X >= Rect.Left && pos.X <= Rect.Right && pos.Y >= Rect.Top && pos.Y <= Rect.Bottom;
        }
        public bool IsContains(  Rectangle rhs )
        {
            return rhs.Top >= Rect.Top && rhs.Bottom <= Rect.Bottom && rhs.Left >= Rect.Left && rhs.Right <= Rect.Right;
        }
    }
}
