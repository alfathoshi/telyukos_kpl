using System.Text.Json;

namespace telyukos
{
    public class configCreateKos
    {

        public class Konfig
        {

            public string pesan_ditolak { get; set; }
            public string pesan_diterima { get; set; }
            public string nama_kos { get; set; }
            public int harga_kos { get; set; }
            public string alamat_kos { get; set; }

        }

        public Konfig konfig;

        public configCreateKos()
        {
            try
            {
                ReadConfigFile();
            }
            catch (Exception)
            {

                SetDefault();
                WriteConfigFile();
            }
        }

        public void SetDefault()
        {

        }

        private const string filePath = "createkos_config.json";

        public void ReadConfigFile()
        {
            String configJsonData = File.ReadAllText(filePath);
            konfig = JsonSerializer.Deserialize<Konfig>(configJsonData);
        }

        public void WriteConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            String json = JsonSerializer.Serialize(konfig);
            File.WriteAllText(filePath, json);
        }

    }
}
