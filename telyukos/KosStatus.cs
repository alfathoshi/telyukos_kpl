using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telyukos
{
    public class KosStatus
    {
        public enum RentsStatus { Status1, Status2 }

        public static string getRentStatus(RentsStatus status)
        {
            string[] input = { "Tersedia", "Disewa" };
            return input[(int)status];

        }
    }
}
