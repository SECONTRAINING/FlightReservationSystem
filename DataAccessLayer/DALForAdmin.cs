using DataModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALForAdmin:IDALForAdmin
    {

        public FlightDbContext dbcontext;
        public DALForAdmin()
        {
            dbcontext = new FlightDbContext();
        }

        public List<User> GetAllUsers()
        {
            return dbcontext.User.ToList();
        }
        public string InsertUser(User input)
        {
            try
            {
                var result=dbcontext.User.Where(x=>x.UserId==input.UserId).FirstOrDefault();
                if (result!=null)
                {
                    result.DOB=input.DOB;
                    result.FirstName=input.FirstName;
                    result.LastName=input.LastName; 
                    result.Gender=input.Gender;
                    result.MobileNo=input.MobileNo;
                    dbcontext.SaveChanges();
                    return "User Updated";
                    
                }
                else
                {
                    dbcontext.User.Add(input);
                    dbcontext.SaveChanges();
                    return "User Registered Successfully";
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public string DeleteUser(int UserId)
        {
            try
            {
                User s = dbcontext.User.Where(x => x.UserId == UserId).FirstOrDefault();
                if (s != null)
                {
                    dbcontext.User.Remove(s);
                    dbcontext.SaveChanges();
                    return "Successfully Youre Data has been Deleted";
                }
                else
                {
                    return "Look into the database";
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int ValidateLogin(string UserName,string Password)
        {
            try
            {
                var result = dbcontext.User.Where(x => x.UserName == UserName && x.Password == Password).FirstOrDefault();
                if(result!=null)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


    }
}
