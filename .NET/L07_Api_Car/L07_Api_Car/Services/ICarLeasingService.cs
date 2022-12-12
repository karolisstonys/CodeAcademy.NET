namespace L07_Api_Car.Services
{
    public interface ICarLeasingService
    {
        decimal AddPrive(double price, double percent);
        bool CanLease(int carId);
        void ChangeYear(int carId, int year);
    }
}