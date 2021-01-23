using ApiLibraryControl.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiLibraryControl.Library.DataAccess
{
    public class UserData : IUserData
    {
        private readonly ISqlDataAccess _dataAccess;

        public UserData(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void AddUser(UserModel model)
        {
            _dataAccess.SaveData("spUser_AddUser", model, "LibraryDatabase");
        }

        public UserModel GetUserById(string id)
        {
           var output = _dataAccess.LoadData<UserModel, dynamic>("spUser_GetById", new { id }, "LibraryDatabase").FirstOrDefault();
            return output;
        }

    }
}
