using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AccountManagement.Domain.Interfaces;
using AccountManagement.Domain.Models.Account;

namespace AccountManagement.Infra.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        #region constractor
        private readonly AccountContext _context;
        public UserRepository(AccountContext context)
        {
            _context = context;
        }

        #endregion

        #region account
        public async Task<bool> IsUserExistPhoneNumber(string phoneNumber)
        {
            return await _context.Users.AsQueryable().AnyAsync(c => c.PhoneNumber == phoneNumber);
        }

        public async Task CreateUser(User user)
        {
            await _context.Users.AddAsync(user);

        }
        public async Task<User> GetUserByPhoneNumber(string phoneNumber)
        {
            return await _context.Users.AsQueryable()
                .SingleOrDefaultAsync(c => c.PhoneNumber == phoneNumber);
        }
        public void UpdateUser(User user)
        {
            _context.Users.Update(user);
        }

        public async Task SaveChange()
        {
            await _context.SaveChangesAsync();
        }




        #endregion
    }
}
