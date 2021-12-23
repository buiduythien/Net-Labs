using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>()
            {
                new Student("tolik","bui","qea","CIT","Computer games",50f,'a'),
                new Student("kkang","bio","vao","CS","Computer games",100f,'a'),
                new Student("Roma","baoi","valya","CIT","Computer games",100f,'a'),
                new Student("vlad","quo","vasya","CS","Computer games",100f,'a'),
                new Student("Serhiy","laok","olya","CIT","Computer games",100f,'a'),
            };

            var collection = new Collection();

            foreach (var stud in students)
            {
                collection.Add(stud);
            }

            collection.RemomeCIT();

            foreach (var student in collection)
            {
                Console.WriteLine(student.ToString());
            }

            Console.ReadLine();
        }
    }
}
