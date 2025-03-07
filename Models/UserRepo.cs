using Dapper;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Repositories
{
    public class UserRepo : IUserRepo
    {
        // Add a method to retrieve data from the database
        public async Task<List<UserModel>> GetData()
        {
            using (SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;database=CrudAppDB;Trusted_Connection=True"))
            {
                try
                {
                    await conn.OpenAsync();
                    var e = await conn.QueryAsync<UserModel>("SELECT * FROM Person");
                    return e.ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error while fetching data", ex);
                }
            }
        }

        // Existing AddPerson method
        public async Task<int> AddPerson(UserModel data)
        {
            using (SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;database=CrudAppDB;Trusted_Connection=True"))
            {
                try
                {
                    var query = "Insert into Person(name, email) Values(@name, @email)";
                    var parameters = new DynamicParameters();
                    parameters.Add("@name", data.name);
                    parameters.Add("@email", data.email);

                    int personId = await conn.ExecuteScalarAsync<int>(query, parameters); // Returns the generated ID
                    return personId;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error while adding data", ex);
                }
            }
        }
    }
}
