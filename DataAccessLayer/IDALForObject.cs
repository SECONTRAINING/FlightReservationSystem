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
        FlightDetails getFlightByDestination (string source,string destination);
        List<string> getAllStations();
        string UpdateFlightDetailsById(int id, FlightDetails flightDetails);

    }
    public interface IDALForFlightSchedule
    {
        List<FlightSchedule> getAllFlightSchedule();
        FlightSchedule getFlightScheduleByScheduleId(int scheduleId);
        FlightSchedule getFlightScheduleByFligthId(int flighthId);
        string addFlightSchedule(FlightSchedule flightSchedule);
        string deleteFlightScheduleByScheduleId(int id);
        string deleteFlightScheduleByFlightId(int id);

    }
}
