using BusinessLogicLayer;
using DataModelLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiFlightReservation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightSchedule : ControllerBase
    {
        public IBLLForFlightSchedule _bLLForFlightSchedule { get; set; }

        public FlightSchedule (IBLLForFlightSchedule bLLForFlightSchedule)
        {
            _bLLForFlightSchedule=bLLForFlightSchedule;
        }

        [HttpGet]
        [Route("getAllFlightSchedules")]
        public List<DataModelLayer.FlightSchedule> getAllFlightSchedule ()
        {
            return _bLLForFlightSchedule.getAllFlightSchedule();
        }

        [HttpPost]
        [Route("getAllFlightScheduleById")]
        public DataModelLayer.FlightSchedule getFlightScheduleByScheduleId(int id)
        {
            return _bLLForFlightSchedule.getFlightScheduleByScheduleId(id);
        }

        [HttpPost]
        [Route("getFlightScheduleByFligthId")]
        public DataModelLayer.FlightSchedule getFlightScheduleByFligthId(int id)
        {
            return _bLLForFlightSchedule.getFlightScheduleByFligthId(id);
        }

        [HttpPost]
        [Route("addFlightSchedule")]
        public string addFlightSchedule(DataModelLayer.FlightSchedule flightSchedule)
        {
            return _bLLForFlightSchedule.addFlightSchedule(flightSchedule);
        }

        [HttpPost]
        [Route("deleteFlightScheduleByScheduleId")]
        public string deleteFlightScheduleByScheduleId(int id)
        {
            return _bLLForFlightSchedule.deleteFlightScheduleByScheduleId(id);
        }

        [HttpPost]
        [Route("deleteFlightScheduleByFlightId")]
        public string deleteFlightScheduleByFlightId(int id)
        {
            return _bLLForFlightSchedule.deleteFlightScheduleByScheduleId(id);
        }
    }
}
