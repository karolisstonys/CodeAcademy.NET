namespace L05_Tasks_MSSQL.Services.IServices
{
    public interface IDeliveryService
    {
        Task<string> GetCityLocation(string city);
        Task<double?> GetDistanceForDelivery(string deliveryCoordinates);
    }
}
