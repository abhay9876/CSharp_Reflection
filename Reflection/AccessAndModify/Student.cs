
using System;

namespace AccessAndModify
{

    public class Student
    {
        private static string collegeName = "GLA University";

        public static void ShowCollege()
        {
            Console.WriteLine("College Name : " + collegeName);
        }
    }

}