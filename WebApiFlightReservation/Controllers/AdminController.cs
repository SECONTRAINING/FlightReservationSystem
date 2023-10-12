using BusinessLogicLayer;
using DataModelLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightReservationSystem.API
{
    [System.Web.Http.Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private IBLLForAdmin _bLLForAdmin { get; set; }
        public AdminController(IBLLForAdmin bLLForAdmin)
        {
            _bLLForAdmin = bLLForAdmin;
        }
        [Authorize]
        [HttpGet]
        [Route("GetAllUser")]
        public List<User> GetAllUser()
        {
            try
            {
                return _bLLForAdmin.GetAllUsers();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        
        [HttpPost]
        [Route("InsertorUpdateUser/")]

        public string InsertUser(User user)
        {
            try
            {
                return _bLLForAdmin.InsertUser(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        [Route("DeleteUserbyId/")]
        public string DeleteUser(int UserId)
        {

            try
            {
                return _bLLForAdmin.DeleteUser(UserId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("Login")]
        public int ValidateUser(string UserName, string Password)
        {
            try
            {
                return _bLLForAdmin.ValidateLogin(UserName, Password);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
