using ApiLibraryControl.Library.Models;

namespace ApiLibraryControl.Library.DataAccess
{
    public interface IUserData
    {
        void AddUser(UserModel model);
        UserModel GetUserById(string id);
    }
}