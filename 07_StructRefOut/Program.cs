namespace _07_StructRefOut
{
    partial struct MyStruct
    {
        public int MyProperty { get; set; }
    }

    partial struct MyStruct
    {
        public int MyProperty1 { get; set; }
    }
    class Point
    {
        private int x;

        public int X
        {
            get { return x; }
            set
            {
                if (value > 0)
                    x = value;
                else
                    throw new Exception("X must me > 0");
            }
        }

        public int Y { get; set; }
    }

    //Access Spetificators
    /*
     *private
     *public (deafult for all fields)
     *protected
     *internal
     *protected internal
     */
    struct _2DPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public _2DPoint(int x, int y)
        {
            X = x; 
            Y = y;   
        }
        public void Print()
        {
            Console.WriteLine($"X : {X}. Y : {Y}");
        }
    }

    internal class Program
    {
        static void MethosWithParams(string name, int age, int average, params int[]marks)
        {
            Console.WriteLine("---------------" + name+"------------");
            Console.WriteLine("---------------" + age+"------------");
            Console.WriteLine("---------------" + average+"------------");
            foreach (var item in marks)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void Modify(ref int num,ref string str,ref Point p)
        {
            num+=1;
            str += "!";
            p.X++;
            p.Y++;
        }
        static void GetCurrentTime(out int hour, out int minute, out int second)
        {
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            second = DateTime.Now.Second;
            //return hour, minute,second;
            //Console.WriteLine($"{hour}:{minute}:{second}");
        }
        static void Main(string[] args)
        {

            try
            {
                Point[] points = new Point[1];
                for (int i = 0; i < points.Length; i++)
                {
                    points[i] = new Point();
                   
                    points[i].X = int.Parse(Console.ReadLine());
                    points[i].Y = int.Parse(Console.ReadLine());
                   
                    //points[i].HireDate = DateTime.Parse(Console.ReadLine());
                }
                Console.WriteLine(points[0]);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            //Point p = new Point();//create dynamic memory
            //_2DPoint _2DPoint = new _2DPoint();//new - invoke default constructor

            ///*
            // * numbers = 0
            // * boolean = false
            // * references = null
            // */
            //Point point;//null
            //_2DPoint point1;
            //int a;


            /*
            //out
            int h, m , s ;
            GetCurrentTime(out h, out m, out s);
            Console.WriteLine($"{h}:{m}:{s}");

            //ref == & - references
            int num = 10;
            string str = "Hello academy";
            Point point = new Point() { X = 7, Y = 10 };
            Console.WriteLine($"Num : {num}");
            Console.WriteLine($"Str : {str}");
            Console.WriteLine($"Point : x = {point.X}. y = {point.Y}");
            Modify(ref num,ref  str,ref point);
            Console.WriteLine($"Num : {num}");
            Console.WriteLine($"Str : {str}");
            Console.WriteLine($"Point : x = {point.X}. y = {point.Y}");

            //params
            int[] marks = new int[] { 11, 12, 7, 4, 8, 9, 6 };
            //MethosWithParams("Bob", marks);
            //MethosWithParams("Tom", new int[] { 11, 12, 4, 7, 8, 10 });
            MethosWithParams("Ivanka",  11, 12, 4, 7, 8, 10,11,12,12,12,10,10,1,1,1,3,12,12,10);




            //Point p = new Point();
            //_3D_objects.Point point = new _3D_objects.Point();
           */

        }
    }
}

namespace _3D_objects
{
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
    }

}