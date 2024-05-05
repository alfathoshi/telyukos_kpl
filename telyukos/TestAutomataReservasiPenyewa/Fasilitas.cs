namespace telyukos
{
    public class Fasilitas
    {
        public enum Facility { Objek1, Objek2, Objek3, Objek4, Objek5, Objek6, Objek7, Objek8, Objek9, Objek10}

        public static string getFacility(Facility fac)
        {
            string[] fasilitas = { "Tempat Tidur", "Lemari", "Meja dan kursi", "AC", "Kamar mandi", "Dapur", "Ruang tamu", "Ruang cuci", "Tempat parkir", "Jaringan internet" };
            return fasilitas[(int)fac];

        }
    }
}
