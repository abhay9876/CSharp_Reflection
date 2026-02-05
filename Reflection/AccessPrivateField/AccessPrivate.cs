/*Access Private Field: Create a class Person with a private field age. Use Reflection to
modify and retrieve its value.*/


using System.Reflection;
namespace AccessPrivateField
{
    public class AccessPrivate
    {
        public void Access()
        {
            Person person = new Person();
            Type type = typeof(Person);

            FieldInfo field = type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);

            field.SetValue(person, 23);
            Console.WriteLine("Updated Age : " + field.GetValue(person));
        }
    }
}