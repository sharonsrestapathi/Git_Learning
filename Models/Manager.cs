namespace OOPS_CONCEPT.Models
{
    public class Manager : Employee, IWork
    {
        public Manager(string name, int age, double salary)
            : base(name, age, salary) 
        { }

        public void DoWork()
        {
            Console.WriteLine($"{Name} is managing the team.");
        }
    }
}