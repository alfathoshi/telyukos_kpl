using System;

namespace telyukos
{
    //table driven
    public class Role
    {
        public enum Roles { Penyewa, Pemilik }

        public static string getRole(Roles roleName)
        {
            string[] inputUser = { "PENYEWA", "PEMILIK" };
            return inputUser[(int)roleName];
        }

    }

}
