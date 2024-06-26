using System.Text;

namespace _10_Inheritance
{
    //public private protected
    abstract class Person: Object
    {
        protected string name;
        private readonly DateTime birthday;
        public Person()
        {
            name = "no name";
            birthday = new DateTime(2000,5,5);
        }
        public Person(string n, DateTime b)
        {
            name = n;
            if(b > DateTime.Now)
            {
                birthday = new DateTime(2000, 5, 5);
            }
            else
            {
                birthday = b;   
            }            
        }
        public virtual void Print()
        {
            Console.WriteLine($"Name : {name}. Birthday : {birthday.ToShortDateString()}");
        }
        public abstract void DoWork();// = 0
        public override string ToString()
        {
            return $"Name : {name}. Birthday : {birthday.ToShortDateString()}";
        }
    }
    //class Name : BaseClass, Interface1, Interface2
    class Worker : Person
    {
        private double salary;

        public double Salary
        {
            get { return salary; }
            set {this.salary = value >= 0 ? value : 0; }
        }
        public Worker(): base()
        {         
            Salary = 0;
        }
        public Worker(string n, DateTime b, double s):base(n,b)
        {
            Salary=s;   
        }
        public override void DoWork()
        {
            Console.WriteLine("Doing some work......");
        }
        //new
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Salary : {Salary}");
        }
    }
    sealed class Programmer: Worker
    {
        public int CodeLines { get;private set; }
        public Programmer():base()
        {
            CodeLines = 0;  
        }
        public Programmer(string n, DateTime b, double s): base(n,b,s)
        {
            CodeLines = 0;
        }
        //final --> sealed
        public sealed override void DoWork()
        {
            Console.WriteLine("Write C# code");
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Code lines : {CodeLines}");
        }
        public void WriteCode()
        {
            CodeLines++;
        }
    }
    class TeamLead : Worker
    {
        public int ProjectCount { get; set; }
        //public override void DoWork()
        //{
        //    Console.WriteLine("Manage team projects");
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Worker worker = new Worker("Vova",new DateTime(1995,7,8),32000);
            worker.Print(); 

            Programmer programmer = new Programmer("Ivan", new DateTime(2000,12,14),45000);
            programmer.WriteCode();
            programmer.WriteCode();
            programmer.WriteCode();
            programmer.Print();


            Person[] people = new Person[] {
                //new Person(),
                worker,
                programmer,
                new Worker("Petro", new DateTime(1999,5,7), 15000)
            };
            Console.WriteLine();

            Programmer pr = null;
            //1 - use cast ()
            try
            {
                pr = (Programmer)people[1];
                pr.DoWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //2 - use as
            pr = people[1] as Programmer;
            if (pr != null) {
                pr.DoWork();
            }
            else
            {
                Console.WriteLine("Null");
            }
            //use is and as
            if (people[2] is Programmer)
            {
                pr = people[2] as Programmer;
                pr.DoWork();
            }
          


            Console.WriteLine();
            foreach (var item in people)
            {
                Console.WriteLine("------------Info----------");
                item.Print();
                Console.WriteLine();
            }


        }
    }
}
