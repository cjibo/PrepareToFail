using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;

namespace PhotoHunt.Models
{
    public class UserSecret : IUserSecret
    {
        public UserSecret()
        {
        }

        public UserSecret(string userName, string secret)
        {
            UserName = userName;
            Secret = secret;
        }

        [Key]
        public string UserName { get; set; }
        public string Secret { get; set; }
    }
}