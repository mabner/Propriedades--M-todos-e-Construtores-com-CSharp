using System.Globalization;
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

// Currency format
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal exchangeRate = 6.40M;
Console.WriteLine($"{exchangeRate:C}");
Console.WriteLine(exchangeRate.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));

double successRate = .9682;
System.Console.WriteLine(successRate.ToString("P"));

int agencyCode = 153694;
System.Console.WriteLine(agencyCode.ToString("##-##-##"));

DateTime enrolmentDate = DateTime.Now;

System.Console.WriteLine(enrolmentDate.ToString(@"dddd, dd \de MMMM \de yyyy"));

