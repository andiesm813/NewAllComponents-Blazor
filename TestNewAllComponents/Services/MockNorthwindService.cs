using NewAllComponents.Models.Northwind;

namespace NewAllComponents.Northwind
{
    public class MockNorthwindService : INorthwindService
    {
        public Task<List<EmployeesType>> GetEmployees()
        {
            return Task.FromResult<List<EmployeesType>>(new());
        }
    }
}
