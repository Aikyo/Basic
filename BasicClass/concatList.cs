using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass
{
    public static class concatList
    {
        public static void ConcatList()
        {
            List<string> list1 = new List<string>();
            list1.Add(" i ");
            list1.Add(" am ");

            List<string> list2 = new List<string>();
            list2.Add(" totora ");

            
            List<string> list3 = list1.Union(list2).ToList();
            foreach (var i in list3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
