using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_IntroToOOP
{
    partial class Point
    {
        public void SetX(int x)
        {
            if (x > 0)
                this.xCoord = x;
            else
                this.xCoord = Math.Abs(x);
        }
        public void SetY(int y)
        {
            if (y > 0)
                this.yCoord = y;
            else
                this.yCoord = Math.Abs(y);
        }
        public int GetX()
        {
            return xCoord;
        }
        public int GetY()
        {
            return yCoord;
        }


    }
    partial class Point
    {
        static int count;
        static Point()
        {
            count = 0;
        }
        public Point() : this(0, 0) { }
        //{
        //    xCoord = 0;
        //    yCoord = 0; 
        //}
        public Point(int value) : this(value, value) { }
        //{
        //    xCoord=value;
        //    yCoord=value;
        //}
        public Point(int xCoord, int y)
        {
            Type = "2D_Point ";
            XCoord = xCoord;//SetX(xCoord);
            YCoord = y;//SetY(y);
            count++;
        }



    }
}
