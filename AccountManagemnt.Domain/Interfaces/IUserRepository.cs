using AccountManagement.Domain.Models.Account;
using System.Threading.Tasks;

namespace AccountManagement.Domain.Interfaces
{
    public interface IUserRepository
    {
        #region account
        Task<bool> IsUserExistPhoneNumber(string phoneNumber);
        Task CreateUser(User user);
        Task<User> GetUserByPhoneNumber(string phoneNumber);
        void UpdateUser(User user);
        Task SaveChange();
        #endregion
    }
}
