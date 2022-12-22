using L05_Tasks_MSSQL.Data;
using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Repository.IRepository;

namespace L05_Tasks_MSSQL.Repository
{
    public class PaymentRepository : Repository<Payment>, IPaymentRepository
    {
        private readonly BookStoreContext _db;

        public PaymentRepository(BookStoreContext db) : base(db)
        {
            _db = db;
        }
    }
}
