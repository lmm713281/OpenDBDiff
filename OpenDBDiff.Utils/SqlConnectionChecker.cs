using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OpenDBDiff.Utils
{
    public static class SqlConnectionChecker
    {
        public static async Task<bool> CanConnect(string server, string database, CancellationToken cancellationToken = default(CancellationToken))
        {
            var connectionString = BuildConnectionString(server, database);
            try
            {
                using (var connection = new SqlConnection(connectionString))
                    await connection.OpenAsync(cancellationToken);

                return true;
            }
            catch
            {
                return false;
            }
        }

        private static string BuildConnectionString(string server, string database)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = server.Trim();

            // if database is ommitted the connection will be established to the default database for the user
            if (!string.IsNullOrEmpty(database))
                builder.InitialCatalog = database.Trim();

            builder.IntegratedSecurity = true;
            return builder.ConnectionString;
        }

        private static string BuildConnectionString(string server, string database, string username, string password)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(BuildConnectionString(server, database));

            builder.IntegratedSecurity = false;
            builder.UserID = username;
            builder.Password = password;
            return builder.ConnectionString;
        }


    }
}
