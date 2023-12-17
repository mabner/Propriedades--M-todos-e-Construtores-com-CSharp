using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringCSharp.Models
{
    public class Course
    {
        public string Name { get; set; }
        public List<Person> Students { get; set; }

        public void AddStudent(Person student)
        {
            Students.Add(student);
        }

        public int GetEnrolledStudentCount()
        {
            int quantity = Students.Count;
            return quantity;
        }

        public bool RemoveStudent(Person student)
        {
            return Students.Remove(student);
        }

        public void ListStudents()
        {
            foreach (Person student in Students)
            {
                Console.WriteLine(student.FullName);
            }
        }
    }
}