﻿using AccountManagement.Domain.Models.Account;
using Shop.Domain.ViewModels.Account;

namespace AccountManagement.Application.Interfaces
{
    public interface IUserService
    {
        #region account
        Task<RegisterUserResult> RegisteUser(RegisterUserViewModel register);
        Task<LoginUserResult> LoginUser(LoginUserViewModel login);
        Task<User> GetUserByPhoneNumber(string phoneNumber);
        Task<ActiveAccountResult> ActiveAccount(ActiveAccountViewModel activeAccount);
        #endregion
    }
}
