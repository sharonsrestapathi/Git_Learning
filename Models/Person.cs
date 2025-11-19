namespace OOPS_CONCEPT.Models
{
    public class Sharon
    {
        public int DOB { get; set; }
        public int Age { get; set; }

        public Sharon(int dob, int age)
        {
            DOB = dob;
            Age = age;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"DOB: {Name}, Age: {Age}");
        }
    }
}