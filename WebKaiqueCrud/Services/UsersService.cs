using Microsoft.EntityFrameworkCore;
using WebKaiqueCrud.Context;
using WebKaiqueCrud.Models;

namespace WebKaiqueCrud.Services
{
    public class UsersService : IUserService
    {

        private readonly AppDbContext _context;

        public UsersService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User> GetUser(int id)
        {               
            var obj = await _context.Users.FindAsync(id);
            return obj;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<IEnumerable<User>> GetUsersByName(string name)
        {
            IEnumerable<User> users;
            if (!string.IsNullOrWhiteSpace(name))
            {
                users = await _context.Users.Where(n => n.name.Contains(name)).ToListAsync();
            }
            else { 
                users = await GetUsers();
            }
            return users;
        }

        public async Task CreateUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

        }

        public async Task UpdateUser(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUser(int id)
        {
            _context.Remove(id);
            await _context.SaveChangesAsync();
        }
    }
}
