namespace _06_IntroToOOP
{
    //Access Spetificators
    /*
     *private (deafult for all fields)
     *public
     *protected
     *internal
     *protected internal
     */
    public class MyClass : Object//private
    {

        private int number ;
        private string name ;
        private const float PI = 3.14f;
        private readonly int id;
        public MyClass()
        {
            id = 10;
        }
        //void setId(int id)
        //{
        //    this.id = id;
        //}
        public void Print()
        {
            Console.WriteLine($"Name : {name}. Id : {id}");
        }
        public override string ToString()
        {
            return $"Name : {name}. Id : {id}";
        }

    }
    internal class MyClass2
    {

    }
    internal class DerivedClass : MyClass//public
    {

    }
    struct MyStruct//public
    {
        public int x;
        public int y;
    }
    partial class Point//private
    {
        private int xCoord;
        //Properties / full
        public int XCoord//int value
        {
            get { return xCoord; }
            set//(int value)
            {
                if (value > 0)
                    this.xCoord = value;
                else
                    this.xCoord = Math.Abs(value);
            }
        }

        //private string name;
        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}
        //Auto property prop+ TAB
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get;  }//readonly property
        public string Color { get; private set; } = "White";

        //Full property propfull + TAB
        private int yCoord;
        public int YCoord
        {
            get { return yCoord; }
            set 
            { 
                if(value >= 0)
                    yCoord = value; 
                else
                    yCoord = Math.Abs(value);   
            }
        }
      
        public void Print()
        {
            Console.WriteLine($"X: {xCoord}. Y : {yCoord}");
        }
        public override string ToString()
        {
            return $"X: {xCoord}. Y : {yCoord}";
        }
    }
    partial class Point
    {
        public void TestFunction()
        {
            Console.WriteLine("Test function......");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(-8,-12);
            p.Print();
            Console.WriteLine(p);
            p.SetX(100);
            p.SetY(200);
            Console.WriteLine(p.GetX());
            Console.WriteLine(p.GetY());
            Console.WriteLine(p);

            p.XCoord = 333; //333 = value - set
            int x = p.XCoord;
            Console.WriteLine(x);//get
            Console.WriteLine(p.XCoord);//get

            p.Name = "2D_Point";//set
            Console.WriteLine(p.Name);//get

            //p.Type = "New Point";//error
            Console.WriteLine(p.Type);

            p.TestFunction();
            //MyClass myClass = new MyClass();
            //myClass.Print();
            //Console.WriteLine(myClass.ToString());



        }
    }
}
