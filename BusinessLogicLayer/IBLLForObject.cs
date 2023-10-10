using DataModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public interface IBLLForAdmin
    {
        List<User> GetAllUsers();

        string InsertUser(User user);

        string DeleteUser(int UserId);

        int ValidateLogin(string UserName, string Password);
    }

    public interface IBLLForFlightDetails
    {
        List<FlightDetails> GetAllFlightDetails();

        string insertFlightDetails(FlightDetails flightDetails);
        string deleteFlightDetailsById(int FlightId);
        FlightDetails GetFlightDetailsById(int FlightId);
    }
}
