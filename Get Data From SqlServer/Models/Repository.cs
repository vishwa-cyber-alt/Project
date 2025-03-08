using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace JobApp.Models
{
    public class Repository
    {
        //public static Model Login(Model model)
        //{
        //    using (SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=App;Trusted_Connection=True;"))
        //    {
        //        var query = "SELECT * FROM Users WHERE username = @username AND password = @password";
        //        var result = conn.QueryFirstOrDefault<Model>(query, new
        //        {
        //            username = model.username,
        //            password = model.password,
        //        }, commandType: CommandType.Text);
        //        return result;
        //    }
        //}
        public static async Task<List<Suppliers>> GetSupplier()
        {
            using (SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=Test;Trusted_Connection=True;"))

            {

                await conn.OpenAsync();
                var res = await conn.QueryAsync<Suppliers>("select * from Supplier");
                return res.ToList();
            }
        }
    }
}
