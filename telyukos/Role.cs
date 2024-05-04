using System;
namespace telyukos
{
    //table driven
    public class Role
    {
        public enum RoleUser { RENTER, OWNER }

        public static string getRole(RoleUser roleName)
        {
            string[] inputUser = { "penyewa", "pemilik" };
            return inputUser[(int)roleName];
        }

    }

}
