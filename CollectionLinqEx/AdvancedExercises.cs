using System;


namespace CollectionLinqEx { 
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
            _employeeRepository.GetEmployeeNameStartingWithAOlderThan25();
            _employeeRepository.GetEmployeesWithAgeBetweenInput(20, 35);
            _employeeRepository.GetEmployeesWithAgeBetweenInput(30, 45);
            _employeeRepository.GetEmployeeById(4);
            _employeeRepository.GetEmployeeById(7);
            _employeeRepository.EmployeeWithInputIdExists(13);
            _employeeRepository.GetEmployeesByGender(Gender.Male);
            _employeeRepository.GetEmployeesByGender(Gender.Female);
            _employeeRepository.GetMaleEmployeesWithAge20to25ContainingI();

        }
    }
}
