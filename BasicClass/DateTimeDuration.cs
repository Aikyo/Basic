using System;
using System.Collections.Generic;
using System.Text;

namespace BasicClass
{
    public static class DateTimeDuration
    {
        public static void GetDuration()
        {
            DateTime time = DateTime.Now;

            //DateTime d = DateTime.Parse("2018-9-18-22");
            // time.Ticks
            DateTime d = new DateTime(2018, 9, 21, 0, 0, 0);
            DateTime d1 = new DateTime(2018, 9, 25, 0, 0, 0);
            Console.WriteLine(time);

            TimeSpan t1 = new TimeSpan(d.Ticks);
            TimeSpan t2 = new TimeSpan(time.Ticks);

            TimeSpan ts = new TimeSpan(d.Ticks);
            TimeSpan ts2 = new TimeSpan(d1.Ticks);
            Console.WriteLine(ts2.Subtract(ts).Duration() +  "  21 //25");

            TimeSpan t3 = t1.Subtract(t2).Duration();
            Console.WriteLine(t3.Days + " days ");
        }
    }
}
