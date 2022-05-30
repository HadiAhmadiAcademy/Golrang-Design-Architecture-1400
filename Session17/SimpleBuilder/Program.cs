using System;
using System.Data.Common;
using System.Data.SqlClient;

namespace SimpleBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = "Data source=.;Initial Catalog=TestDb;Integrated Security=true";
            var builder = new SqlConnectionStringBuilder(connection);
            builder.InitialCatalog = "NewTestDB";

            connection = builder.ConnectionString;
        }
    }
}
