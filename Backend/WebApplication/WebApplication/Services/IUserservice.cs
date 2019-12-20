using System.Collections.Generic;
using T.Core;

namespace T.Services
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
    }
}
