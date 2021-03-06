namespace Booking.Models.Booking
{
    public class PageViewModel
    {
        public int PageNumber { get;  set; }
        public int TotalPages { get;  set; }

        public bool HasPreviousPage { get; set; }

        public bool HasNextPage { get; set; }
    }
}