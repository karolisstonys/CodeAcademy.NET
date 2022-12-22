namespace L05_Tasks_MSSQL.Models.DTO.Delivery
{
    public class DeliveryDataDto
    {
        public string ShippingFromCity { get; set; } = "Vilnius";
        public string ShippingToCity { get; set; }
        public string ShippingFromCoordinates { get; set; } = "25.251531,54.700902";
        public string ShippingToCoordinates { get; set; }
        public double DistanceInKm { get; set; }
        public int PriceInEuros { get; set; }
    }
}
