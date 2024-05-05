using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telyukos.State
{
    public class KosStatus
    {
        public enum RentsStatus { AVAIL, FULL }

        public static string getRentStatus(RentsStatus status)
        {
            string[] input = { "Tersedia", "Disewa" };
            return input[(int)status];

        }
    }
}
