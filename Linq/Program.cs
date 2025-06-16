using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();

            //um.MaleStudents();
            //um.FemaleStudents();

            //Console.Write("Enter University ID : ");
            //int uniId = int.Parse(Console.ReadLine());

            //um.SortStudentsByUni(uniId);

            um.StudentAndUniCollection();  
            Console.ReadKey();
        }
    }

    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        public UniversityManager()
        {
            universities = new List<University>()
            {
                new University{Id = 1, Name = "MMSU" },
                new University{Id = 2, Name = "DWCL" }
            };


            students = new List<Student>()
            {
                new Student{Id =1, Name = "Lucky", Gender="Male", Age=20, UniversityId =1},
                new Student{Id =2, Name = "Allysa", Gender="Female", Age=21, UniversityId =1},
                new Student{Id =3, Name = "Alliesum", Gender="Female", Age=22, UniversityId =1},
                new Student{Id =4, Name = "Ysaki", Gender="Male", Age=19, UniversityId =2},
                new Student{Id =1, Name = "Aki", Gender="Male", Age=18, UniversityId =2},

            };
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "Male" select student;

            Console.WriteLine("Male Students : ");
            foreach (Student student in maleStudents)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "Female" select student;

            Console.WriteLine("Female Students : ");
            foreach (Student student in femaleStudents)
            {
                student.Print();
            }
        }

        public void SortStudentsByAge()
        {
            var sortedStudents = from student in students orderby student.Age select student;

            foreach (var student in sortedStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromMMSU()
        {
            IEnumerable<Student> studentMMSU = from student in students
                                               join university in universities on student.UniversityId equals university.Id
                                               where university.Name == "MMSU"
                                               select student;

            Console.WriteLine("Studen From MMSU");
            foreach (Student student in studentMMSU)
            {
                student.Print();
            }

        }

        public void SortStudentsByUni(int num)
        {
            IEnumerable<Student> filteredStudent = from student in students
                                               join university in universities on student.UniversityId equals university.Id
                                               where university.Id == num
                                               select student;

            var selectedUniversity = (from university in universities
                                     where university.Id == num
                                     select university.Name).First();

            Console.WriteLine($"Studen From {selectedUniversity}");
            foreach (Student student in filteredStudent)
            {
                student.Print();
            }

        }

        public void StudentAndUniCollection()
        {
            var newCollection = from student in students
                                join university in universities on student.UniversityId equals university.Id
                                orderby student.UniversityId
                                select new { studentName = student.Name, universityName = university.Name };

            foreach (var col in newCollection)
            {
                Console.WriteLine($"Student : {col.studentName} From {col.universityName}");
            }
        }
    }
    class University
    {
        private int _id;
        private string _name;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;

            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;

            }
        }

        public void Print()
        {
            Console.WriteLine($"University {Name} with id {Id}");
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Gender { get; set; }
        public int Age { get; set; }

        //Foreign key
        public int UniversityId { get; set; }


        public void Print()
        {
            Console.WriteLine($"Student {Name} with Id {Id}, Gender {Gender} and Age {Age} from University with the Id {UniversityId}");
        }
    }
}
