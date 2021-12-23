using System;
using System.Collections.Generic;

namespace Lab5
{
    class Program
    {
        delegate void Init(Collection collection, List<Student> students);
        static void Main(string[] args)
        {
            Init init = Add;
            init += Print;

            var students = new List<Student>()
            {
                new Student("tolik","bui","qea","CIT","Computer games",50f,'a'),
                new Student("kkang","bio","vao","CS","Computer games",100f,'a'),
                new Student("Roma","baoi","valya","CIT","Computer games",100f,'a'),
                new Student("vlad","quo","vasya","CS","Computer games",100f,'a'),
                new Student("Serhiy","laok","olya","CIT","Computer games",100f,'a'),
            };

            var collection = new Collection();

            //Add(collection, students);
            //Print(collection, students);
            init(collection, students);

            Console.WriteLine("Remove all from CIT faculty-------------------------------------------------------------------------------------------------------");
            collection.RemomeCIT();

            foreach (var student in collection)
            {
                Console.WriteLine(student.ToString());
            }

            Console.ReadLine();

        }

        static void Add(Collection collection, List<Student> students)
        {
            foreach (var stud in students)
            {
                collection.Add(stud);
            }
        }

        static void Print(Collection collection, List<Student> students)
        {
            foreach (var student in collection)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
