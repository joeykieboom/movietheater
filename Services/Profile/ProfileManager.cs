using dotnet_core_theater.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_core_theater.Services.Profile
{
    public class ProfileManager
    {
        private readonly UserManager<Models.UserModel> _userManager;
        private readonly SignInManager<UserModel> _signInManager;
        IHttpContextAccessor _httpContextAccessor;

        private UserModel _currentUser;

        public ProfileManager(UserManager<UserModel> userManager, SignInManager<UserModel> signInManager, IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public UserModel CurrentUser
        {
            get
            {
                if (_currentUser == null)
                    _currentUser = _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User).Result;

                return _currentUser;
            }
        }

        public bool IsHasPassword(UserModel user)
        {
            return _userManager.HasPasswordAsync(user).Result;
        }

        public bool IsEmailConfirmed(UserModel user)
        {
            return _userManager.IsEmailConfirmedAsync(user).Result;
        }
    }
}
