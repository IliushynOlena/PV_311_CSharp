namespace _08_OverloadOperators
{
    class Point_3D : Object
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point_3D() : this(0, 0,0) { }
        public Point_3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return $"X : {X}. Y : {Y}. Z : {Z}";
        }
    }
        class Point: Object
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(): this(0, 0) { }
        public Point(int x, int y)
        {
            X = x;
            Y = y;  
        }
        public override string ToString()
        {
            return $"X : {X}. Y : {Y}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Point point &&
                   X == point.X &&
                   Y == point.Y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }


        //ref out in not allowed
        //public static return_type operator[symbol] (parameters){code.....}
        #region Унарні оператори 
        //- , ++, --
        public static Point operator -(Point p)
        {
            Point res = new Point() { 
                 X = p.X*-1, Y = p.Y*-1
            };
            return res ;
        }
        public static Point operator ++ (Point p)
        {
            p.X++;
            p.Y++;
            return p;
        }
        public static Point operator --(Point p)
        {
            p.X--;
            p.Y--;
            return p;
        }
        #endregion
        #region Binary operators
        //+ - * /
        public static Point operator +(Point p1, Point p2)
        {
            Point res = new Point()
            {
                X = p1.X+p2.X,  
                Y = p1.Y+p2.Y
            };
            return res;
        }
        public static Point operator -(Point p1, Point p2)
        {
            Point res = new Point()
            {
                X = p1.X - p2.X,
                Y = p1.Y - p2.Y
            };
            return res;
        }
        public static Point operator *(Point p1, Point p2)
        {
            Point res = new Point()
            {
                X = p1.X * p2.X,
                Y = p1.Y * p2.Y
            };
            return res;
        }
        public static Point operator /(Point p1, Point p2)
        {
            Point res = new Point()
            {
                X = p1.X / p2.X,
                Y = p1.Y / p2.Y
            };
            return res;
        }
        #endregion
        #region Logic operator equals
        //== !=
        public static bool operator ==(Point p1, Point p2)
        {
           //return p1.X== p2.X && p1.Y== p2.Y;   
           return  p1.Equals(p2);
        }
        public static bool operator !=(Point p1, Point p2)
        {
            //return p1.X != p2.X || p1.Y != p2.Y;
            return !(p1 == p2);
        }
        #endregion
        #region Logic operator compare
        public static bool operator >(Point p1, Point p2)
        {
            return p1.X + p1.Y > p2.X + p2.Y;  
        }
        //in pair
        public static bool operator <(Point p1, Point p2)
        {
            return !(p1> p2);
        }
        public static bool operator >=(Point p1, Point p2)
        {
            return p1.X + p1.Y >= p2.X + p2.Y;
        }
        //in pair
        public static bool operator <=(Point p1, Point p2)
        {
            return !(p1 >= p2);
        }
        #endregion
        #region true/false oparators
        public static bool operator true(Point p)
        {
            return p.X >= 0 && p.Y >= 0;
        }
        //in pair
        public static bool operator false(Point p)
        {
            return p.X < 0 ||p.Y < 0;
        }
        #endregion
        #region Оператори перетворення типів
        public static explicit operator int(Point p)
        {
            return p.X + p.Y;
        }
        public static implicit operator double(Point p)
        {
            return p.X + p.Y;
        }
        public static implicit operator Point_3D(Point p)
        {
            return new Point_3D(p.X, p.Y, 55);
        }
        #endregion
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(7,8);  
            int a = 5;//int ==> int
            double b = 3.14;//double ==> double

            b = a;//int ==> double implicit 5.0000000000
            a = (int) b;//double ==> int  explicit 3

            a = (int)  point;//Point ==> int
            b = point;// Point ==> double
            Console.WriteLine(a);
            Console.WriteLine(b);
            Point_3D _3D = point;
            Console.WriteLine(_3D);

            string str = "Hello";//0f58df79dg87d
            string str2 = "Hello";//dg54d6fh4f5h
          
            if (str.Equals(str2))
            {
                Console.WriteLine("Equals");
            }
            else
            {
                Console.WriteLine("not Equals");
            }


            Point p = new Point(-12,74);          
            Point p2 = new Point(2,4);
            if (p) Console.WriteLine("True");
            else Console.WriteLine("False");
             
            if (p > p2)
            {
                Console.WriteLine("p1 > p2");
            }
            else
            {
                Console.WriteLine("not Equals");
            }
            //if (p.Equals(p2))
            //{
            //    Console.WriteLine("Equals");
            //}
            //else
            //{
            //    Console.WriteLine("not Equals");
            //}

            Console.WriteLine($"Point : {p}");
            Console.WriteLine($"Point ++ : {p++}");
            Console.WriteLine($"Point ++: {++p}");
            Console.WriteLine($"Point --: {p--}");
            Console.WriteLine($"Point --: {--p}");
            Console.WriteLine();
            Console.WriteLine($"Point 1 : {p}");
            Console.WriteLine($"Point 2 : {p2}");
            Point res = -p;
            Console.WriteLine($"Res -: {res}");
            res = p + p2;
            Console.WriteLine($"Res +: {res}");
            res = p - p2;
            Console.WriteLine($"Res -: {res}");
            res = p * p2;
            Console.WriteLine($"Res *: {res}");
            res = p / p2;
            Console.WriteLine($"Res /: {res}");

        }
    }
}

