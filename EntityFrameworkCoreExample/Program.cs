using EntityFrameworkCoreExample;

using StudentContext dbContext = new();

// Add with EF Core
Student s = new()
{
    FullName = "Vlad B",
    EmailAddress = "vlad432.gmail.com",
    DateOfBirth = new DateTime(1900, 1, 1)
};

Student s2 = new()
{
    FullName = "Tom L",
    EmailAddress = "tom3432.gmail.com",
    DateOfBirth = new DateTime(1990, 1, 10)
};

dbContext.Students.Add(s); // Prepares the Student insert statement
dbContext.SaveChanges(); // Executes pending insert.

dbContext.Students.Add(s2);
dbContext.SaveChanges();

// Retrieve Students from DB

List<Student> allStudents = dbContext.Students.ToList(); // Method syntax
//allStudents = (from stu in dbContext.Students
//              select stu).ToList(); // Query syntax

foreach (Student stu in allStudents)
{
    Console.WriteLine($"{stu.FullName} has an email of {stu.EmailAddress}");
}