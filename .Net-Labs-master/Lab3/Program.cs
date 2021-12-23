using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Lab3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var students = new List<Student>()
            {
                new Student("tolik","qwe","qqqwww","CIT","Computer games",50f,'a'),
                new Student("khang","Mensasdasdhakov","wwwwe","CIT","Computer games",100f,'a'),
                new Student("thien","zxc","qqe","CIT","Computer games",100f,'a'),
                new Student("olya","zxcaa","wwe","CIT","Computer games",100f,'a'),
            };

            var collection = new Collection();

            foreach (var stud in students)
            {
                collection.Add(stud);
            }

            bool menu = true;
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<Student>));

            while (menu)
            {
                Console.WriteLine("What do you whant: 1-Show 2-Add 3-Remove 4-Seriallize 5-Desiriallize 6-Exit\n");
                int choose = Int32.Parse(Console.ReadLine());
                switch(choose)
                {
                    case 1:
                        foreach (var student in collection)
                        {
                            Console.WriteLine(student.ToString());
                        }
                        break;
                    case 2:
                        collection.Add(CreateStudent());
                        break;
                    case 3:
                        Console.WriteLine("Enter name:");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter surname:");
                        string surname = Console.ReadLine();

                        collection.Remove(surname, name);
                        break;
                    case 4:

                        using (var file = new FileStream("studentsCollection.json", FileMode.OpenOrCreate))
                        {
                            jsonFormatter.WriteObject(file, collection.GetStudents());
                        }
                        break;
                    case 5:
                        collection.Clear();
                        using (var file = new FileStream("studentsCollection.json", FileMode.OpenOrCreate))
                        {
                            var newStudents = jsonFormatter.ReadObject(file) as List<Student>;

                            if (newStudents != null)
                            {
                                foreach (var student in newStudents)
                                {
                                    collection.Add(student);
                                }
                            }
                        }
                        break;
                    case 6:
                        menu = false;
                        break;
                }
            }

            Console.ReadLine();
        }

        static Student CreateStudent()
        {
            Student student = new Student();

            Console.WriteLine("Enter data\n");

            Console.WriteLine("Enter name:");
            student.Name = Console.ReadLine();

            Console.WriteLine("Enter surname:");
            student.Surname = Console.ReadLine();

            Console.WriteLine("Enter patronymic:");
            student.Patronymic = Console.ReadLine();

            Console.WriteLine("Enter birthday year:");
            int byear = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter birthday month:");
            int bmonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter birthday day:");
            int bday = int.Parse(Console.ReadLine());
            student.Birthday = new DateTime(byear, bmonth, bday);

            Console.WriteLine("Enter receipt year:");
            int ryear = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter receipt month:");
            int rmonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter receipt day:");
            int rday = int.Parse(Console.ReadLine());
            student.ReceiptDate = new DateTime(ryear, rmonth, rday);

            Console.WriteLine("Enter faculty:");
            student.Faculty = Console.ReadLine();

            Console.WriteLine("Enter speciality:");
            student.Speciality = Console.ReadLine();

            Console.WriteLine("Enter group index:");
            student.GroupIndex = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter academic performance:");
            student.AcademicPerformance = float.Parse(Console.ReadLine());

            return student;
        }
    }
}
