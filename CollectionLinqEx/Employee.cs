namespace CollectionLinqEx
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public Gender Gender { get; set; }

        public Employee (int id, string firstName, string lastName, int age, Gender gender)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;

        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }


    }

    public enum Gender
    {
        Male = 1,
        Female
    }
}
