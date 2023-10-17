using CompareContains;

var students = new List<Student>
{
    new Student { Id = 1, Name = "Thai" },
    new Student { Id = 2, Name = "Heo" }
};

var student = new Student { Id = 2, Name = "Heo" };

var isContains = students.Contains(student);

Console.WriteLine($"List student contains student : {isContains}");
Console.ReadLine();