namespace L06_Api_Logging.Models.Dto
{
    public class GetLoggingResult
    {
        public GetLoggingResult(string message)
        {
            Message = message;
        }

        /// <summary>
        /// Issaugo kazkokia zinute.
        /// </summary>
        public string Message { get; set; }

    }
}
