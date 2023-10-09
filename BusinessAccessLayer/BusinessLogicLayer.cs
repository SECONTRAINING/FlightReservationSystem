using DataAccessLayer;
using DataModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayers
{
    public class BusinessLogicLayer
    {
        public IDAL _dataAccess;

        public BusinessLogicLayer(IDAL dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public List<User> getAllUsers()
        {
            return _dataAccess.getAllUsers();
        }
    }
}
