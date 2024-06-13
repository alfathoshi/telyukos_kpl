using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telyukos.Model
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public List<Kos>? Kos { get; set; }
    }

    public abstract class UserFactory
    {
        public abstract User CreateUser(string email, string password, string role);
    }

    public class OwnerFactory : UserFactory
    {
        public override User CreateUser(string email, string password, string role)
        {
            return new User
            {
                Email = email,
                Password = password,
                Role = role,
                Kos = new List<Kos>()
            };
        }
    }

    public class RenterFactory : UserFactory
    {
        public override User CreateUser(string email, string password, string role)
        {
            return new User
            {
                Email = email,
                Password = password,
                Role = role,
                Kos = new List<Kos>()
            };
        }
    }

}
