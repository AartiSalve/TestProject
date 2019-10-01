using System;
using System.Data;
using System.Data.SqlClient;
namespace ProjectSamples.Repository
{
    public class BaseRepository : IDisposable
    {
        protected IDbConnection con;
        public BaseRepository()
        {
            string connectionString = "Data Source=DIN19900521\\SQLEXPRESS;Initial Catalog=Master;Integrated Security=True";
            con = new SqlConnection(connectionString);
        }
        public void Dispose()
        {
            //throw new NotImplementedException();  
        }
    }
}