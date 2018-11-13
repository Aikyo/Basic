using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicClass
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //DateTimeDuration.GetDuration();
            //concatList.ConcatList();
            //localhost:44345/Reservation/FYProduct
            //string s = Client.GetAsync("http://localhost:44345/Reservation/order?OrderId=3");
            //Console.Write(s);

            //Implement imp = new Implement();
            //imp.show();

            //时间变大
            //DateTimeCompareto c = new DateTimeCompareto();
            //DateTime t1 = new DateTime(2018, 1, 25, 0, 0, 0);
            //int a = c.Compare(t1, DateTime.Now);
            //Console.WriteLine(a);


            //JsonConvert
            //student s = new student();
            //s.Name = "herman";
            //s.Race = "Dragon";
            //s.Id = 97;
            //string ss = JsonConvert.SerializeObject(s);

            //Console.WriteLine(ss);
            //student stu = JsonConvert.DeserializeObject<student>(ss);

            //datatime format
            //DateTimeFormat d = new DateTimeFormat();
            //d.show();

            //collection
            List<int> lst = new List<int>() { 1, 45, 478, 52 };
            List<int> List2 = new List<int>() { 45, 52 };
            foreach (var item in lst.Except(List2))
            {
                Console.WriteLine(item);
            }




            // list<object> distinct
            //objectDistinct a = new objectDistinct();
            //a.add();

            List<student> students = new List<student>();
            student s1 = new student() { Name = "小飞飞", Id = 1 };
            student s2 = new student() { Name = "贝贝哥", Id = 2 };
            student s3 = new student() { Name = "子龙", Id = 3 };
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);

            List<student> list1 = new List<student>();
            list1.Add(s1);
            students.Except(list1).ToList().ForEach(x => {
                Console.WriteLine(x.Name + "  "+ x.Id);
            });

            //students.ForEach(x => {
            //    Console.WriteLine(x.Name + " " + x.Id);
            //});
            var person = new
            {
                id = 1212,
                name = "kk",
                data = new {
                    Keyword1 = new {
                        color = "red",
                        value = "小飞飞"
                    }
                },
               
            };

            string ss = JsonConvert.SerializeObject(person);
            Console.WriteLine(ss);

            string name = "如来佛祖玉皇大帝观音大士指定取西经特派使者花果山水帘洞美猴王齐天大圣孙悟空";
            bool re = name.Contains("美猴王");
            Console.WriteLine(re);

        }
    }
}
