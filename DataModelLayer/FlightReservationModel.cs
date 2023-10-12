using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataModelLayer
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string MobileNo { get; set; }
        public int LoginStatus { get; set; }
        public string UserType { get; set; }

    }
    public class UserWallet
    {
        [Key]
        public int UserWalletId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public string CreditCardNo { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public double Balance { get; set; }

        public double CurrentBalance { get; set; }

        public virtual User User { get; set; }


    }
    public class UserWalletTransaction
    {
        [Key]
        public int UserWalletTransactionId { get; set; }
        [ForeignKey("UserWallet")]
        public int UserWalletId { get; set; }
        public string Action { get; set; }
        public double Amount { get; set; }

        public virtual UserWallet UserWallet { get; set; }


    }

    public class FlightDetails
    {


        [Key]
        public int FlightId { get; set; }
        public string FlightName { get; set; }
        public string source { get; set; }
        public string Destination { get; set; }
        public string EstimatedTraveDuration { get; set; }
        public int SeatingCapacity { get; set; }
        public string ReservationType { get; set; }
        public int ReservationCapacity { get; set; }
    }

    public class FlightSchedule
    {
        [Key]
        public int FlightScheduleId { get; set; }

        public string AvailableDays { get; set; }
        [ForeignKey("FlightDetails")]
        public int FlightId { get; set; }

        public virtual FlightDetails FlightDetails { get; set; }
    }
    public class FlightSeat
    {
        [Key]
        public int FlightSeatId { get; set; }

        public int AvailableSeats { get; set; }
        [ForeignKey("FlightDetails")]
        public int FlightId { get; set; }

        public virtual FlightDetails FlightDetails { get; set; }
    }

    public class UserFlight
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("FlightDetails")]
        public int FlightId { get; set; }
        public DateTime DateOfJourney { get; set; }
        public int NoOfSeats { get; set; }

        public virtual User User { get; set; }
        public virtual FlightDetails FlightDetails { get; set; }

    }
}