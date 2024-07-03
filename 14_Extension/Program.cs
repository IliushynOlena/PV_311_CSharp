using System.Net.Security;

namespace _14_Extension
{
    static class ExampleExtension
    {
        public static int NumberWords(this string data)
        {
            if(string.IsNullOrEmpty(data))return 0;
            return data.Split(new char[] {' ',',','.','!','?'}, 
                StringSplitOptions.RemoveEmptyEntries).Length;      
        }
        public static int NumberSymbol(this string data, char s)
        {
            
            if (string.IsNullOrEmpty(data)) return 0;

            int count = 0;
            foreach (char c in data) 
            { 
                if (c == s) count++;
            }
            return count;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Lorem Ipsum is simply dummy text of the printing and " +
               "typesetting industry. Lorem Ipsum has been the industry's" +
               " standard dummy text ever since the 1500s, when an unknown " +
               "printer took a galley of type and scrambled it to make " +
               "a type specimen book. ";
            Console.WriteLine($"Count words : {str.NumberWords()}");
            Console.WriteLine($"Count symbols 'o' : {str.NumberSymbol('o')}");
            Console.WriteLine($"Count symbols 'a' : {str.NumberSymbol('a')}");
       
        }
    }
}
