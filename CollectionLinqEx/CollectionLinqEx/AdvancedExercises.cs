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
            // Call here methods from Employee Repository
            _employeeRepository.Test1();
            _employeeRepository.Test2();
            _employeeRepository.Test3();
            _employeeRepository.Test4();
            _employeeRepository.Test5();
            _employeeRepository.Test6();
            _employeeRepository.Test7();
            _employeeRepository.Test8();
            _employeeRepository.Test9();
        }
    }
}
