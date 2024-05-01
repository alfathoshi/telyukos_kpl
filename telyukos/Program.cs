using Newtonsoft.Json;
using System.Text.Json;

class Program
{
    private static void Main(string[] args)
    {
        List<Account> akun = new List<Account>();

        jsonAdress json = new jsonAdress();

        using (StreamReader reader = new StreamReader(json.filepath))
        {
            akun = JsonConvert.DeserializeObject<List<Account>>(reader.ReadToEnd());
        }

        foreach (var item in akun)
        {
            Console.WriteLine(item.username);
        }
        Console.WriteLine();


        akun.Add(new Account(100, "a", "b", "c"));


        foreach (var item in akun)
        {
            Console.WriteLine(item.username);
        }




        /*configCreateKos config = new configCreateKos();

        Console.WriteLine(config.konfig.nama_kos);


        string nama = Console.ReadLine();

		config.konfig.nama_kos = nama;

		config.WriteConfigFile();

		Console.WriteLine(config.konfig.nama_kos);*/
    }
}


/*CRUD Pemilik Kos {
	Create Kos (Automata, Table Driven, RunCog, API)
	Read Kos (Library, API)
	Edit Kos (Automata, Table Driven, RunCog, API)
	Delete Kos (Automata, Table Driven, RunCog, API)
}*/
