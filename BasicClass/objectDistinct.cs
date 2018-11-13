using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BasicClass
{
    class objectDistinct
    {
        
        public void add()
        {
            List<student> re = new List<student>();
            student a = new student() { Name = "feifei", Id = 2 };
            student a1 = new student() { Name = "kaikai", Id = 1 };
            student a2 = new student() { Name = "kaikai", Id = 3 };
            re.Add(a);
            re.Add(a1);
            re.Add(a2);
            List<student> list = new List<student>();
            foreach (var item in re)
            {
                if (!list.Exists( o => o.Name == item.Name) )
                {
                    list.Add(item);
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(JsonConvert.SerializeObject(item));
            }
            //Console.WriteLine(list);

        }
        
        


    }
}
