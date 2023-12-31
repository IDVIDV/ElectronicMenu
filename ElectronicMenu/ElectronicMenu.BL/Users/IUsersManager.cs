﻿using ElectronicMenu.BL.Users.Entities;

namespace ElectronicMenu.BL.Users
{
    public interface IUsersManager
    {
        void DeleteUser(Guid id);
        UserModel UpdateUser(Guid id, UpdateUserModel model);
    }
}
