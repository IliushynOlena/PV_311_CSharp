using System.Text;

namespace _05_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            string str = "hello";
            str += "hello";

           var res =  str.Reverse();  
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
                char.IsLower(str[i]);
            }
           
            StringBuilder builder = new StringBuilder();
            Console.WriteLine($"Length : {builder.Length}");
            Console.WriteLine($"Capacity : {builder.Capacity}");

            builder.Append("Hello");
            builder.Append("Hello");
            builder.Append("Hello");
            Console.WriteLine($"Length : {builder.Length}");
            Console.WriteLine($"Capacity : {builder.Capacity}");

            builder.AppendLine("world");
            Console.WriteLine($"Length : {builder.Length}");
            Console.WriteLine($"Capacity : {builder.Capacity}");


            Console.WriteLine(builder);
            builder.Append("Hello");
            builder.Append("Hello");
            builder.Append("Hello");
            Console.WriteLine($"Length : {builder.Length}");
            Console.WriteLine($"Capacity : {builder.Capacity}");
            Console.WriteLine(builder);

           

        }
    }
}
