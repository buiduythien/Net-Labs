using System;
using System.Collections.Generic;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>()
            {
                new Student("tolik","bui","Andreevich","CIT","Computer games",50f,'a'),
                new Student("tolik","zui","Olegovich","CIT","Computer games",100f,'a'),
            };

            var collection = new Collection();

            foreach(var stud in students)
            {
                collection.Add(stud);
            }

            Console.WriteLine(collection["rolik","qwe"]?.ToString());
            Console.WriteLine(collection["zxc", "tolik"]?.ToString());

            foreach(var student in collection)
            {
                Console.WriteLine(student.ToString());
            }
            Console.ReadLine();
        }
    }
}
