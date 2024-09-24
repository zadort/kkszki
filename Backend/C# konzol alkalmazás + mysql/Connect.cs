using MySql.Data.MySqlClient;

namespace Auto
{
    public class Connect
    {
        public MySqlConnection Connection;
        private string Host;
        private string Database;
        private string Username;
        private string Password;
        private string ConnectionString;

        public Connect()
        {
            Host = "localhost";
            Database = "auto";
            Username = "root";
            Password = "";
            ConnectionString = ConnectionString = "SERVER=" + Host + ";DATABASE=" + Database + ";UID=" + Username + ";PASSWORD=" + Password + ";SslMode=None";
            Connection = new MySqlConnection(ConnectionString);
        }
    }
}