namespace Booking.BLL.Services.Authentication.Interfaces
{
    public interface ITokenDecoder
    {
        string DecodeTokenClaim(string refreshToken);
    }
}