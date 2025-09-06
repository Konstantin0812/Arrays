namespace _01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] days =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            int numberOfday = int.Parse(Console.ReadLine());

            if (numberOfday >= 1 && numberOfday <= 7)
            {
                numberOfday--;
                Console.WriteLine(days[numberOfday]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}
