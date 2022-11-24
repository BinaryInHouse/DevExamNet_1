using DevExam.Dao;

namespace DevExam.Service.Impl
{
    public class CustomerServiceImpl : ICustomerService
    {
        private readonly ICustomerDao _customerDao;
        public CustomerServiceImpl(ICustomerDao customerDao) 
        {
            _customerDao = customerDao;
        }

        List<string> ICustomerService.GetCustomerPersonalDataList(double amount)
        {
            return _customerDao.GetCustomersThanAccountAmount(amount).Select(c => c.Name + " " + c.Lastname).ToList();
        }
    }
}
