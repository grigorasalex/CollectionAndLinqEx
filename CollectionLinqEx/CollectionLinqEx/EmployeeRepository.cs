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
    }
}
