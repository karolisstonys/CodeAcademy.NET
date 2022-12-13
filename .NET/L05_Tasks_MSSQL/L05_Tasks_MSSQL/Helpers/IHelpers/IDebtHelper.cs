using L05_Tasks_MSSQL.Models.DTO.DebtDto;

namespace L05_Tasks_MSSQL.Helpers.IHelpers
{
    public interface IDebtHelper
    {
        List<UserDebtDto> UpdateAndGetAllDebtForEveryone();
    }
}
