using System.Threading.Tasks;
using WebApplication2.Models;
// Adjust this to match the location of UserModel

namespace WebApplication2.Repositories
{
    public interface ICredentialsRepo
    {
        
        Task<List<Credentials>> GetCred();
    }
}
