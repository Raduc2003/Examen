using Microsoft.EntityFrameworkCore;
using ReactApp1.Server.Contexts;
using ReactApp1.Server.Entities;

namespace ReactApp1.Server.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly ApplicationContext _context;
        public UserRepository(ApplicationContext context)
        {
            _context= context;
        }
        public async Task<List<User>> GetUsersAsync() 
        {
               var students = await _context.Users.ToListAsync();
                return students;

        }

        public async Task<User> AddUserAsync(User User)
        {
            _context.Users.Add(User);
            return User;

        }


    }
}
