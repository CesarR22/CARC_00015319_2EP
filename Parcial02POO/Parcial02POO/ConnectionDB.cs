using System.Data;
using Npgsql;

namespace Parcial02POO
{
    public static class ConnectionDB
    {
        private static string host = "localhost",
            database = "bddHugo",
            userID = "postgres",
            password = "1234";
        
        private static string sConecction =
            $"Server={host};Port=5432;User Id={userID};Password={password};Database={database};";
        
        public static DataTable ExecuteQuery(string query)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConecction);
            DataSet ds = new DataSet();

            connection.Open();

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            da.Fill(ds);
                

            connection.Close();

            return ds.Tables[0];
        }

        public static void ExecuteNonQuery(string act)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConecction);

            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand(act, connection);
            command.ExecuteNonQuery(); 

            connection.Close(); 
        }
    }
}