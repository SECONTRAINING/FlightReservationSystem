using DataModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public interface IBLLForAdmin
    {
        List<User> GetAllUsers();

        string InsertUser(User user);

        string DeleteUser(int UserId);

        int ValidateLogin(string UserName, string Password);
    }
}
