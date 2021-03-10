using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace CollectionLinqEx
{
    public class AdvancedExercises
    {
        private EmployeeRepository _employeeRepository;

        public static AdvancedExercises New => new AdvancedExercises();

        private AdvancedExercises()
        {
            _employeeRepository = new EmployeeRepository();
        }

        public void Run()
        {
            
            var employeeOver25 = _employeeRepository.GetEmployeeNameStartsWithAAndOver25();
            var employeesBetween20And35 = _employeeRepository.GetEmployeesWithinInterval(20, 35);
            var employeesBetween30And45 = _employeeRepository.GetEmployeesWithinInterval(30, 45);
            var employeeWithId4 = _employeeRepository.GetEmployeeById(4);
            var employeeWithId7 = _employeeRepository.GetEmployeeById(7);
            var checkIfExists = _employeeRepository.CheckIfExists(8);
            var maleEmployees = _employeeRepository.GetEmployeesByGender( Gender.Male);
            var femaleEmployees = _employeeRepository.GetEmployeesByGender(Gender.Female);
            var maleEmployeesWithin20Tp25ContainsIInName = _employeeRepository.GetEmployeeByCustomParams(20, 25, Gender.Male, 'i');
            // foreach (Employee x in maleEmployeesWithin20Tp25ContainsIInName)
            // {
            //     Console.WriteLine(x.Age);
            // }
            //  Console.WriteLine(checkIfExists);


            // Call here methods from Employee Repository
        }
    }
}