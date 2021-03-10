using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace CollectionLinqEx
{
    using System.Collections.Generic;

    public class EmployeeRepository
    {
        private readonly List<Employee> _employees;

        public EmployeeRepository()
        {
            _employees = EmployeeFactory.GetEmployees();
        }

        public Employee GetEmployeeNameStartsWithAAndOver25()
        {
            
            return _employees.FirstOrDefault(x => x.Age >25 && x.FirstName.Substring(0,1).Contains('A'));
        }

        public List<Employee> GetEmployeesWithinInterval(int minAge, int maxAge)
        {
            return _employees.Where(x => x.Age >= minAge && x.Age <= maxAge).ToList();
        }

        public Employee GetEmployeeById(int id )
        {
            return _employees.FirstOrDefault(x => x.Id == id);
        }

        public bool CheckIfExists(int id)
        {
            return _employees.Any(x => x.Id == id);
        }

        public List<Employee> GetEmployeesByGender(CollectionLinqEx.Gender gender)
        {
            return _employees.Where(x => x.Gender == gender).ToList();
        }

        public List<Employee> GetEmployeeByCustomParams(int minAge, int maxAge, Gender gender, char letter)
        {
           return _employees.Where(x => x.Gender == gender && x.Age >= minAge && x.Age <= maxAge && x.FirstName.Contains(letter)).ToList();

        }
    }
}
