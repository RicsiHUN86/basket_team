using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basket_team
{
    public class Connect
    {
        public MySqlConnection Connection;
        public string Host;
        public string DataBase;
        public string User;
        public string Password;
        public string ConnectionString;
        
        public Connect()
        {
        Host = "localhost";
        DataBase = "Team";
        User = "root";
        Password = "";

        ConnectionString = "SERVER=" + Host + ";DATABASE=" + DataBase + ";UID=" + User + ";PASSWORD=" + Password + ";SslMode=None";

        Connection = new MySqlConnection(ConnectionString);
        }
    }
}
