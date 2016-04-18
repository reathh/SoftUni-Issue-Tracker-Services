using System.Collections.Generic;
using SIT.Web.ViewModels.User;

namespace SIT.Web.Services
{
    public interface IUsersService
    {
        IEnumerable<UserViewModel> GetUsers();
        void MakeAdmin(string userId, string userToMakeAdminId);
        UserViewModel GetUser(string id);
    }
}