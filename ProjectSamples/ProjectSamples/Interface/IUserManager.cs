using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSamples.Interface
{
    public interface IUserManager
    {
        bool AddUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(int userId);
        IList<User> GetAllUser();
        User GetUserById(int userId);
    }
}
