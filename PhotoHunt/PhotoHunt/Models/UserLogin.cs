using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity;

namespace PhotoHunt.Models
{
    public class UserLogin : IUserLogin
    {
        [Key, Column(Order = 0)]
        public string LoginProvider { get; set; }
        [Key, Column(Order = 1)]
        public string ProviderKey { get; set; }

        public string UserId { get; set; }

        public UserLogin() { }

        public UserLogin(string userId, string loginProvider, string providerKey)
        {
            LoginProvider = loginProvider;
            ProviderKey = providerKey;
            UserId = userId;
        }
    }
}