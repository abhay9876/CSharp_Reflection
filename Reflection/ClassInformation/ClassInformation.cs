using System;
using System.Reflection;

namespace ClassInformation
{
    public class ClassInfo
    {
        public void Display()
        {


            Calculation c = new Calculation(5, 6);
            Type type = c.GetType();


            Console.WriteLine($"Class Name : {type.Name}");

            Console.WriteLine($"All Public fields");
            foreach (MemberInfo info in type.GetFields())
            {
                Console.WriteLine(info.Name);
            }

            Console.WriteLine($"All Public Methods");
            foreach (MemberInfo info in type.GetMethods())
            {
                Console.WriteLine(info.Name);
            }

            Console.WriteLine($"All Public Declaring Methods");
            foreach (MethodInfo method in type.GetMethods())
            {
                if (method.DeclaringType == type)
                {
                    Console.WriteLine(method.Name);
                }
            }

        }
    }
}