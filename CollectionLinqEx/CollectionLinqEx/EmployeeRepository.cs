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
        public void Test1()
        {
            var firstEmployeeWithA = _employees.Where(employee => employee.FirstName.StartsWith("A") && employee.Age >= 25);
        
        }
        public void Test2()
        {
            var vicenerians = _employees.Where(employee => employee.Age >= 25 && employee.Age <= 35);

        }

        public void Test3()
        {
            var quadragenarian = _employees.Where(employee => employee.Age >= 30 && employee.Age <= 45);
        }
        public void Test4()
        {
            var employeeNr4 = _employees.Where(employe => employe.Id == 4);
        }
        public void Test5()
        {
            var employeeNr7 = _employees.Where(employe => employe.Id == 7);
        }
        public void Test6()
        {
            var employeeExistence = _employees.Where(employe => employe.Id == 8 ? true : false);

        }
        public void Test7()
        {
          
            var females = _employees.Where(employee => employee._gender==Gender.Female);
        }
        public void Test8()
        {
            var males = _employees.Where(employee => employee._gender == Gender.Male);
        }
        public void Test9()
        {
            var viceneriansMales = _employees.Where(employee => employee._gender == Gender.Male && employee.FirstName.ToLower().Contains("i "));
            
        }
    
    }
}

