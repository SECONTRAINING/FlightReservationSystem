using DataModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public  class DALForFlightSchedule: IDALForFlightSchedule
    {
        public FlightDbContext dbcontext;
        public DALForFlightSchedule()
        {
            dbcontext = new FlightDbContext();
        }
       public List<FlightSchedule> getAllFlightSchedule()
        {
            try
            {
                return  dbcontext.FlightSchedule.ToList();
                
            }
            catch (Exception ex)
            {
                throw (ex);
            }
          
        }

        public FlightSchedule getFlightScheduleByScheduleId(int scheduleId)
        {
            try
            {
                var result = dbcontext.FlightSchedule.Where(x => x.FlightScheduleId == scheduleId).FirstOrDefault();
                if (result != null)
                {
                    return result;
                }
                else
                {
                    return result;
                }
            }
            catch(Exception ex)
            {
                throw (ex);
            }
        }

        public FlightSchedule getFlightScheduleByFligthId(int flighthId)
        {
            try
            {
                var result = dbcontext.FlightSchedule.Where(x => x.FlightId == flighthId).FirstOrDefault();
                if (result != null)
                {
                    return result;
                }
                else
                {
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public string addFlightSchedule(FlightSchedule flightSchedule)
        {
            try
            {
                var result=dbcontext.FlightSchedule.Where(x=>x.FlightScheduleId==flightSchedule.FlightScheduleId).FirstOrDefault();
                if (result!=null)
                {
                    result.AvailableDays = flightSchedule.AvailableDays;
                    result.FlightId = flightSchedule.FlightId;
                    dbcontext.SaveChanges();
                    return "successfully flight Data Has Been Updated";
                }
                else
                {
                    dbcontext.FlightSchedule.Add(flightSchedule);
                    dbcontext.SaveChanges();
                    return "Successfully the schedule for the flight has been added";
                }

            }
            catch(Exception ex)
            {
                throw(ex);
            }
        }

        public string deleteFlightScheduleByScheduleId (int id)
        {
            try
            {
                var result = dbcontext.FlightSchedule.Where(x => x.FlightScheduleId == id).FirstOrDefault();
                if(result !=null)
                {
                    dbcontext.FlightSchedule.Remove(result);
                    dbcontext.SaveChanges();
                    return "successfully schedule for this flight is Deleted";
                }
                else
                {
                    return "Schedule has not been Remove see DataBase";
                }

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public string deleteFlightScheduleByFlightId(int  id)
        {
            try
            {
                var result = dbcontext.FlightSchedule.Where(x => x.FlightId == id).FirstOrDefault();
                if (result != null)
                {
                    dbcontext.FlightSchedule.Remove(result);
                    dbcontext.SaveChanges();
                    return "successfully schedule for this flight is Deleted";
                }
                else
                {
                    return "Schedule has not been Remove see DataBase";
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }

    
}
