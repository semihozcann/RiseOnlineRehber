using RiseOnlineRehber.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiseOnlineRehber.Business.Abstract
{
    public interface IAuthenticationService
    {
        bool CreateUser(User user, string password);
        Task<bool> SignOut();
        User AuthenticateUser(string userName, string password);
        User GetUser(string username);


    }
}
