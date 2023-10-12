using BusinessLogicLayer;
using DataModelLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiFlightReservation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IBLLForUsers _bLLForUsers;
        public UserController(IBLLForUsers bLLForUsers) 
        {
            _bLLForUsers = bLLForUsers;
        }


        [HttpGet]
        [Route("getFlightsByDayAndLocation")]
        public List<FlightDetails> getFlightsByDayAndLocation(string day, string source,string destination)
        {
            return _bLLForUsers.getFlightsByDayAndLocation(day, source, destination);
        }

       


    }

    
}
