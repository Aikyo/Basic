using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    class B
    {
        A a = new A();
        public void show()
        {
            Console.WriteLine("this is b class");
        }
    }
}
