using System;

namespace Lab2
{
    /// <summary>
    /// Class of student
    /// </summary>
    class Student
    {
        #region Fields&Propertys
        /// <summary>
        /// Private field _name
        /// </summary>
        private string _name;
        /// <summary>
        /// Public property Name
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {

                if (value.Length > 1)
                {
                    _name = value;
                }
                else
                {
                    _name = "N/D";
                    Console.WriteLine("Name did not pass validation!");
                }
            }
        }
        /// <summary>
        /// Private field _surname
        /// </summary>
        private string _surname;
        /// <summary>
        /// Public property Surname
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }

            set
            {

                if (value.Length > 1)
                {
                    _surname = value;
                }
                else
                {
                    _surname = "N/D";
                    Console.WriteLine("Surname did not pass validation!");
                }
            }
        }
        /// <summary>
        /// Private field _patronymic
        /// </summary>
        private string _patronymic;
        /// <summary>
        /// Public property Patronymic
        /// </summary>
        public string Patronymic
        {
            get
            {
                return _patronymic;
            }

            set
            {

                if (value.Length > 1)
                {
                    _patronymic = value;
                }
                else
                {
                    _patronymic = "N/D";
                    Console.WriteLine("Patronymic did not pass validation!");
                }
            }
        }
        /// <summary>
        /// Private field _birthday
        /// </summary>
        private DateTime _birthday;
        /// <summary>
        /// Public property birthday
        /// </summary>
        public DateTime Birthday
        {
            get
            {
                return _birthday;
            }

            set
            {

                if (value < DateTime.Now)
                {
                    _birthday = value;
                }
                else
                {
                    _birthday = new DateTime();
                    Console.WriteLine("Birthday did not pass validation!");
                }
            }
        }
        /// <summary>
        /// Private field _receiptDate
        /// </summary>
        private DateTime _receiptDate;
        /// <summary>
        /// Public property ReceiptDate
        /// </summary>
        public DateTime ReceiptDate
        {
            get
            {
                return _receiptDate;
            }

            set
            {

                if (value < DateTime.Now)
                {
                    _receiptDate = value;
                }
                else
                {
                    _receiptDate = new DateTime();
                    Console.WriteLine("Receipt date did not pass validation!");
                }
            }
        }
        /// <summary>
        /// Private field _faculty
        /// </summary>
        private string _faculty;
        /// <summary>
        /// Public property Faculty
        /// </summary>
        public string Faculty
        {
            get
            {
                return _faculty;
            }

            set
            {

                if (value.Length > 1)
                {
                    _faculty = value;
                }
                else
                {
                    _faculty = "N/D";
                    Console.WriteLine("Faculty did not pass validation!");
                }
            }
        }
        /// <summary>
        /// Private field _speciality
        /// </summary>
        private string _speciality;
        /// <summary>
        /// Private property Speciality
        /// </summary>
        public string Speciality
        {
            get
            {
                return _speciality;
            }

            set
            {

                if (value.Length > 1)
                {
                    _speciality = value;
                }
                else
                {
                    _speciality = "N/D";
                    Console.WriteLine("Speciality did not pass validation!");
                }
            }
        }
        /// <summary>
        /// Private field _groupIndex
        /// </summary>
        private char _groupIndex;
        /// <summary>
        /// Public property GroupIndex
        /// </summary>
        public char GroupIndex
        {
            get
            {
                return _groupIndex;
            }

            set
            {

                if (Char.IsLetter(value))
                {
                    _groupIndex = value;
                }
                else
                {
                    _groupIndex = '-';
                }
            }
        }
        /// <summary>
        /// Private field _academicPerformance
        /// </summary>
        private float _academicPerformance;
        /// <summary>
        /// Public property AcademicPerformance
        /// </summary>
        public float AcademicPerformance
        {
            get
            {
                return _academicPerformance;
            }

            set
            {

                if (value > -1 && value < 101)
                {
                    _academicPerformance = value;
                }
                else
                {
                    _academicPerformance = 0;
                    Console.WriteLine("Speciality did not pass validation!");
                }
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor with 0 parametrs
        /// </summary>
        public Student() : this("N/D")
        {
        }
        /// <summary>
        /// Constructor with 1 parametrs
        /// </summary>
        /// <param name="name">Name</param>
        public Student(string name) : this(name, "N/D")
        {
        }
        /// <summary>
        /// Constructor with 2 parametrs
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="surname">Surname</param>
        public Student(string name, string surname) : this(name, surname, "N/D")
        {
        }
        /// <summary>
        /// Constructor with 3 parametrs
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="surname">Surname</param>
        /// <param name="patronymic">Patronymic</param>
        public Student(string name, string surname, string patronymic) : this(name, surname, patronymic, "N/D")
        {
        }
        /// <summary>
        /// Constructor with 4 parametrs
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="surname">Surname</param>
        /// <param name="patronymic">Patronymic</param>
        /// <param name="faculty">Faculty</param>
        public Student(string name, string surname, string patronymic, string faculty) : this(name, surname, patronymic, faculty, "N/D")
        {
        }
        /// <summary>
        /// Constructor with 5 parametrs
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="surname">Surname</param>
        /// <param name="patronymic">Patronymic</param>
        /// <param name="faculty">Faculty</param>
        /// <param name="speciality">Speciality</param>
        public Student(string name, string surname, string patronymic, string faculty, string speciality) : this(name, surname, patronymic, faculty, speciality, 0f)
        {
        }
        /// <summary>
        /// Constructor with 6 parametrs
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="surname">Surname</param>
        /// <param name="patronymic">Patronymic</param>
        /// <param name="faculty">Faculty</param>
        /// <param name="speciality">Speciality</param>
        /// <param name="academicPerformance">Academic performance</param>
        public Student(string name, string surname, string patronymic, string faculty, string speciality, float academicPerformance) : this(name, surname, patronymic, faculty, speciality, academicPerformance, '-')
        {
        }
        /// <summary>
        /// Constructor with 7 parametrs
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="surname">Surname</param>
        /// <param name="patronymic">Patronymic</param>
        /// <param name="faculty">Faculty</param>
        /// <param name="speciality">Speciality</param>
        /// <param name="academicPerformance">Academic performance</param>
        /// <param name="groupIndex">Group index</param>
        public Student(string name, string surname, string patronymic, string faculty, string speciality, float academicPerformance, char groupIndex)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Faculty = faculty;
            Speciality = speciality;
            AcademicPerformance = academicPerformance;
            GroupIndex = groupIndex;
            Birthday = new DateTime();
            ReceiptDate = new DateTime();
        }
        /// <summary>
        /// Constructor with 9 parametrs
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="surname">Surname</param>
        /// <param name="patronymic">Patronymic</param>
        /// <param name="faculty">Faculty</param>
        /// <param name="speciality">Speciality</param>
        /// <param name="academicPerformance">Academic performance</param>
        /// <param name="groupIndex">Group index</param>
        /// <param name="birthday">Birthday</param>
        /// <param name="receiptDate">Receipt date</param>
        public Student(string name, string surname, string patronymic, string faculty, string speciality, float academicPerformance, char groupIndex, DateTime birthday, DateTime receiptDate)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Birthday = birthday;
            ReceiptDate = receiptDate;
            Faculty = faculty;
            Speciality = speciality;
            AcademicPerformance = academicPerformance;
            GroupIndex = groupIndex;
        }
        #endregion

        #region Override Methods
        /// <summary>
        /// Override method ToString()
        /// </summary>
        /// <returns>Result string</returns>
        public override string ToString()
        {
            return $"Name: {Name}\nSurname: {Surname}\nPatronymic: {Patronymic}\nBirthday: {Birthday.ToShortDateString()}\nReciep date: {ReceiptDate.ToShortDateString()}\nFaculty: {Faculty}\nSpeciality: {Speciality}\nAcademic performance: {AcademicPerformance}\nGroup index: {GroupIndex}\n";
        }
        #endregion
    }
}
