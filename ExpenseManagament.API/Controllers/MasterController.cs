using ExpenseManagament.BLL.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseManagament.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        private readonly IMasterService _masterService;

        public MasterController(IMasterService masterService)
        {
            _masterService = masterService;
        }

        [HttpGet]
        [Route("GetPurpose")]
        public IActionResult GetPurpose()
        {
            return Ok(_masterService.GetPurpose());
        }
    }
}
