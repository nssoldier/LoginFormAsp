using System;
using System.Collections.Generic;
// using System.Data.MySqlClient;
using MySql.Data.MySqlClient;

namespace Persistence
{
    public class User
    {
        public User(int userId, string userName, string userPassword, DateTime registrationDate)
        {
            this.userId = userId;
            this.userName = userName;
            this.userPassword = userPassword;
            this.registrationDate = registrationDate;
        }
        public User()
        { }
        public User(MySqlDataReader reader)
        {
            
            userId = reader.GetInt32("user_id");
            userName = reader.GetString("user_name");
            userPassword = reader.GetString("user_password");
            registrationDate = reader.GetDateTime("registration_date");;
        }
        public int userId { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
        public DateTime registrationDate { get; set; }

        public override bool Equals(object obj)
        {
            var user = obj as User;
            return user != null &&
                   userId == user.userId;
        }

        public override int GetHashCode()
        {
            return -1234567890 + userId.GetHashCode();
        }
    }
}
