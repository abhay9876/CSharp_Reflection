/*Retrieve Attributes at Runtime: Create a custom attribute [Author("Author Name")].
Apply it to a class and use Reflection to retrieve and display the attribute value at
runtime.*/

using System;
using System.Reflection;

namespace RetriveAttributes
{
    public class RetriveAttribute
    {
        public void AuthorInfo()
        {
            Type type = typeof(ReportService);

            AuthorAttribute author =
                (AuthorAttribute)Attribute.GetCustomAttribute(type, typeof(AuthorAttribute));

            if (author != null)
            {
                Console.WriteLine("Author Name : " + author.Name);
                Console.WriteLine("Version  : " + author.Version);
            }


        }
    }
}