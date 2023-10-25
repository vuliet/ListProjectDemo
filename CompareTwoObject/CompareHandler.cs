using System.Reflection;

namespace CompareTwoObject
{
    public static class CompareHandler
    {
        public static List<string> CompareObjects<T>(T obj1, T obj2)
        {
            List<string> differences = new List<string>();

            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                object value1 = property.GetValue(obj1);
                object value2 = property.GetValue(obj2);

                if (!Equals(value1, value2))
                    differences.Add(property.Name);
            }

            return differences;
        }
    }
}
