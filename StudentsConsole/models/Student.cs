
namespace StudentsConsole.Models
{
    public class Student
    {

        public List<string> Phones { get; set; }  = new List<string>();
        public string ID { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public GENDER Gender { get; set; } = GENDER.Other;
        public int Age { get; set; } = 0;

        public string Email { get; set; } = string.Empty;

        public string FullName => FirstName; 
        public enum GENDER
        {
            Male = 1,
            Female = 2,
            Other = 3,

        }

        public Student(string ID,string FirstName,string LastName)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Gender = GENDER.Male;
        }

        public Student(string ID, string FirstName, string LastName, GENDER gender)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Gender = gender;
        }


        public Student(string ID, string FirstName, string LastName, GENDER gender, int Age)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Gender = gender;
            this.Age = Age;
        }

        public Student() { }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Gender} {Age}";
        }

    }
}
