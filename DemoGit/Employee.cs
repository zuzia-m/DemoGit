namespace DemoGit
{
    public class Employee
    {
        public string Name { get; set; }

        public Employee(string name)
        {
            Name = name;
        }

        public void WriteLineName()
        {
            Console.WriteLine($"Name is: {Name}");
        }
    }
}
