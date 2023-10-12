using DataAccessLayer;
using DataModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class BLLForFlightSchedule: IBLLForFlightSchedule
    {
        public IDALForFlightSchedule _dALForFlightSchedule;
        public BLLForFlightSchedule(IDALForFlightSchedule dALForFlightSchedule) 
        {
            _dALForFlightSchedule=dALForFlightSchedule;
        }

        public string addFlightSchedule(FlightSchedule flightSchedule)
        {
           return _dALForFlightSchedule.addFlightSchedule(flightSchedule);
        }

        public string deleteFlightScheduleByFlightId(int id)
        {
            return _dALForFlightSchedule.deleteFlightScheduleByFlightId(id);
        }

        public string deleteFlightScheduleByScheduleId(int id)
        {
            return _dALForFlightSchedule.deleteFlightScheduleByScheduleId(id);
        }

        public List<FlightSchedule> getAllFlightSchedule()
        {
            return _dALForFlightSchedule.getAllFlightSchedule();
        }

        public FlightSchedule getFlightScheduleByFligthId(int flighthId)
        {
            return _dALForFlightSchedule.getFlightScheduleByFligthId(flighthId);
        }

        public FlightSchedule getFlightScheduleByScheduleId(int scheduleId)
        {
           return _dALForFlightSchedule.getFlightScheduleByScheduleId((int)scheduleId);
        }
    }
}
