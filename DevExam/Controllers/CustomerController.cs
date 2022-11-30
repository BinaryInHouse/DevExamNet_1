using DevExam.Service;
using Microsoft.AspNetCore.Mvc;

namespace DevExam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _context;

        public CustomerController(ICustomerService context) {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<string>> GetPersonalData([FromRoute]double amount) {
            var customerPersonalData = _context.GetCustomerPersonalDataList(amount);
            return customerPersonalData.Count.Equals(0) ? NotFound()  : Ok(_context.GetCustomerPersonalDataList(amount));
        }
    }
}
