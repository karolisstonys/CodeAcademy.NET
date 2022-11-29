namespace L05_Tasks_MSSQL.Models.DTO
{
    public class GetBookDto
    {
        public int Id { get; set; }

        /// <summary>
        /// Knygos pavadinimas ir autorius atskirtas per tarpa
        /// </summary>
        public string PavadinimasIrAutorius { get; set; }

        /// <summary>
        /// Leidibos metai int 
        /// </summary>
        public int LeidybosMetai { get; set; }
    }
}
