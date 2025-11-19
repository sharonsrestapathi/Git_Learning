using OOPS_CONCEPT.Models;

class Program
{
    static void Main()
    {
        Person p = new Person("John", 30);
        p.DisplayInfo();

        Employee e = new Employee("Alice", 28, 45000);
        e.DisplayInfo();

        Manager m = new Manager("Bob", 40, 90000);
        m.DisplayInfo();
        m.DoWork();
    }
}
