using System.Text;

namespace _01_IntroToCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            object obj = new object();

            byte a = 255;

            byte b = 5;

            short c = 3;
            Int16 s = 4;
            //Console.WriteLine(  a);

            Console.WriteLine("Hello world");
            Console.Write("Hello\n");
            Console.Write("\tHello\n");
            Console.Write("\t\tHello");
            Console.Write("Hello");
            Console.Write("Hello");
            Console.Write("Hello");
            Console.Write("Hello\n");

            Console.WriteLine("Enter number : ");
            string str = Console.ReadLine();

            int number = int.Parse(str);
            Console.WriteLine(str + "!!!!!");
            Console.WriteLine(str + 100);
            Console.WriteLine(number + 100);
            Console.WriteLine("You entered " + number + 100 + "!!!!!");
            Console.WriteLine($"You entered  {number + 100} !!!!!");


            int d = 0;
            //int r = null;
            //Nullable< int> r = null;
            //int* ptr = nullptr;
            //int* ptr = new int(5);


            //null
            int? r = null;
            */
            /*
            Console.OutputEncoding = Encoding.Unicode;
            DateTime now = DateTime.Now;

            Console.WriteLine(now);

            Console.WriteLine($"ToShortTimeString : {now.ToShortTimeString()}");
            Console.WriteLine($"ToShortDateString : {now.ToShortDateString()}");
            Console.WriteLine($"ToLongTimeString : {now.ToLongTimeString()}");
            Console.WriteLine($"ToLongDateString : {now.ToLongDateString()}");
            Console.WriteLine($"Custom : {now.ToString("yyyy-MM-dd")}");




            int a = 5;
            //implicit
            float d = a;//5.0000000
            //explicit
            int b = (int) 3.14;
            //Nullable<int> num2 = null;
            //or
            int? num2 = null;

            string str = null;
            string str3 = "Hello";
            string str2 = str;

            if (str != null)
                str.ToUpper();
            //or
            str?.ToLower(); 
            str?.ToLower();
            str?.ToUpper();//? - null-conditional operator
                           ////
            str2 = (str == null ? "Error" : str);
            //or
            if (str == null)
            {
                str2 = "Error";
            }
            else
            {
                str2 = str;
            }
            //or
            str2 = str ?? "Empty";//?? -null - conditional operator

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(-10, 10));
            }
            Console.WriteLine(random.Next());//0....maxInt
            Console.WriteLine(random.Next(100));//0....99
            Console.WriteLine(random.Next(100, 500));//100....499
            Console.WriteLine(random.NextDouble());//0....1

            if (3 > 8)
            {
                Console.WriteLine(">");
            }
            else
            {
                Console.WriteLine("<");
            }
            //while (true)
            //{

            //}
            //do
            //{

            //} while (true);
            // Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Cyan;
            bool myBool = true;
            bool myBool1 = false;
            short myShort = 6;
            //implicit
            int myInt = myShort;//short - int

            float f1 = 4.5f;//8
            int i1 = 44;//f
            float f2 = f1 + i1;//48.5
            double d1 = f2;//48.500000000000000000
                           //int i2 = f2;//48//error

            //explicit
            int i2 = (int)f2;

            Console.WriteLine("Enter number : ");
            string numberStr = Console.ReadLine();
            int number2 = int.Parse(numberStr);

            Console.WriteLine($"Number {numberStr}");
            
            number2 = Convert.ToInt32(numberStr);
            Console.WriteLine($"Number {numberStr}");


            try
            {
                numberStr = Console.ReadLine();
                float float_number = Convert.ToSingle(numberStr);
                Console.WriteLine($"Number float {numberStr}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Continue...............");
            Console.WriteLine("Continue...............");
            Console.WriteLine("Continue...............");
            Console.WriteLine("Continue...............");
            */
            /////////////////////// Invoke Methods
            //Literals();
            //FormatString();
            ConsoleMethods();
            // Console.WriteLine();    
        }
        static void FormatString()
        {
            Console.OutputEncoding = Encoding.Unicode;
            /////////////////////// Escape Sequences
            /*
                \'      – single quote, needed for character literals
                \"      – double quote, needed for string literals
                \\      – backslash
                \0      – Unicode character 0
                \a      – Alert (character 7)
                \b      – Backspace (character 8)
                \f      – Form feed (character 12)
                \n      – New line (character 10)
                \r      – Carriage return (character 13)
                \t      – Horizontal tab (character 9)
                \v      – Vertical quote (character 11)
                \uxxxx  – Unicode escape sequence for character with hex value xxxx                
            */
            Console.WriteLine("Некоторое простое сообщение\nИещё " +
                "одно простое сообщение на " +
                "новой строке" +
                "fjdsokghdklghksdl" +
                "djldkglkfhdkf");
            /*выводит в консоль следующее сообщение:
            Некоторое простое сообщение
            И ещё одно простое сообщение на новой строке*/
            Console.WriteLine("Пример табуляции: " +
             "\n1\t2\t3\n4\t5\t6");
            /*выводит в консоль следующее сообщение:
            Пример табуляции:
            1. 2 3
            4. 5 6*/
            Console.WriteLine("kghfdkjgh" +
                "sdjfisdgiusgf" +
                "sdhfiusdgfuisd" +
                "dsihfsdigiusd" +
                "shdgoisdgh");
            Console.WriteLine(@"C:\Users\helen\Desktop\Work\C#\1");
            /////////////////////// @ - litteral formatting
            Console.WriteLine(@"Пример буква        льного
         hhjfhf
                C:\Users\helen\Desktop\Work\C#\1
             kdfjgoihiodfhoihb
            строкового литерала:
ehoiweiowegtowei
            1 \t 3
            \n 5 6");


            /*выводит в консоль следующее сообщение:
            Пример буква        льного
            
            
            строкового литерала:
            1 \t 3
            \n 5 6*/

            /////////////////////// string concat
            string name = "Bob";
            int day = 29;
            bool isValid = true;

            Console.WriteLine("Hello " + name + " Day: " + day.ToString());
            Console.WriteLine("Hello " + name + " Day: " + day); // ToString() is called automatically
            // string interpolation: $ - operator
            Console.WriteLine($"Hello, {name}\tDay: {day}\nValid: {isValid}{{}}");
            // $ + @
            Console.WriteLine($@"Hello, {name}\tDay: {day}\nValid: {isValid}{{}}");
        }
        static void Literals()
        {

            /*при помощи метода GetType() программа возвращает
            тип данных литералов, демонстрируя действие суффиксов*/
            Console.WriteLine((10).GetType());  /*выводит в консоль: System.Int32 что соответствует типу данных int*/
            Console.WriteLine((10D).GetType()); /*выводит в консоль: System.Double что соответствует типу данных double*/
            Console.WriteLine((10f).GetType()); /*выводит в консоль: System.Single что соответствует типу данных float*/
            Console.WriteLine((10m).GetType()); /*выводит в консоль: System.Decimal что соответствует типу данных decimal*/
            Console.WriteLine((10L).GetType()); /*выводит в консоль: System.Int64 что соответствует типу данных long*/
            Console.WriteLine((10UL).GetType());/*выводит в консоль: System.Uint64 что соответствует типу данных ulong*/
            Console.WriteLine(0xFF);            /*выводит в консоль: 255 шестнадцатиричное число 0xFF соответствуетa десятичному числу 255*/
        }
        static void ConsoleMethods()
        {
            //изменяет заголовок окна консоли
            Console.Title = "Пример использования инструментов класса Console";
            //изменяет цвет фона
            Console.BackgroundColor = ConsoleColor.Green;
            //изменяет цвет текста                      
            Console.ForegroundColor = ConsoleColor.Magenta;
            //получаем размер самого длинного сообщения в рамках нашей программы
            //int length = ("Input Encoding: " + Console.InputEncoding.ToString()).Length + 1;
            Console.WriteLine("Input Encoding: dsnbfdjskjghdfjkghdfkjghdfjkhkjgbksdjghskghskdghkdsjgh");
            int length = ("Input Encoding: dsnbfdjsbsdjghdfjkghdfkjghdfjkhkjgbksdjghskghskdghkdsjgh ").Length + 1;
            Console.SetWindowSize(length, 8);
            //устанавливаем размер окна консоли
            /*устанавливаем размер буфера консоли
            (размер окна должен быть
            соответствующим и должен быть
            установлен до того, как мы изменим
            размер буфера)*/
            //Console.SetBufferSize(length, 8);
            //выводим информацию о кодировке потока ввода
            Console.WriteLine("Input Encoding: " + Console.InputEncoding.ToString());
            //выводим информацию о кодировке потока вывода
            Console.WriteLine("Output Encoding: " + Console.OutputEncoding.ToString());
            //устанавливает зеначение цвета текста в значение по умолчанию
            Console.ResetColor();
            //выводим информацию о том, нажат ли NUM LOCK
            Console.WriteLine("Is NUM LOCK turned on: " + Console.NumberLock.ToString());
            //выводим информацию о том, нажат ли CAPS LOCK
            Console.WriteLine("Is CAPS LOCK turned on: " + Console.CapsLock.ToString());
            /*выводим пользователю сообщение
            о том, что программа ожидает ввода
            некоторой информации*/
            Console.Write("Enter a simpe message: ");
            //получаем от пользователя текстовое сообщение
            string message = Console.ReadLine();
            //выводим сообщение, введённое пользователем
            Console.WriteLine("Your message is: " + message);
            //звук beep
            Console.Beep(300, 3000);
            //очистка консоли
            Console.Clear();
            Console.WriteLine("Your message is: " + message);
        }
    }
}
