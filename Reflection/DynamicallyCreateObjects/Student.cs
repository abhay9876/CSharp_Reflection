namespace DynamicallyCreateObjects
{
    public class Student
    {
        public string Name { get; set; }

        public Student()
        {
            Name = "Zeno";
        }

        public void Display()
        {
            Console.WriteLine($"Student Name: {Name}");
        }
    }

}