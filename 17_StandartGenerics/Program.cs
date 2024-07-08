using System.Collections;
using System.Diagnostics;
using System.Text;

namespace _17_Collection
{
    class MyClass
    {


        int num;
        public MyClass(int number)
        {
            num = number;
        }

    }
    class Student
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            #region ArrayList
            /*
           ArrayList arrayList1 = new ArrayList();
           ArrayList arrayList2 = new ArrayList(new int[] { 1, 2, 5, 8 });
           ArrayList arrayList3 = new ArrayList(10);
           Console.WriteLine($"Місткість по замовчуванню:{arrayList1.Capacity}");
           arrayList1.Add("one");
           arrayList1.Add(3.14f);
           arrayList1.Add(0.999);
           arrayList1.Add(3.36m);
           arrayList1.Add(false);

           Console.WriteLine($"Місткість после добавления одного элемента: {arrayList1.Capacity}");
           arrayList1.AddRange(new int[] { 2, 5, 48, 14 });
           Console.WriteLine($"ВместМісткістьмость после добавления коллекции: {arrayList1.Capacity}");
           arrayList1.Capacity = 10;
           Console.WriteLine($"Місткість задана через свойство:{arrayList1.Capacity}   ");
           Console.WriteLine($"Фактическое количество элементов:{arrayList1.Count} ");
           arrayList1.TrimToSize();
           Console.WriteLine($"Місткість уменьшена до реального количества элементов:{arrayList1.Capacity}");
           Console.WriteLine($"Элемент с индексом 2:{arrayList1[2]}");
           Console.WriteLine("Все элементы коллекции:");
           //arrayList1.Sort();
           foreach (object item in arrayList1)
           {

                Console.WriteLine($"\t{item}");
                if (item is int)
                {
                    int a = (int)item;
                    a++;
                    Console.WriteLine(a);
                }
                if (item is float)
                {
                    float a = (float)item;
                    a--;
                    Console.WriteLine(a);
                }
            }


           Console.Write("Исходная коллекция: ");
           ArrayList arrayList = new ArrayList(new int[] { 1, 2, 3, 4 });
           foreach (int i in arrayList)
           {
               Console.Write($"{i} ");
           }
           Console.Write("\n\nВставка элемента: ");
           arrayList.Insert(2, "Hello");
           //arrayList.Sort();
           foreach (object item in arrayList)
           {
               Console.Write($"{item} ");
           }
           Console.Write("\n\nУдаление элемента: ");
           arrayList.RemoveAt(3);
           foreach (object item in arrayList)
           {
               Console.Write($"{item} ");
           }
           Console.WriteLine("\n\nИндекс элемента \"Hello\": " + arrayList.IndexOf("Hello"));
           Console.Write("\nПолучение диапазона: ");
           ArrayList days = new ArrayList(new string[]{ "Sunday", "Monday", "Tuesday","Wednesday", "Thursday",
               "Friday","Saturday" });
           ArrayList onlyWork = new ArrayList(days.GetRange(1, 5));
           foreach (string s in onlyWork)
           {
               Console.Write($"{s} ");
           }
           Console.Write("\n\nСортировка коллекции: ");
           onlyWork.Sort();
           foreach (string s in onlyWork)
           {
               Console.Write($"{s} ");
           }
           Console.WriteLine();
          */
            #endregion
            #region Stack
            /*
            Stack stack1 = new Stack(); // вместимость по умолчанию
            Stack stack2 = new Stack(7); // начальное значение емкости
                                         // элементы копируются из указанной коллекции
            Stack stack3 = new Stack(new ArrayList { 3, 5 });

            Stack stack = new Stack();
            Console.Write("Метод Push(): ");
            stack.Push("one");
            stack.Push("two");
            stack.Push("three");
            foreach (string item in stack)
            {
                Console.Write($"{item} ");
            }
            Console.Write("\n\nМетод Pop(): ");
            stack.Pop();
            foreach (string item in stack)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine($"\n\nМетод Peek():{(string)stack.Peek()}");
            Console.WriteLine("\nСуществует ли элемент \"ten\": " + stack.Contains("ten")); // false
            Console.WriteLine("\nСуществует ли элемент \"two\": " + stack.Contains("two")); // true
            Console.Write("\nМетод CopyTo(): ");
            string[] strArr = new string[stack.Count];
            stack.CopyTo(strArr, 0);
            foreach (string item in strArr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n\nКоличество элементов: " + stack.Count); // 3
            stack.Clear();
            Console.WriteLine("\nКоличество элементов вызова метода Clear(): " + stack.Count); // 0



            ///////////////////////////////////////
            var stackk = new Stack();
            stackk.Push("First");
            stackk.Push("Second");
            stackk.Push("Third");
            stackk.Push("Fourth");
            // Peek() - get first
            if (stackk.Peek() is string)
            {
                string str = (string)stackk.Pop();
                Console.WriteLine(str);
            }
            while (stackk.Count > 0)
            {
                Console.WriteLine(stackk.Pop());
            }
            Console.WriteLine(stackk.Pop());
            Console.ReadKey();
            */
            #endregion

            #region BoxingUnboxing
            /*
            object obj = new object();//ref
            int number = 45;//value - stack

            //boxing
            obj = (object) number;//value - ref
            Console.WriteLine(obj);

            //unboxing
            number = (int)obj;
            Console.WriteLine(number);

            //boxing
            //MyClass myClass = new MyClass(number);//value => ref

            //unboxing
            //int res = (int)myClass;

            int a = 5;
            string str = "Hello";
            ArrayList arrayList1 = new ArrayList(new int[] { 1, 2, 5, 8 });
            ArrayList arrayList3 = new ArrayList(10);
            Console.WriteLine($"Вместимость по умолчанию:{arrayList1.Capacity}");
            arrayList1.Add("one");
            arrayList1.Add(3.14f);
            arrayList1.Add(0.999);
            arrayList1.Add(3.36m);
            arrayList1.Add(false);
            //List<Student> list = new List<Student>();   
            int b = (int)arrayList1[0];

        */
            #endregion

            #region SortedList HashTable
            /*
                SortedList sortedList = new SortedList();
                sortedList.Add(3, 6.7);
                sortedList.Add(2, new Student
                {
                    Name = "Jack"
                });
                sortedList.Add(1, "one");
                //sortedList.Add("one" ,1 );
                Console.WriteLine("----- Вывод ключ-значение ------\n");
                foreach (object item in sortedList.Keys)
                {
                    Console.WriteLine($"Ключ: {item}  Значение: {sortedList[item]}");
                }
                Console.WriteLine("\n------- Вывод ключ-значение по индексу--------\n");
                for (int i = 0; i < sortedList.Count; i++)
                {
                    Console.WriteLine($"Ключ: {sortedList.GetKey(i)} Значение: {sortedList.GetByIndex(i)}");

                }
                Console.WriteLine("\n---- Коллекция значений -----\n");
                foreach (object item in sortedList.Values)
                    Console.WriteLine(item);
                Console.WriteLine("\n----- Удаление элемента по ключу 3------\n");
                sortedList.Remove(3);
                Console.WriteLine($"Существует ли элемент 3:{sortedList.ContainsKey(3)}"); // false
            */
             
         /*
            Hashtable hash = new Hashtable();
            hash.Add(1, "John");
            hash.Add("two", new Student { Name = "Jack" });
            hash.Add("Pi", 3.14159);
            hash.Add(true, 3.14159);
            hash.Add(3.14, "PI");
            Console.WriteLine("----- Вывод ключ-значение -------\n");

            foreach (object item in hash.Keys)
            {
                Console.WriteLine("Ключ: " + item + " Значение: " + hash[item]);
            }

            Console.WriteLine("\n----- Коллекция значений после добавление элемента---- -\n");
            foreach (object item in hash.Values) Console.WriteLine(item);
            Console.WriteLine("\n----- Удаление элемента по ключу\"two\" ------\n");
            hash.Remove("two");
            Console.WriteLine($"Существует ли элемент \"two\":{hash.ContainsKey("two")}"); // false


            */



            #endregion

        }
    }
}