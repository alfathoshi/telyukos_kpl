using System;
namespace telyukos {
    public class RentStatus
    {
        public enum RentsStatus { Status1, Status2}

        public static string getRentStatus(RentsStatus status)
        {
            string[] input = { "Tersedia", "Disewa"};
            return input[(int)status];

        }
    }
}



