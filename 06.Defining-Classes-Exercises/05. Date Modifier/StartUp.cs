using System;
using System.Globalization;

namespace DateModifier
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string inputDate1 = Console.ReadLine();
            string inputDate2 = Console.ReadLine();

            DateModifier dates = new DateModifier();

            dates.Date1 = DateTime.Parse(inputDate1);
            dates.Date2 = DateTime.Parse(inputDate2);

            int difference = dates.GetDaysDifference();

            Console.WriteLine(difference);
        }
    }
}
