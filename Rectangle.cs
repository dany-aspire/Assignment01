using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    public class Rectangle
    {
        private int length, breadth;

        public Rectangle()
        {
            length = 1;
            breadth = 1;
        }
        public Rectangle( int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public int GetLength()
        {
            return length;

        }
        public int SetLength(int length)
        {
            this.length = length;
            return 1;

        }

        public int GetWidth()
        {
            return breadth;

        }
        public int SetWidth(int breadth)
        {
            this.breadth = breadth;
            return 1;

        }
        public int GetPerimeter()
        {
            return (2 * length) + (2 * breadth);

        }
        public int GetArea()
        {
            return length * breadth;
        }
    }
}
