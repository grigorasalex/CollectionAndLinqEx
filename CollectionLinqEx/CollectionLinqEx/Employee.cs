namespace CollectionLinqEx
{

    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }


        public Gender _gender;
        public Employee(int id, string firstname, string lastname, int age, Gender gender)
        {
            id = Id;
            firstname = FirstName;
            lastname = LastName;
            age = Age;
            _gender = gender;


        }
    }

    public enum Gender
    {
        Male,
        Female
    };
}
