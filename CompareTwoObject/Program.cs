using CompareTwoObject;

Person person1 = new Person { Name = "John", Age = 30 };
Person person2 = new Person { Name = "Jane", Age = 30 };

List<string> differences = CompareHandler.CompareAndUpdateObjects(person1, person2);

if (differences.Count == 0)
    Console.WriteLine("The objects are identical.");
else
    Console.WriteLine("The objects differ in the following fields: " + string.Join(", ", differences));

Console.ReadLine();