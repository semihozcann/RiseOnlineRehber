using Microsoft.AspNetCore.Mvc;
using RiseOnlineRehber.Entities.Concrete;
using RiseOnlineRehber.WebMvc.Abstract;

namespace RiseOnlineRehber.WebMvc.Controllers
{
    public class BaseController : Controller
    {
        public User CurrentUser
        {
            get
            {
                if (User != null)
                    return _userAccessor.GetUser();
                else
                    return null;
            }
        }

        IUserAccessor _userAccessor;
        public BaseController(IUserAccessor userAccessor)
        {
            _userAccessor = userAccessor;
        }
    }
}
