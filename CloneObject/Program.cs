using CloneObject;

Person person1 = new Person("John", 30);

Person person2 = (Person)person1.Clone();

person2.Name = "Alice";
person2.Age = 25;

Console.WriteLine("Person 1: " + person1); // John, 30 years old
Console.WriteLine("Person 2: " + person2); // Alice, 25 years old

Console.ReadLine();