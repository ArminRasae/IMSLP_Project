using AccountManagement.Domain.Models.Account;
using Microsoft.EntityFrameworkCore;

    public class AccountContext : DbContext
    {
        #region user
        public DbSet<User> Users { get; set; }
        #endregion

        #region constractor
        public AccountContext(DbContextOptions<AccountContext> options) : base(options)
        {

        }

        #endregion
    }

