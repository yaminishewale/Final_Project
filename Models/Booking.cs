using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HouseRentalManagementApp.Models
{
    public class Booking
    {
        public int BookingId { get; set; }

        public String Address { get; set; }

        public int Duration { get; set; }

        public int Amount { get; set; }

    }
}
