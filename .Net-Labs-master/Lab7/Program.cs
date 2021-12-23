using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
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

            foreach (var student in collection)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine("-------------------------------------------------------------------------------------------------------");

            //отложенное выполнение запросов;
            var selectedStudents = from s in students where s.Name == "Dima" select s;
            foreach(var s in selectedStudents)
            {
                Console.WriteLine(s.ToString());
            }

            Console.WriteLine("-------------------------------------------------------------------------------------------------------");

            //принудительное выполнение запросов
            int countDima = (from s in students where s.Name == "Dima" select s).Count();

            Console.WriteLine(countDima);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");

            //использование статистических функций
            var average = students.Average(s => s.AcademicPerformance);
            Console.WriteLine(average);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");

            //смешанный синтаксис запроса и метода
            IEnumerable<Student> studentsQuery = from s in students where s.Name == "Dima" select s;
            Console.WriteLine(studentsQuery.Count());

            Console.WriteLine("-------------------------------------------------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
