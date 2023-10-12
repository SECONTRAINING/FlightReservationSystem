using DataModelLayer;
using NuGet.Packaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public  class DALForUser : IDALForUsers
    {
        public List<FlightDetails> getFlightsByDayAndLocation(string day,string source,string destination)
        {
            DALForFlightDetails s=new DALForFlightDetails();
            DALForFlightSchedule k=new DALForFlightSchedule();
            try
            {
                int [] flightIdbyDestinations=s.getFLightIdbySourcedestination(source,destination);
                int [] flightIdbyDay = k.getFlightIdByScheduleDay(day);
                int[] ok = flightIdbyDestinations.Intersect(flightIdbyDay).ToArray();
                // int[] matchingRecords = array1.Intersect(array2).ToArray();
                if (ok.Length>0)
                {
                    return s.GetFlightDetailsByArrayId(ok);
                }
                else
                {
                    ok[0] = 0;
                    return s.GetFlightDetailsByArrayId(ok);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
