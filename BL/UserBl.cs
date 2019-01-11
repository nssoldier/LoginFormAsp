using System;
using DAL;
using Persistence;
namespace BL
{
    public class UserBl
    {
        public User GetAUser(string user_name,string user_password)
        {
            UserDal udal = new UserDal();
            User user = new User();
            user = udal.GetUserByUserName(user_name);
            if (user.userPassword == user_password)
            {
                return user;
            }
            else
            {
                return null;
            }
        }
    }
}
