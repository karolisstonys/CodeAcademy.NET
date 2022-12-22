using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.ApiModels;
using L05_Tasks_MSSQL.Models.DTO;
using L05_Tasks_MSSQL.Models.DTO.UserDto;
using L05_Tasks_MSSQL.Services.IServices;
using Newtonsoft.Json;

namespace L05_Tasks_MSSQL.Services
{
    public class PointsService : IPointsService
    {
        private const string _api_key = "1e4d275b-151a-4db7-a40b-ea10929129dd";

        private readonly IHttpClientFactory _httpClientFactory;

        public PointsService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public bool WasLastLoginToday(GetUserDto userDto) => userDto.LastLogin.ToShortDateString() == DateTime.Now.ToShortDateString();
        
        public async Task<int> HowManyPointsToAdd()
        {
            int dailyPoints = 50;
            int holidayPoints = 150;

            bool isTodayHoliday = await IsTodayHoliday();
            if (isTodayHoliday) return holidayPoints;

            return dailyPoints;
        }

        private async Task<bool> IsTodayHoliday()
        {
            // Free holidayapi.com accounts are limited to last year's historical data only
            var today = DateTime.Now.AddYears(-1).ToShortDateString().ToString(); // LAST YEAR
            var listOfHolidays = await GetHolidays();

            foreach (var holiday in listOfHolidays.holidays)
            {
                if (holiday.date == today) return true;
            }
            return false;
        }

        public async Task<HolidayApiModel> GetHolidays()
        {
            string year = "2021";
            var httpClient = _httpClientFactory.CreateClient("HolidayApi");
            var endpoint = "v1/holidays" + "?pretty&key=" + _api_key + "&country=LT" + "&year=" + year;
            HolidayApiModel HolidayApiModel = await httpClient.GetFromJsonAsync<HolidayApiModel>(endpoint);
            return HolidayApiModel;
        }
    }
}
