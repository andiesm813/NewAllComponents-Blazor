using NewAllComponents.Models.Financial;

namespace NewAllComponents.Financial
{
    public interface IFinancialService
    {
        Task<List<BoxOfficeRevenueType>> GetBoxOfficeRevenue();
    }
}
