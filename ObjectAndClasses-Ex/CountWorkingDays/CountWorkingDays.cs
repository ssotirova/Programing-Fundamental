using System;
using System.Globalization;
using System.Linq;

namespace CountWorkingDays
{
    class CountWorkingDays
    {
        static void Main(string[] args)
        {
            string firstDay = Console.ReadLine();
            string secondDay = Console.ReadLine();

            DateTime firstDate = DateTime.ParseExact(firstDay, "d-M-yyyy", CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(secondDay, "d-M-yyyy", CultureInfo.InvariantCulture);

            DateTime[] holiday = new DateTime[12];

            holiday[0] = new DateTime(4, 01, 01);
            holiday[1] = new DateTime(4, 03, 03);
            holiday[2] = new DateTime(4, 05, 01);
            holiday[3] = new DateTime(4, 05, 06);
            holiday[4] = new DateTime(4, 05, 24);
            holiday[5] = new DateTime(4, 09, 06);
            holiday[6] = new DateTime(4, 09, 22);
            holiday[7] = new DateTime(4, 11, 01);
            holiday[8] = new DateTime(4, 12, 24);
            holiday[9] = new DateTime(4, 12, 25);
            holiday[10] = new DateTime(4, 12, 26);

            int workingDays = 0;

            for (DateTime i = firstDate; i <= secondDate; i = i.AddDays(1))
            {
                DayOfWeek day = i.DayOfWeek;
                DateTime temp = new DateTime(4, i.Month, i.Day);

                if (!holiday.Contains(temp) && !day.Equals(DayOfWeek.Sunday) && !day.Equals(DayOfWeek.Saturday))
                {
                    workingDays++;
                }
            }

            Console.WriteLine(workingDays);
        }
    }
}
