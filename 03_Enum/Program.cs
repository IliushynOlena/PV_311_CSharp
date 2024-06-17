namespace _03_Enum
{
    enum DayOfWeek
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
    enum TransportType
    {
        Semitrailer, Coupling, Refrigerator, OpenSideTruck, Tank
    }
    enum Discount
    {
        Default, Incentive = 2, Patron = 5, VIP = 15
    }
    class Program
    {
        public static DayOfWeek NextDay(DayOfWeek day)
        {
            return (day < DayOfWeek.Sunday) ? ++day : DayOfWeek.Monday;
        }
        static void Main(string[] args)
        {

            DayOfWeek day = DayOfWeek.Sunday;

            day = NextDay(day);

            Console.WriteLine($"Next day (name): {day.ToString()}");
            Console.WriteLine($"Next day (name): {day}");
            Console.WriteLine($"Next day (value): {(int)day}");

            

            string[] names = Enum.GetNames(typeof(TransportType));

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Discount[] values = (Discount[])Enum.GetValues(typeof(Discount));

            foreach (Discount item in values)
            {
                Console.WriteLine($"{item} - {(int)item}");
            }
        }
    }
}
