using ExpenseManagament.BLL.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

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
        public IActionResult GetPurposes()
        {
            return Ok(_masterService.GetPurposes());
        }

        [HttpGet]
        [Route("GetCurrency")]
        public IActionResult GetCurrencies()
        {
            return Ok(_masterService.GetCurrencies());
        }

        [HttpGet]
        [Route("GetCategories")]
        public IActionResult GetCategories([BindRequired] int purposeId)
        {
            return Ok(_masterService.GetCategories(purposeId));
        }
    }
}
