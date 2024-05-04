using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telyukos
{
    internal class AsserAkun
    {
        public AsserAkun(string username, string password)
        {
            Debug.Assert(username == "budi" && password == "doremi", "Username dan Password harus sesuai dengan saat regis");
            Debug.Assert(username != null && password != null, "Username & Password tidak boleh kosong");
        }

    }
}
