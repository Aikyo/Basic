using System;
using System.Collections.Generic;
using System.Text;

namespace BasicClass
{
    class DateTimeFormat
    {
        public void show()
        {
            DateTime t1 = DateTime.Now;
            Console.WriteLine(t1.ToShortTimeString());
            Console.WriteLine(t1.ToShortDateString());
            Console.WriteLine(t1.ToOADate());
            Console.WriteLine(t1.ToUniversalTime());
            Console.WriteLine(t1.ToString("yyyy.M.d"));
        }
    }
}
