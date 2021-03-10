namespace CollectionLinqEx
{
    using System.Collections.Generic;
    using System.Linq;

    public class EmployeeRepository
    {
        private readonly List<Employee> _employees;

        public EmployeeRepository()
        {
            _employees = EmployeeFactory.GetEmployees();
        }

        public List<Employee> GetEmployeeNameStartingWithAOlderThan25()
        {
            return _employees.Where(employee => employee.LastName.StartsWith("A") && employee.Age >= 25).ToList();
        }

        public List<Employee> GetEmployeesWithAgeBetweenInput(int minAge, int maxAge)
        {
            return _employees.Where(employee => employee.Age > minAge && employee.Age < maxAge).ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return _employees.Where(employee => employee.Id == id).Select(employee => employee).First();
        }

        public bool EmployeeWithInputIdExists(int id)
        {
            return _employees.Where(employee => employee.Id == id).Any();
        }

        public List<Employee> GetEmployeesByGender(Gender gender)
        {
            return _employees.Where(employee => employee.Gender == gender).Select(employee => employee).ToList();
        }

        public List<Employee> GetMaleEmployeesWithAge20to25ContainingI()
        {
            return _employees.Where(employee => employee.Age > 20 && employee.Age < 25)
                .Where(employee => employee.Gender == Gender.Male)
                .Where(employee => employee.FirstName.Contains("i"))
                .ToList();
        }



      

    }
}
