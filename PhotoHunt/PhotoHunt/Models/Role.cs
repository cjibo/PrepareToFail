using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;

namespace PhotoHunt.Models
{
    public class Role : IRole
    {
        public Role()
            : this(String.Empty)
        {
        }

        public Role(string roleName)
        {
            Id = roleName;
        }

        [Key]
        public string Id { get; set; }
    }
}