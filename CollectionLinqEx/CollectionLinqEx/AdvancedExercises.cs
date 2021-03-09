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
        }
    }
}
