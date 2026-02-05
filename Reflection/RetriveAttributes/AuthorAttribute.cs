using System;

namespace RetriveAttributes
{


    [AttributeUsage(AttributeTargets.Class)]
    public class AuthorAttribute : Attribute
    {
        public string Name { get; }
        public string Version { get; }

        public AuthorAttribute(string name, string version)
        {
            Name = name;
            Version = version;
        }
    }

}