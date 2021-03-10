namespace CollectionLinqEx
{
    using System.Collections.Generic;

    public static class EmployeeFactory
    {
        public static List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee(1, "Maximus", "Prince", 24, Gender.Male),
                new Employee(2, "Precious", "Ewing", 39, Gender.Female),
                new Employee(3, "Pablo", "Wilson", 18, Gender.Male),
                new Employee(4, "Mackenzie", "Pineda", 49, Gender.Male),
                new Employee(5, "Maxwell", "Maldonado", 33, Gender.Female),
                new Employee(6, "Amalie", "Kenny", 27, Gender.Female),
                new Employee(7, "Lleyton", "Clarkson", 45, Gender.Male),
                new Employee(8, "Tasmin", "Travis", 55, Gender.Male),
                new Employee(9, "Crystal ", "Nixon", 43, Gender.Female),
                new Employee(10, "IJudith ", "Hughes", 23, Gender.Male),
                new Employee(11, "Jean ", "Hayward", 41, Gender.Male),
                new Employee(12, "Rogan ", "Mcclure", 21, Gender.Female)
            };
        }
    }
}
