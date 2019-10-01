using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSamples.Interface
{
    public interface IUserRepository
    {
        bool AddUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(int userId);
        IList<User> GetAllUser();
        User GetUserById(int userId);
    }

    public interface ILocationRepository
    {
        IList<Country> GetAllCountry();
        IList<State> GetStateById(int StateId);
        IList<City> GetCityById(int CityID);
    }

}
