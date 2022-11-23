using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace L04_EF_Applying_To_API.Models
{
    public class Dish
    {
        public Dish() { }

        public Dish(int dishId, string name, string type, string spiceLevel, string country, string imagePath, DateTime createdDateTime)
        {
            DishId=dishId;
            Name=name;
            Type=type;
            SpiceLevel=spiceLevel;
            Country=country;
            ImagePath=imagePath;
            CreatedDateTime=createdDateTime;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DishId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Type { get; set; }
        public string SpiceLevel { get; set; }
        public string Country { get; set; }
        public string ImagePath { get; set; }
        public DateTime  CreatedDateTime { get; set; }
        public List<RecipeItem> RecipeItems { get; set; }
    }
}
