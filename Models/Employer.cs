namespace OOPS_CONCEPT.Models
{
    public class Employee : Person
    {
        private double Salary;  // encapsulation: private field

        public Employee(string name, int age, double salary)
            : base(name, age)
        {
            Salary = salary;
        }

        public double GetSalary() => Salary;
        public void SetSalary(double salary) => Salary = salary;

        public override void DisplayInfo()
        {
            Console.WriteLine($"Employee: {Name}, Age: {Age}, Salary: {Salary}");
        }
    }
}