using ExploringCSharp.Models;

Person p1 = new Person();
p1.Name = "Marcos";
p1.Surname = "Leite";

Person p2 = new Person();
p2.Name = "Leyd";
p2.Surname = "Leite";

Course englishCourse = new Course();
englishCourse.Name = "British English for Foreigners";
englishCourse.Students = new List<Person>();

englishCourse.AddStudent(p1);
englishCourse.AddStudent(p2);
englishCourse.ListStudents();

