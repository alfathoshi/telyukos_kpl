using System;
namespace telyukos
{
    //table driven
    public static class Role
    {
        public enum RoleUser { PENYEWA, PEMILIK }

        public static string getRole(RoleUser roleName)
        {
            string[] inputUser = { "penyewa", "pemilik" };
            return inputUser[(int)roleName];
        }

    }


}
