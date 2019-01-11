using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Persistence;
namespace DAL
{
    public class UserDal
    {
        private string query;
        private static MySqlConnection connection;
        private MySqlDataReader reader;
        public User GetUserByUserName(string user_name)
        {
            query = @"select user_id, user_name, user_password, registration_date
                        from users where user_name=@username;";
            // MySqlCommand command = new MySqlCommand(query);
            connection = DBHelper.OpenConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", user_name);
            reader =  command.ExecuteReader();
            User user = null;
            if (reader.Read())
            {
                user = new User(reader);
            }
            DBHelper.CloseConnection();
            return user;
        }
    }
}