using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter quantity students: ");
            int number = int.Parse(Console.ReadLine());
            Student[] arrStudent = new Student[number];
            for(int i = 0; i < number; i++)
            {
                arrStudent[i] = new Student();

                Console.WriteLine("Enter data\n");

                Console.WriteLine("Enter name:");
                arrStudent[i].Name = Console.ReadLine();

                Console.WriteLine("Enter surname:");
                arrStudent[i].Surname = Console.ReadLine();

                Console.WriteLine("Enter patronymic:");
                arrStudent[i].Patronymic = Console.ReadLine();

                Console.WriteLine("Enter birthday year:");
                int byear = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter birthday month:");
                int bmonth = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter birthday day:");
                int bday = int.Parse(Console.ReadLine());
                arrStudent[i].Birthday = new DateTime(byear, bmonth, bday);

                Console.WriteLine("Enter receipt year:");
                int ryear = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter receipt month:");
                int rmonth = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter receipt day:");
                int rday = int.Parse(Console.ReadLine());
                arrStudent[i].ReceiptDate = new DateTime(ryear, rmonth, rday);

                Console.WriteLine("Enter faculty:");
                arrStudent[i].Faculty = Console.ReadLine();

                Console.WriteLine("Enter speciality:");
                arrStudent[i].Speciality = Console.ReadLine();

                Console.WriteLine("Enter group index:");
                arrStudent[i].GroupIndex = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Enter academic performance:");
                arrStudent[i].AcademicPerformance = float.Parse(Console.ReadLine());
            }

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Student {i}");
                Console.WriteLine(arrStudent[i].ToString());
            }
            Console.ReadLine();
        }
    }
}
