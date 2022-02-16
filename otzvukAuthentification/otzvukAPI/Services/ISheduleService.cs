using OtzvukAPI.Models;

namespace OtzvukAPI.Services
{
    public interface ISheduleService
    {
         Task<List<SheduleModel>> GetShedulesAsync();
    }
}
