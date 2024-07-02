namespace _12_Delegates
{


    //class MyDelegate : Delegate, MulticastDelegate
    //{

    //}
   
    public delegate int IntDelegate(double value);
  
    public delegate void SetStringDelegate(string value); 
    public delegate double DoubleDelegate();
    public delegate void VoidDelegate();
    class SuperClass
    {
        public void Print(string str)
        {
            Console.WriteLine(str + "!!!");
        }
        public static double GetKoef()
        {
            double res = new Random().NextDouble(); 
            return res; 
        }
        public  double GetNumber()
        {
            return new Random().Next();
        }
        public void DoWork()
        {
            Console.WriteLine("I do some work.....");
        }
        public void Test()
        {
            Console.WriteLine("I testing.....");
        }
    }
    public delegate double CalculatorDelegate(double x, double y);
    class Calculator
    {
        public double Add(double x, double y)
        {
            return x + y;   
        }
        public double Sub(double x, double y)
        {
            return x - y;
        }
        public double Multy(double x, double y)
        {
            return x * y;
        }
        public double Div(double x, double y)
        {
            if(y != 0)
                return x / y;
            else
                throw new DivideByZeroException();  
        }
    }
    public delegate int ChangeDelegate(int value);
    internal class Program
    {
        public static void DoOperation(double a, double b, CalculatorDelegate operation)
        {
            Console.WriteLine(operation.Invoke(a, b));
        }
        public static void ChangeElements(int[]arr, ChangeDelegate change )
        {
            for(int i = 0; i < arr.Length; i++)
            {
                //1 2 3 4 5 6 
                arr[i] = change.Invoke(arr[i]);
            }
        }
        static int Sqr(int v)
        {
            return v * v;
        }
        static int Increment(int v)
        {
            return ++v;
        }
        static int Decrement(int v)
        {
            return --v;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 7, 8, 9, 6, 5, 4, 23, 5 };
            foreach (var item in arr) Console.Write(item + " "); Console.WriteLine();

            ChangeElements(arr, Sqr);
            foreach (var item in arr) Console.Write(item + " "); Console.WriteLine();

            ChangeElements(arr, Increment);
            foreach (var item in arr) Console.Write(item + " "); Console.WriteLine();

            ChangeElements(arr, Decrement);
            foreach (var item in arr) Console.Write(item + " "); Console.WriteLine();
            //anonimus delegate
            ChangeElements(arr, delegate (int v) { return v + 10; });
            foreach (var item in arr) Console.Write(item + " "); Console.WriteLine();

            ChangeElements(arr, delegate (int v) { return --v; });
            foreach (var item in arr) Console.Write(item + " "); Console.WriteLine();
            //lambda expresion
            //ChangeElements(arr, v => { return --v; });
            ChangeElements(arr, v =>  --v );
            foreach (var item in arr) Console.Write(item + " "); Console.WriteLine();


            /*
            Calculator calculator = new Calculator();
            DoOperation(125, 47, calculator.Add);
            DoOperation(125, 47, calculator.Sub);
            DoOperation(125, 47, calculator.Multy);
            DoOperation(125, 47, calculator.Div);
            Console.WriteLine();
            CalculatorDelegate calcDelegate = null;
            calcDelegate += calculator.Add;
            calcDelegate += calculator.Sub;
            calcDelegate += calculator.Multy;
            calcDelegate += calculator.Div;
            calcDelegate -= calculator.Div;

            foreach (var item in calcDelegate.GetInvocationList())
            {
                Console.WriteLine($"Res : {(item as CalculatorDelegate)!.Invoke(100, 25)}");
            }
            */
            /*
            Calculator calculator = new Calculator();
            double x, y;
            int key;
            do
            {
                CalculatorDelegate calcDelegate = null;
                Console.WriteLine("Enter first number ");
                x = double.Parse(Console.ReadLine()!);
                Console.WriteLine("Enter second number ");
                y = double.Parse(Console.ReadLine()!);
                Console.WriteLine("Add  - 1 ");
                Console.WriteLine("Sub  - 2 ");
                Console.WriteLine("Mult  - 3 ");
                Console.WriteLine("Divide  - 4 ");
                Console.WriteLine("Exit  - 0 ");
                key = int.Parse(Console.ReadLine()!);
                switch (key)
                {
                    case 1:
                        calcDelegate = new CalculatorDelegate(calculator.Add);
                        break;
                    case 2:
                        calcDelegate = new CalculatorDelegate(calculator.Sub);
                        break;
                    case 3:
                        calcDelegate = calculator.Multy;
                        break;
                    case 4:
                        calcDelegate = calculator.Div;
                        break;
                    case 0:
                        Console.WriteLine("Good  Buy");
                        break;
                    default:
                        Console.WriteLine("Error choice......");
                        break;
                }

                Console.WriteLine("Res = " + calcDelegate?.Invoke(x, y));
            } while (key != 0);
            */
            /*
            SuperClass superClass = new SuperClass();
            superClass.Test();
            SuperClass.GetKoef();

            DoubleDelegate method = new DoubleDelegate(SuperClass.GetKoef);
           
            if (method == null) 
            {
                Console.WriteLine("method is null");
            }
            else
            {
                Console.WriteLine(method());
            }
            Console.WriteLine(method?.Invoke());

            DoubleDelegate[] arr = new DoubleDelegate[]
            {
                SuperClass.GetKoef,
                superClass.GetNumber
            };
            Console.WriteLine(arr[0].Invoke());
            Console.WriteLine(arr[1]());

            SetStringDelegate stringDelegate = new SetStringDelegate(superClass.Print);   
            VoidDelegate @void = new VoidDelegate(superClass.DoWork);
            stringDelegate.Invoke("Hello academy");
            @void.Invoke();


            //Delegate.Combine(method, superClass.GetType);
            method += new DoubleDelegate(superClass.GetNumber);
            method += superClass.GetNumber;
            method += superClass.GetNumber;
            method += SuperClass.GetKoef;

            foreach (var item in method.GetInvocationList())
            {
                Console.WriteLine( (item as DoubleDelegate)!.Invoke());
            }

            Console.WriteLine($"Last Method : {method.Invoke()}");
            */
        }
    }
}
