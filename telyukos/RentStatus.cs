using System;
namespace telyukos {
    public class RentStatus
    {
        public enum RentsStatus { Status1, Status2, Status3 }

        public static string getRentStatus(RentsStatus status)
        {
            string[] input = { "Tersedia", "Disewa", "Penuh" };
            return input[(int)status];

        }
    }
}



