using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBLL.Entity.User
{
    public class User
    {
        public User ()
        {}

        public User (int id, string email, string password, string userName, string fullName, string address, string preferredLanguage, string roleName)
        {
            Id = id;
            Email = email;
            Password = password;
            UserName = userName;
            FullName = fullName;
            Address = address;
            PreferredLanguage = preferredLanguage;
            RoleName = roleName;
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PreferredLanguage { get; set; }
        public string RoleName { get; set; }
    }
}