using System;
namespace telyukos
{
    //table driven
    public class Role
    {
        public enum Roles { Role1, Role2 }

        public static string getRole(Roles roleName)
        {
            string[] inputUser = { "PENYEWA", "PEMILIK" };
            return inputUser[(int)roleName];
        }

    }


}
