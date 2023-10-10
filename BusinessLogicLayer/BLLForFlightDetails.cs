using DataAccessLayer;
using DataModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class BLLForFlightDetails:IBLLForFlightDetails
    {
        private IDALForFlightDetails _dALForFlightDetails;
        public BLLForFlightDetails(IDALForFlightDetails dALForFlightDetails)
        {
            _dALForFlightDetails = dALForFlightDetails;
        }

       

        public List<FlightDetails> GetAllFlightDetails()
        {
            try
            {
                return _dALForFlightDetails.GetAllFlightDetails();
            }
          
            catch(Exception ex) 
            {
                throw (ex);
            }
        }

       
        public string insertFlightDetails(FlightDetails flightDetails)
        {
           return _dALForFlightDetails.insertFlightDetails(flightDetails);
        }

        

        public string deleteFlightDetailsById(int FlightId)
        {
            return _dALForFlightDetails.deleteFlightDetails(FlightId);
        }

        public FlightDetails GetFlightDetailsById(int FlightId)
        {
           return _dALForFlightDetails.GetFlightDetailsById(FlightId);
        }
    }
}
