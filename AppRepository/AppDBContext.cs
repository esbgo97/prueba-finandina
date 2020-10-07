
using System.Data.SqlClient;
using System.Data;

namespace AppRepository
{
    public static class AppDBContext
    {
        //private static SqlConnection _connection = new SqlConnection("Server=(local);DataBase=master;User=sa;Password=root1234;Integrated Security=True");

        public static DataTable ExecuteSP(string spName, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection("Server=(local);DataBase=master;User=sa;Password=root1234;Integrated Security=True"))
            {
                connection.Open();
                var command = new SqlCommand(spName, connection);
                command.CommandType = CommandType.StoredProcedure;
                if (parameters != null)
                    command.Parameters.AddRange(parameters);
                var reader = command.ExecuteReader();
                var dataTable = new DataTable();
                dataTable.Load(reader);
                connection.Close();
                return dataTable;
            }
        }
    }
}
