using System.Data.SqlClient;

namespace OpenX_Interfaces
{
    public static class DatabaseManager
    {
        private static string connectionString = "Server=localhost;Database=UsuariosDB;Trusted_Connection=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
