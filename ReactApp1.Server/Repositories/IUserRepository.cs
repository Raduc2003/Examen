using ReactApp1.Server.Entities;

namespace ReactApp1.Server.Repositories
{
    public interface IUserRepository
    {
         Task<List<User>> GetUsersAsync();
         Task<User> AddUserAsync(User User);
    }
}
