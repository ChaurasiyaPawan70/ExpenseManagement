using ExpenseManagament.DAL.DTO;
namespace ExpenseManagament.BLL.Interface
{
    public interface IMasterService
    {
        IEnumerable<PurposeMasterDTO> GetPurposes();
        IEnumerable<CurrencyMasterDTO> GetCurrencies();
        IEnumerable<CategoryMasterDTO> GetCategories(int purposeId);

    }
}
