namespace telyukos
{
    public class Kos
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public int Harga { get; set; }
        public string Alamat { get; set; }
        public int Kapasitas { get; set;}
        public KosStatus.RentsStatus Status { get; set; }
        public List<string>? Penyewa { get; set; }
    }

}
