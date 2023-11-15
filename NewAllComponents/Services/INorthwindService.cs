using NewAllComponents.Models.Northwind;

namespace NewAllComponents.Northwind
{
    public interface INorthwindService
    {
        Task<List<EmployeesType>> GetEmployees();
    }
}
