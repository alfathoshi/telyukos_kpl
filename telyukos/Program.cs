﻿using System.Globalization;
using telyukos;

internal class Program
{
    private static void Main(string[] args)
    {





		/*configCreateKos config = new configCreateKos();

        Console.WriteLine(config.konfig.nama_kos);


        string nama = Console.ReadLine();

		config.konfig.nama_kos = nama;

		config.WriteConfigFile();

		Console.WriteLine(config.konfig.nama_kos);*/
    }
}

public static class clientAPI
{
	static HttpClient client = new HttpClient();
	static HttpResponseMessage response;
	
}

/*CRUD Pemilik Kos {
	Create Kos (Automata, Table Driven, RunCog, API)
	Read Kos (Library, API)
	Edit Kos (Automata, Table Driven, RunCog, API)
	Delete Kos (Automata, Table Driven, RunCog, API)
}*/
