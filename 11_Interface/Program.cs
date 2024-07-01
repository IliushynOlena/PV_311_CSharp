namespace _11_Interface
{
    interface IWorker
    {
        //public
        bool IsWorking { get; set; }  
        void Work();

        event EventHandler<EventArgs> Worked;
    }

    abstract class Human
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Bithday { get; set; }
        public override string ToString()
        {
            return $"Fullname  : {Lastname}  {Firstname}. Birthday : {Bithday.ToShortDateString()}";
        }
    }

    abstract class Employee : Human
    {
        public string Position { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return base.ToString()+ $"\nPosition : {Position}. Salary : {Salary} grn\n";
        }
    }
    interface IWorkable
    {
        bool IsWorking { get;  }
        string Work();
    }
    interface IManager
    {
        List<IWorkable> ListOfWorkers { get; set; }
        void Organize();
        void Control();
        void MakeBudget();
    }
    class Director : Employee, IManager // implement(realize)
    {
        public List<IWorkable> ListOfWorkers { get ; set ; }//null

        public void Control()
        {
            Console.WriteLine("I control work");
        }

        public void MakeBudget()
        {
            Console.WriteLine("I make budget! ");
        }

        public void Organize()
        {
            Console.WriteLine("I organize work.");
        }
    }
    class Seller : Employee, IWorkable
    {
        //1 - readoly - get
        //private bool isWorking = true;
        //public bool IsWorking
        //{
        //    get { return isWorking; }
        //}      

        //2 readoly - get
        //public bool IsWorking { get; } = true;
        //3 - lambda 
        public bool IsWorking => true;//readoly - get

        public string Work()
        {
            return "I selling product.";
        }
    }
    class Cashier : Employee, IWorkable
    {
        public bool IsWorking => true;

        public string Work()
        {
            return "I get pay for product.";
        }
    }
    class Administrator : Employee, IWorkable, IManager
    {
        public bool IsWorking => true;

        public List<IWorkable> ListOfWorkers { get; set ; }

        public void Control()
        {
            Console.WriteLine("I am a BOSSSS.....");
        }

        public void MakeBudget()
        {
            Console.WriteLine("I am rich!!! I have a lot of money!!!");
        }

        public void Organize()
        {
            Console.WriteLine("I organize work");
        }

        public string Work()
        {
            return "I  do my work again ((((((";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Director director = new Director() 
            IManager director = new Director() 
            { 
                 Firstname = "Sasha",
                 Lastname = "Mukoluk",
                 Bithday = new DateTime(1985,12,7),
                 Position = "Director",
                 Salary = 45000
            };
            director.Control();
            director.Organize();
            director.MakeBudget();
            Console.WriteLine(director);
            Seller seller = new Seller() 
            //IWorkable seller = new Seller() 
            {
                Firstname = "Olga",
                Lastname = "Nikituk",
                Bithday = new DateTime(2000,7,12),
                Position = "Seller",
                Salary = 7350
            };
            Console.WriteLine(seller.Work()); 
            //seller.Salary = 80000;
            Console.WriteLine(seller);
            Console.WriteLine($"Sellers salary : {(seller as Employee).Salary}");

            director.ListOfWorkers = new List<IWorkable>
            {
                seller,
                new Cashier
                {
                    Firstname = "Petro",
                    Lastname = "Nikituk",
                    Bithday = new DateTime(2001,1,21),
                    Position = "Cashier",
                    Salary = 10000
                },
                 new Seller
                {
                    Firstname = "Mira",
                    Lastname = "Nikituk",
                    Bithday = new DateTime(2002,1,21),
                    Position = "Cashier",
                    Salary = 12200
                },
                   new Administrator
                {
                    Firstname = "Bob",
                    Lastname = "Nikituk",
                    Bithday = new DateTime(2002,1,21),
                    Position = "Cashier",
                    Salary = 22000
                }

            };
            foreach (IWorkable emp in director.ListOfWorkers)
            {
                Console.WriteLine(emp.Work()); 

                if( emp is Cashier)
                    Console.WriteLine("This is Cashier");

                if (emp is Administrator)
                     (emp as Administrator).Control();

            }


            Administrator admin = new Administrator();//21v31d2fv1d5fv
            IManager manager = admin;//21v31d2fv1d5fv
            manager.Control();
            IWorkable worker = admin;////21v31d2fv1d5fv
            worker.Work();

        }
    }
}
