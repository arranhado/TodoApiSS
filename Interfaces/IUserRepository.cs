using TodoApiSS.Models;
using System.Threading.Tasks;
namespace TodoApiSS.Interfaces
{
    /// <summary>
    /// Interface untuk Data Access Layer (Repository) yang mengelola entitas User.
    /// Bekerja langsung dengan model 'User'.
    /// </summary>
    public interface IUserRepository
    {
        Task<User?> GetByIdAsync(int id);
        Task<User?> GetByUsernameAsync(string username);
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(User user);
        Task<IEnumerable<User>> GetAllAsync();
    }
}