using L05_Tasks_MSSQL.Models.DTO.DeliveryDto;

namespace L05_Tasks_MSSQL.Services.IServices
{
    public interface IDeliveryService
    {
        DeliveryInfoDto BuildDeliveryInfo(string city, string deliveryCoordinates, double? distanceInKm, int? deliveryPrice);
        int? CalculateDeliveryPrice(double? distance);
        Task<string> GetCityLocation(string city);
        Task<double?> GetDistanceForDelivery(string deliveryCoordinates);
    }
}
