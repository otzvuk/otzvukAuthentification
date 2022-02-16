using Microsoft.AspNetCore.Mvc;
using OtzvukAPI.Services;

namespace OtzvukAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SheduleController : ControllerBase
    {
        private readonly ISheduleService _sheduleService;

        public SheduleController(ISheduleService sheduleService)
        {
            this._sheduleService = sheduleService;
        }
        [HttpGet]
        public async Task<IActionResult> GetShedulesAsync()
        {
            var shedules = await _sheduleService.GetShedulesAsync();
            return Ok(shedules);
        }
    }
}
