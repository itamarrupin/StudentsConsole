namespace StudentsConsole
{
    using Models;
    using StudentsConsole.extensions;
    using System.Security.Cryptography.X509Certificates;

    internal class Program
    {
        

        static void Main(string[] args)
        {


            DateTime endOfThiDay = DateTime.Now.EndOfDay();
            DateTime startOfThiDay = DateTime.Now.StartOfDay();

            List<int> numbers = new List<int> { 1, 2, 3, 45 };
            List<string> names = new List<string> { "itamar", "omri", "natali" };
            List<Student> students = new List<Student>()
            {
                new Student() { ID="1", FirstName ="Itamar", LastName = "Lachman" , Age = 53 , Gender= Student.GENDER.Male  },
                new Student() { ID="2", FirstName ="Yonatan", LastName = "Bodovosky", Age = 24, Gender = Student.GENDER.Male }
            };
            students.Add(new Student("3", "Foda", "Halabi", Student.GENDER.Female, 22));

            Student? find = students.Find(std => std.Gender == Student.GENDER.Male && 
                                                 std.Age.Between(20, 50));

                        foreach (Student student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("press any key");
            Console.ReadKey(true);
        }

          
     

    }

}
