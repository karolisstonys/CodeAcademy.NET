namespace L04_EF_Applying_To_API.Models.DTO
{
    public class CreateDishDto
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string SpiceLevel { get; set; }
        public string Country { get; set; }
        public string ImagePath { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}