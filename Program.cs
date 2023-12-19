using System.Globalization;
using ExploringCSharp.Models;

//Person p1 = new Person("Marcos", "Leite");

// Using parameter names in order to make the code clearer to read
Person p2 = new Person(name: "Leyd", surname: "Leite");

// Course englishCourse = new Course();
// englishCourse.Name = "British English for Foreigners";
// englishCourse.Students = new List<Person>();

// englishCourse.AddStudent(p1);
// englishCourse.AddStudent(p2);
// englishCourse.ListStudents();

// Currency format
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal exchangeRate = 6.40M;
// Console.WriteLine($"{exchangeRate:C}");
// Console.WriteLine(exchangeRate.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));

// double successRate = .9682;
// System.Console.WriteLine(successRate.ToString("P"));

// int agencyCode = 153694;
// System.Console.WriteLine(agencyCode.ToString("##-##-##"));

//DateTime enrolmentDate = DateTime.Now;

//System.Console.WriteLine(enrolmentDate.ToString(@"dddd, dd \de MMMM \de yyyy"));

// Date with TryParse
string dateString = DateTime.Now.ToShortDateString();

bool correctDate = DateTime.TryParseExact(
    dateString,
    "yyyy-MM-dd",
    CultureInfo.InvariantCulture,
    DateTimeStyles.None,
    out DateTime date
);

if (correctDate)
{
    System.Console.WriteLine($"System date: {date.ToShortDateString()}.");
}
else
{
    System.Console.WriteLine("Please review your region datetime format.");
}

try
{
    string[] configLines = File.ReadAllLines("files/dateConfig.txt");

    foreach (string line in configLines)
    {
        System.Console.WriteLine(line);
    }
}
catch (FileNotFoundException ex)
{
    System.Console.WriteLine($"Please verify the filename. {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
    System.Console.WriteLine($"Please verify the folder name and file path. {ex.Message}");
}
catch (Exception ex)
{
    System.Console.WriteLine(ex);
}
finally
{
    // E.g. use to close a database connection irrespective of success in the try code block
    System.Console.WriteLine("Debugging in progress...");
}
