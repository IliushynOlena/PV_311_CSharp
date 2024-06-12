

using System.Text;

namespace _02_Array
{
    internal class Program
    {
        static void PrintArr(string text, int[] arr)
        {
            Console.Write(text + ": ");
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {

            #region One dimension arr
            /*
             //1
             //int[] == Array
             //int arr[5] = { 1, 2, 5, 8, 9, 6 };
             int[] arr = new int[5];
             arr[0] = 10;
             arr[1] = 20;
             arr[2] = 30;
             arr[3] = 40;
             arr[4] = 50;

             Console.WriteLine(arr[0]);
             Console.WriteLine(arr[1]);
             Console.WriteLine(arr[2]);
             Console.WriteLine(arr[3]);
             Console.WriteLine(arr[4]);

             //2
             int[]arr2 = new int[5];
             for (int i = 0; i < arr2.Length; i++)
             {
                 arr2[i] = i * 2;
             }

             for (int i = 0; i < arr2.Length; i++)
             {
                 Console.Write(arr2[i] + " ");  
             }
             Console.WriteLine();
             //3
             int[] arr3 = new int[5] { 1,2,3,4,5};
             for (int i = 0; i < arr3.Length; i++)
             {
                 Console.Write(arr3[i] + " ");
             }
             Console.WriteLine();
             //4
             int[] arr4 = new int[] { 11, 12, 13, 14, 1,16,17,18,19,205 };
             for (int i = 0; i < arr4.Length; i++)
             {
                 Console.Write(arr4[i] + " ");
             }
             Console.WriteLine();
             //5
             int a = 0;
             // int[] = Array
             int[] arr6 = null;


             int[] arr5 = new int[10];
             for (int i = 0; i < arr5.Length; i++)
             {
                 Console.Write(arr5[i] + " ");
             }
             Console.WriteLine();

             arr5.SetValue(77, 2);
             arr5.SetValue(22, 3);

             foreach (var item in arr4)
             {
                 //item = 10;//readonly
                 Console.WriteLine(item);
             }
            */
            #endregion

            #region Two dimension arr
            /*
            int[,] arr = new int[3, 3];
            arr[0, 0] = 1;
            arr[0, 1] = 2;
            arr[0, 2] = 3;

            arr[1, 0] = 4;
            arr[1, 1] = 5;
            arr[1, 2] = 6;

            arr[2, 0] = 7;
            arr[2, 1] = 8;
            arr[2, 2] = 9;
            Console.Write(arr[0, 0] + " ");
            Console.Write(arr[0, 1] + " ");
            Console.Write(arr[0, 2] + " ");
            Console.WriteLine();
            Console.Write(arr[1, 0] + " ");
            Console.Write(arr[1, 1] + " ");
            Console.Write(arr[1, 2] + " ");
            Console.WriteLine();
            Console.Write(arr[2, 0] + " ");
            Console.Write(arr[2, 1] + " ");
            Console.Write(arr[2, 2] + " ");
            Console.WriteLine();
            //2
            int[,] arr2 = new int[3, 5];
            Console.WriteLine(arr2.Length);
            for (int i = 0; i <arr2.GetLength(0); i++)//3
            {
                for (int j = 0; j < arr2.GetLength(1); j++)//5
                {
                    arr2[i, j] = i * j + 1;
                }
            }
            for (int i = 0; i <= arr2.GetUpperBound(0); i++)//2
            {
                for (int j = 0; j <= arr2.GetUpperBound(1); j++)//4
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }
            ///4
            int[,] arr4 =
            {
                  { 1,2,3},
                  {4,5,6 },
                  {7,8,9 }
            };
            Console.WriteLine(arr4.Length);
            Console.WriteLine(arr4);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{arr4[i, j]} ");
                }
                Console.WriteLine();
            }
            */
            #endregion

            #region _3D_Arrays
            /*
            int a = 1;
            Console.WriteLine("Number = " + 10);
            Console.WriteLine("Number = " + a +  10);
            Console.WriteLine($"Number  = {a  + 10}");
            
            //1
            int[,,] array = new int[3, 3, 3];

            array[0, 0, 0] = 1;
            array[0, 0, 1] = 2;
            array[0, 0, 2] = 3;
            array[0, 1, 0] = 4;
            array[0, 1, 1] = 5;
            array[0, 1, 2] = 6;
            array[0, 2, 0] = 7;
            array[0, 2, 1] = 8;
            array[0, 2, 2] = 9;

            array[1, 0, 0] = 1;
            array[1, 0, 1] = 2;
            array[1, 0, 2] = 3;
            array[1, 1, 0] = 4;
            array[1, 1, 1] = 5;
            array[1, 1, 2] = 6;
            array[1, 2, 0] = 7;
            array[1, 2, 1] = 8;
            array[1, 2, 2] = 9;

            array[2, 0, 0] = 1;
            array[2, 0, 1] = 2;
            array[2, 0, 2] = 3;
            array[2, 1, 0] = 4;
            array[2, 1, 1] = 5;
            array[2, 1, 2] = 6;
            array[2, 2, 0] = 7;
            array[2, 2, 1] = 8;
            array[2, 2, 2] = 9;


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write("{0} ", array[i, j, k]);
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            }


            //2
            int[,,] array2 =
            {
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 }
                },
                { { 1, 2, 3 }, { 4, 5, 6 }, {7, 8, 9} },
                { { 1, 2, 3 }, { 4, 5, 6 }, {7, 8, 9} }
            };


            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write("{0} ", array2[i, j, k]);
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            }
            */
            #endregion
            #region _4D_Arrays
            /*
              int[,,,] array = new int[2, 2, 2, 2];

             array[0, 0, 0, 0] = 0x0;
             array[0, 0, 0, 1] = 0x1;
             array[0, 0, 1, 0] = 0x2;
             array[0, 0, 1, 1] = 0x3;

             array[0, 1, 0, 0] = 0x4;
             array[0, 1, 0, 1] = 0x5;
             array[0, 1, 1, 0] = 0x6;
             array[0, 1, 1, 1] = 0x7;

             array[1, 0, 0, 0] = 0x8;
             array[1, 0, 0, 1] = 0x9;
             array[1, 0, 1, 0] = 0xA;
             array[1, 0, 1, 1] = 0xB;

             array[1, 1, 0, 0] = 0xC;
             array[1, 1, 0, 1] = 0xD;
             array[1, 1, 1, 0] = 0xE;
             array[1, 1, 1, 1] = 0xF;


             for (int i = 0; i < 2; i++)
             {
                 for (int j = 0; j < 2; j++)
                 {
                     for (int k = 0; k < 2; k++)
                     {
                         for (int l = 0; l < 2; l++)
                         {
                             Console.Write("{0:X} ", array[i, j, k, l]);
                         }
                         Console.Write('\n');
                     }
                     Console.WriteLine();
                 }
                 Console.Write("\n");
             }

             //2
             int[,,,] array2 =
              {
               {
                 { { 0x0, 0x1 }, {0x2, 0x3 } },
                 { { 0x4, 0x5 }, {0x6, 0x7 } }
               },
               {
                 { { 0x8, 0x9 }, {0xA, 0xB } },
                 { { 0xC, 0xD }, {0xE, 0xF } }
               }
             };


             for (int i = 0; i < 2; i++)
             {
                 for (int j = 0; j < 2; j++)
                 {
                     for (int k = 0; k < 2; k++)
                     {
                         for (int l = 0; l < 2; l++)
                         {
                             Console.Write("{0:X} ", array2[i, j, k, l]);
                         }
                         Console.Write("\n");
                     }
                     Console.Write("\n");
                 }
                 Console.Write("\n");
             }
           */
            #endregion
            #region Jagged_array
            /*
               // зубчастий масив
             int[][]jagged = new int[3][];

             jagged[0] = new int[] { 1, 2 };
             jagged[1] = new int[] { 1, 2, 3, 4, 5 };
             jagged[2] = new int[] { 1, 2, 3 };

             Console.WriteLine(jagged.Length);

             // перебор с помощью цикла for
             for (int i = 0; i < jagged.Length; ++i)//3
             {
                 for (int j = 0; j < jagged[i].Length; ++j)
                 {
                    // Console.Write($"{i};{j}={     jagged[i][j]     }  ");
                     Console.Write($" {jagged[i][j]}  ");
                 }
                 Console.Write("\n");
             }

             Console.WriteLine();
             Console.ReadKey(); 

             foreach (int[] item in jagged)
             {
                 foreach (int i in item)
                 {
                     Console.Write(i + "\t");
                 }
                 Console.WriteLine();
             }
              */
            #endregion

            #region ArrayMethods
            /*
            Console.OutputEncoding = Encoding.UTF8;
            int[] myArr1 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            PrintArr("Масив myArr1", myArr1);
            int[] tempArr = (int[])myArr1.Clone(); // shallow copy
            PrintArr("Clone", tempArr);

            //_ = myArr1.Reverse();// cw        
            Array.Reverse(myArr1, 5, 3);
            PrintArr("Масив myArr1 післе реверсу", myArr1);
            myArr1 = tempArr;
            PrintArr("Масив myArr1 післе відновлення", myArr1);
            int[] myArr2 = new int[20];
            PrintArr("Масив myArr2 до копіювання", myArr2);
            myArr1.CopyTo(myArr2, 10);
            PrintArr("Масив myArr2 післе копіювання", myArr2);
            Console.WriteLine(myArr2.Length);
            Console.WriteLine(myArr2.GetLength(0));
            Array.Clear(myArr2, 8, 3);
            PrintArr("Масив myArr2 післе очистки: ", myArr2);
            Array.Resize(ref myArr2, 5);
            PrintArr("Масив myArr2 післе зміни розміру:", myArr2);
            myArr2 = new[] { 1, 5, 3, 2, 8, 9, 6, 10, 7, 4 };
            PrintArr("Несортований масив myArr2: ", myArr2);
            Array.Sort(myArr2);
            PrintArr("Масив myArr2 післе сортування: ", myArr2);
            Console.WriteLine(Array.IndexOf(myArr1, 5));
            Console.WriteLine("Число 5 знаходится в масиве на " +
                Array.BinarySearch(myArr2, 5) + " позиції");

            Console.WriteLine("Максимальный елемент в масиві myArr2: " + myArr2.Max());
            Console.WriteLine("Мінимальный елемент в масиві myArr2: " + myArr2.Min());
            Console.WriteLine("Середнє арифметичне елементів myArr2: " +
                myArr2.Average());

            Console.WriteLine("Кількість вимірів масиву myArr3: " + myArr2.Rank);
            int[,] myArr3 = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine("Количество измерений массива myArr3: " + myArr3.Rank);
            */
            #endregion
            #region MethodsWithArray

            //int[] myArray = { 1, 2, 3, 4, 5 };

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.Write(myArray[i] + ", ");
            //}
            //Console.WriteLine();
            //myArray = ModifyArray(myArray, 5);

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.Write(myArray[i] + ", ");
            //}

            //Console.ReadKey();

            #endregion
            #region Params

            //var numbers = new int[] { 11, 11, 11, 14, 11 };

            ////foreach (var i in numbers.GroupBy(i => i).Where(g => g.Count() == 1).Select(g => g.Key))
            ////    Console.WriteLine(i);


            //int[] items = { 2, 3, 5, 3, 7, 5 };
            //int n = items.Length;

            //Console.WriteLine("Unique array elements: ");

            //for (int i = 0; i < n; i++)
            //{
            //    bool isDuplicate = false;
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (items[i] == items[j])
            //        {
            //            isDuplicate = true;
            //            break;
            //        }
            //    }

            //    if (!isDuplicate)
            //    {
            //        Console.WriteLine(items[i]);

            //    }
            //}

            int[] arr = new int[] { 3, 3, 3, 7, 7, 7 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine()!);
            //}

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            ShowArray(1, arr);
            ShowArray(10, 3, 3, 3, 7, 7, 7,47,58,96,25,23,14,74,54,85);
            //ShowArray("hello", 10, 15, 14, 47, 2, 3, 6, 9, 8);

            //int a = 5;
            ShowArray(2, new int[] { 3, 3, 3, 7, 7, 7 });
            // pause
            //Console.ReadKey();

            //var a = 5;
            Random random = new Random();

            double res = random.Next(100) + random.NextDouble();
            Console.WriteLine(res);

            res = Math.Round(res, 2);
            Console.WriteLine(res);
            ////ShowArray(10, 15, 14, 47, 2, 3, 6, 9, 8);

            #endregion
        }

        static int[] ModifyArray(int[] array, int modifier)
        {
            for (int i = 0; i < array.Length; i++)
            {
                //array[i] = array[i] * modifier;
                array[i] *= modifier;
            }

            return array;
        }
        static void ShowArray(int num, int[] array)
        {
            Console.WriteLine("Number of arr : " + num);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
        static void ShowArray(int a, int b, int c, params int[] array)
        {
            Console.WriteLine();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
    }
}