using System.Threading.Tasks;
using WebApplication2.Models;
 // Adjust this to match the location of UserModel

namespace WebApplication2.Repositories
{
    public interface IUserRepo
    {
        Task<int> AddPerson(UserModel data);
        Task<List<UserModel>> GetData();
    }
}
