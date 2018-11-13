using System;
using System.Collections.Generic;
using System.Text;

namespace BasicClass
{
    class A
    {
        public virtual void start()
        {
            Console.WriteLine("start");
        }
        public void end()
        {
            Console.WriteLine("end");
        }
    }
    class B :A
    {
        public override void start()
        {
            Console.WriteLine();
        }
    }
}
