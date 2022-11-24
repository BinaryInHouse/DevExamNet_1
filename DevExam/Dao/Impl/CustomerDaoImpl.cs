
using Microsoft.EntityFrameworkCore;
using DevExam.Model;

namespace DevExam.Dao.Impl
{
    public class CustomerDaoImpl : ICustomerDao
    {
        private readonly ApplicationDbContext _context;

        public CustomerDaoImpl()
        {
        }

        public CustomerDaoImpl(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Customer> GetCustomersThanAccountAmount(double amount)
        {
            var customersThanAccountAmount = (from c in _context.Customers
             from a in _context.Accounts
             where c.Id == a.CustomerId
             where a.Amount < 60
             select c).ToList();
            return customersThanAccountAmount;
        }
    }
}
