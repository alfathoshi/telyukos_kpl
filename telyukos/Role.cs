using System;
namespace telyukos
{
    //table driven
    public class Role
    {
        public enum Role { Role1, Role2 }

        public static string getRole(Role roleName)
        {
            string[] inputUser = { PENYEWA, PEMILIK }
            return inputUser[(string)roleName];
        }

    }

}
