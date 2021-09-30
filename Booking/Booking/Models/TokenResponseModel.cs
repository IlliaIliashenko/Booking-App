namespace Booking.Models
{
    public class TokenResponseModel
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string UserName { get; set; }
    }
}