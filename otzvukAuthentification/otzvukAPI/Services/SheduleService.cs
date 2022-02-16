using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using OtzvukAPI.Models;

namespace OtzvukAPI.Services
{
    public class SheduleService : ISheduleService
    {
        private readonly ApplicationDbContext _db;
        public SheduleService(ApplicationDbContext db)
        {
            this._db = db;
        }
        public async Task<List<SheduleModel>> GetShedulesAsync()
        {
            var shedules = await (from shedule in _db.Shedules
                                  select new SheduleModel()
                                  {
                                      Id = shedule.Id,
                                      Name = shedule.Name,
                                      Description = shedule.Description
                                  }).ToListAsync();
            return shedules;
        }
    }
}
