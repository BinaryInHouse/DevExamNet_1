using DevExam.Model;

namespace DevExam.Dao.Impl
{
    public class AccountDaoImpl : IAccountDao
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public AccountDaoImpl(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public ApplicationDbContext ApplicationDbContext => _applicationDbContext;
    }
}
