using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data1 = new DateTime(2000, 12, 12);
            DateTime data2 = new DateTime(2019, 9, 1);

            var dima = new Student("tolik", "bui", "zui", "CIT", "Computer games", 50f, 'a',data1,data2);

            Console.WriteLine(dima.Age);
            Console.WriteLine(dima.Course);

            var students = new List<Student>()
            {
                new Student("tolik","bui","zui1","CIT","Computer games",50f,'a'),
                new Student("Dima","bui","bui1","CIT","Computer games",100f,'a'),
            };

            var collection = new Collection();

            foreach (var stud in students)
            {
                collection.Add(stud);
            }

            Console.ReadLine();
        }
    }
}
