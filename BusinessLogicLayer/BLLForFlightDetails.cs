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
            try
            {


                return _dALForFlightDetails.insertFlightDetails(flightDetails);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        

        public string deleteFlightDetailsById(int FlightId)
        {
            try
            {
                return _dALForFlightDetails.deleteFlightDetails(FlightId);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public FlightDetails GetFlightDetailsById(int FlightId)
        {
            try
            {
                return _dALForFlightDetails.GetFlightDetailsById(FlightId);
            }
            catch(Exception ex)
            {
                throw (ex);
            }
        }

        public FlightDetails getFlightByDestination(string source,string destination)
        {
            try
            {
                return _dALForFlightDetails.getFlightByDestination(source, destination);
            }
            catch(Exception ex)
            {
                throw (ex);
            }
        } 
        public List<string> getAllStations()
        {
            try
            {
                return _dALForFlightDetails.getAllStations();
            }
            catch(Exception ex)
            {
                throw (ex);
            }
        }

        public string UpdateFlightDetailsById(int id, FlightDetails flightDetails)
        {
            try
            {
                return _dALForFlightDetails.UpdateFlightDetailsById(id, flightDetails);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

      

        public int [] getFLightIdbySourcedestination(string source, string destination)
        {
            return _dALForFlightDetails.getFLightIdbySourcedestination(source, destination);
        }

        public List<FlightDetails> GetFlightDetailsByArrayId(int[] FlightId)
        {
            return _dALForFlightDetails.GetFlightDetailsByArrayId(FlightId );
        }
    }
}
