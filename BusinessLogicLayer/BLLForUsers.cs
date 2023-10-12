using DataAccessLayer;
using DataModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public  class BLLForUsers: IBLLForUsers
    {
        IDALForUsers _dalForUsers;
        public BLLForUsers(IDALForUsers dALForUsers) 
        {
            _dalForUsers= dALForUsers;
        }

        public List<FlightDetails> getFlightsByDayAndLocation(string day, string source, string destination)
        {
            try
            {
                return _dalForUsers.getFlightsByDayAndLocation(day, source, destination);
            }
            catch(Exception ex)
            {
                throw(ex);
            }
        }
    }
}
