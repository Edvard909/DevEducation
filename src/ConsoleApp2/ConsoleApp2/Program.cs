namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[2];
            Employee employee1 = new Employee()
            {
                Name = "EDG",
                Age = 21,
                Specialty = "3D",
            };

            Employee employee2 = new Employee()
            {
                Name = "Afet",
                Age = 20,
                Specialty = "Sculpturing",
            };
            Console.WriteLine(employee1.Name + $" {employee1.Age} years old" + $" {employee1.Specialty} Artist");
            Console.ReadKey();
        }
    }
    public class Employee 
    { 
        public string Name { get; set; }
        public int Age;
        public string Specialty { get; set; }
    }
}