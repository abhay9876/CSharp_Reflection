/*Dynamic Method Invocation: Define a class MathOperations with multiple public
methods (Add, Subtract, Multiply). Use Reflection to dynamically call any method
based on user input.*/

using System.Reflection;
namespace DynamicMethodInvocation
{
    public class MethodInvocation
    {
        public void Invocation()
        {
            MathOperations math = new MathOperations();
            Type type = typeof(MathOperations);

            Console.Write("Enter method name : ");
            string methodName = Console.ReadLine();

            MethodInfo method = type.GetMethod(methodName);

            if (method != null)
            {
                object result = method.Invoke(math, new object[] { 15, 3 });
                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Method not found");
            }
        }

    }
}