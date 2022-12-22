using L05_Tasks_MSSQL.Services.IServices;

namespace L05_Tasks_MSSQL.Services
{
    public class PaymentService : IPaymentService
    {
        public double CalculatePointsUsedInPayment(long points)
        {
            var onePointIsWorth = 0.01;
            return points * onePointIsWorth;
        }
    }
}
