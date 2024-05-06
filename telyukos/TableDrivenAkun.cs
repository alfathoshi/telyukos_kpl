using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static telyukos.Role;

namespace telyukos
{
    public class TableDrivenAkun
    {
        public enum akun { Pemilik, Penyewa }

        public static string getAKun(akun email)
        {
            string[] inputUser = { "budi", "joko" };
            return inputUser[(int)email];
        }
    }
}