using DataModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALForFlightDetails : IDALForFlightDetails
    {
        public FlightDbContext dbcontext;
        public DALForFlightDetails()
        {
            dbcontext = new FlightDbContext();
        }



        public List<FlightDetails> GetAllFlightDetails()
        {
            return dbcontext.FlightDetails.ToList();
        }

        public string insertFlightDetails(FlightDetails flightDetails)
        {
            try
            {
                var result = dbcontext.FlightDetails.Where(x => x.FlightId == flightDetails.FlightId).FirstOrDefault();
                if (result != null)
                {
                    result.FlightName = flightDetails.FlightName;
                    result.EstimatedTraveDuration = flightDetails.EstimatedTraveDuration;
                    result.Destination = flightDetails.Destination;
                    result.ReservationCapacity = flightDetails.ReservationCapacity;
                    result.ReservationType = flightDetails.ReservationType;
                    result.SeatingCapacity = flightDetails.SeatingCapacity;
                    dbcontext.SaveChanges();
                    return "flightDetials have Been Updated Successfully";


                }
                else
                {
                    dbcontext.FlightDetails.Add(flightDetails);
                    dbcontext.SaveChanges();
                    return "Flight has been Added";
                }
            }
            catch (Exception ex)

            {
                throw ex;
            }
        }

        public string deleteFlightDetails(int FlightId)
        {
            try
            {
                var result = dbcontext.FlightDetails.Where(x => x.FlightId == FlightId).FirstOrDefault();
                if (result != null)
                {
                    dbcontext.FlightDetails.Remove(result);
                    return "Flight has been Removed";
                }
                else
                {
                    return "flight has not Found";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public FlightDetails GetFlightDetailsById(int FlightId)
        {
            try
            {
                var result = dbcontext.FlightDetails.Where(x => x.FlightId == FlightId).FirstOrDefault();
                if (result != null)
                {
                    return result;
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
