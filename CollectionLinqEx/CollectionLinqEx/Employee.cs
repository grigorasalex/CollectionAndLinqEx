using System;

namespace CollectionLinqEx

{
    public class Employee 
    {
        public readonly int Id , Age;
        public readonly string FirstName, LastName;
        public readonly CollectionLinqEx.Gender Gender;
       
        public Employee(int index, string firstName, string lastName, int age,  CollectionLinqEx.Gender gender)
        {
            this.Id = index;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Gender = gender;
        }
    
    
    }
}
