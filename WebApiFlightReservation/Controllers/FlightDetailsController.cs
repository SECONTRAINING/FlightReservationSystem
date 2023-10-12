using BusinessLogicLayer;
using DataModelLayer;
using Microsoft.AspNetCore.Mvc;

namespace FlightReservationSystem.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightDetailsController : ControllerBase
    {
        private IBLLForFlightDetails _bLLForFlightDetails { get; set; }

        public FlightDetailsController(IBLLForFlightDetails bLLForFlightDetails) 
        {
            _bLLForFlightDetails= bLLForFlightDetails;
        }


        [HttpGet]
        [Route("getAllFlights")]
        public List<FlightDetails> getAllFlights ()
        {
            return _bLLForFlightDetails.GetAllFlightDetails();
        }

        [HttpGet]
        [Route("getFlightByFlightId")]
        
        public FlightDetails getFlightByFlightId(int id) 
        {
            return _bLLForFlightDetails.GetFlightDetailsById(id);
        }
        [HttpDelete]
        [Route("DeleteFlightbyId")]
        public string DeleteFlightbyId(int id)
        {
            return _bLLForFlightDetails.deleteFlightDetailsById(id);
        }
        [HttpPost]
        [Route("insertUpdateFlightDetails")]
        public string insertUpdateFlightDetails(FlightDetails flight) 
        { 
            return _bLLForFlightDetails.insertFlightDetails(flight);
        }
        [HttpGet]
        [Route("getflightbyDestinations")]
        public FlightDetails getFlightByDestination(string source,string destination)
        {
            return _bLLForFlightDetails.getFlightByDestination(source,destination);
        }

        [HttpGet]
        [Route("getAllStations")]
        public List<string> getAllStations()
        {
            return _bLLForFlightDetails.getAllStations();
        }

        [HttpPost]
        [Route("UpdateFlightDetailsById")]
        public string UpdateFlightDetailsById(int id,FlightDetails flight)
        {
            return _bLLForFlightDetails.UpdateFlightDetailsById(id,flight);
        }

        
    }
}
