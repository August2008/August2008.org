﻿using System;
using System.Collections.Generic;
using August2008.Model;

namespace August2008.Common.Interfaces
{
    public interface IAccountRepository
    {
        User CreateUser(User user);
        User GetUser(int userId);
        OAuthUser CreateOAuthUser(OAuthUser user);
        bool TryGetUserRegistered(string providerId, out int? userId, out bool isOAuthUser, out bool isRegistered);
        IEnumerable<User> GetUsers();
        IEnumerable<User> SearchUsers(string name = null);
        IEnumerable<Role> GetUserRoles(int userId);
        void AssignUserToRoles(int userId, IEnumerable<int> roles);
        void RevokeUserFromRoles(int userId, IEnumerable<int> roles); 
    }
}
