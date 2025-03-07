using System.Data.SqlClient;
using Dapper;
using WebApplication2.Repositories;
namespace WebApplication2.Models
{
    public class CredentialsRepo : ICredentialsRepo
    {
        public async Task<List<Credentials>> GetCred()
        {
            using (SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;database=Credentials;Trusted_Connection=True"))
            {
                try
                {
                    await conn.OpenAsync();
                    var e = await conn.QueryAsync<Credentials>("SELECT * FROM Users");
                    return e.ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error while fetching data", ex);
                }
            }
        }
    }
}
