/*Invoke Private Method: Define a class Calculator with a private method Multiply(int
a, int b). Use Reflection to invoke this method and display the result.*/

using System.Reflection;
namespace InvokePrivateMethods
{
    public class InvokePrivateMethod
    {
        public void InvokeMethod()
        {
            Calculator calc = new Calculator();
            Type type = typeof(Calculator);

            MethodInfo method = type.GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);

            object result = method.Invoke(calc, new object[] { 5, 3 });
            Console.WriteLine(" Result : " + result);
        }
    }
}