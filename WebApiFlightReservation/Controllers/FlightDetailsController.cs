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

    }
}
