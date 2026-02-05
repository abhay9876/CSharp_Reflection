using System.Reflection;

namespace DynamicallyCreateObjects
{
    public class CreateObjects
    {
        public void CreateObj()
        {
            Type type = typeof(Student);

            object obj = Activator.CreateInstance(type);
            MethodInfo method = type.GetMethod("Display");

            method.Invoke(obj, null);
        }
    }
}