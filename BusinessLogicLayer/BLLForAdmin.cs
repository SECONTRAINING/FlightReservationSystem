using DataAccessLayer;
using DataModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class BLLForAdmin : IBLLForAdmin
    {
        private IDALForAdmin _dALForAdmin;
        public BLLForAdmin(IDALForAdmin dALForAdmin) {
            _dALForAdmin = dALForAdmin;
        }
        public List<User> GetAllUsers()
        {
            try
            {
                return _dALForAdmin.GetAllUsers();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public string  InsertUser(User user)
        {
            try
            {
                return _dALForAdmin.InsertUser( user);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string DeleteUser(int UserId)
        {
            try
            {
                return _dALForAdmin.DeleteUser(UserId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public int ValidateLogin(string UserName,string Password)
        {
            try
            {
                return _dALForAdmin.ValidateLogin(UserName,Password);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}






















