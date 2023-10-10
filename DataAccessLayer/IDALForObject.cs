using DataModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IDALForAdmin
    {

        List<User> GetAllUsers();
        string InsertUser(User user);

        string DeleteUser(int UserId);

        int ValidateLogin(string UserName, string Password);


    }

    public interface IDALForFlightDetails
    {

        List<FlightDetails> GetAllFlightDetails();

        string insertFlightDetails (FlightDetails flightDetails);
        string deleteFlightDetails(int FlightId);
        FlightDetails GetFlightDetailsById(int FlightId);


    }
}
