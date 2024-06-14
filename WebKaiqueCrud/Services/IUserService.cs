using WebKaiqueCrud.Models;

namespace WebKaiqueCrud.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);

        Task<IEnumerable<User>> GetUsersByName(string name);
        Task CreateUser(User user);
        Task UpdateUser(User user);
        Task DeleteUser(int id);
    }
}
