using DevExam.Service;
using Microsoft.AspNetCore.Mvc;

namespace DevExam.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _context;

        public CustomerController(ICustomerService context) {
            _context = context;
        }

        public ActionResult<List<string>> GetPersonalData(double amount) {
            var customerPersonalData = _context.GetCustomerPersonalDataList(amount);
            return customerPersonalData == null ? NotFound()  : Ok(_context.GetCustomerPersonalDataList(amount));
        }
    }
}
