using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity.EntityFramework;

namespace PhotoHunt.Models
{
    public class UserRole : IUserRole
    {
        [Key, Column(Order = 0)]
        public string RoleId { get; set; }
        [Key, Column(Order = 1)]
        public string UserId { get; set; }
    }
}