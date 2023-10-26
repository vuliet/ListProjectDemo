namespace CloneObject
{
    public class Person : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public object Clone()
        {
            return new Person(Name, Age);
        }

        public override string ToString()
        {
            return $"{Name}, {Age} years old";
        }
    }
}
