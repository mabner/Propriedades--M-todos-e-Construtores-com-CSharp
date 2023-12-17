using ExploringCSharp.Models;

Person p1 = new Person("Marcos", "Leite");

// Using parameter names in order to make the code clearer to read
Person p2 = new Person(name: "Leyd", surname: "Leite");

Course englishCourse = new Course();
englishCourse.Name = "British English for Foreigners";
englishCourse.Students = new List<Person>();

englishCourse.AddStudent(p1);
englishCourse.AddStudent(p2);
englishCourse.ListStudents();

