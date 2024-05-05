using System.Reflection.Emit;
using telyukos_library.Menu;
using telyukos;
using static telyukos.Akun;
using telyukos_library.Menu.MainMenu;
using telyukos_library.Searching;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using telyukos_library.Menu.PemilikKos;
using System.ComponentModel.Design;
using telyukos;
using System.Net.Http.Json;




internal class Program
{
    private static AuthState app = new AuthState();
    private static TableDrivenAkun CekAkun = new TableDrivenAkun();
    public static void Main(string[] args)
    {

        string Email = TableDrivenAkun.getAKun(TableDrivenAkun.akun.Penyewa);

        app.currentState = AuthState.State.START;

        while (app.currentState != AuthState.State.EXIT)
        {

            menu _menu = new menu();
            if (app.currentState != AuthState.State.LOGIN)
            {

                _menu.header();
                string choice = Console.ReadLine();
                Console.WriteLine();
                Debug.Assert(choice == "1" || choice == "2", "PROGRAM TELAH BERAKHIR");

                switch (choice)
                {
                    case "1":
                        // Login
                        Console.Write("Email: ");
                        string email = Console.ReadLine();
                        Console.Write("Password: ");
                        string password = Console.ReadLine();

                        Console.WriteLine();
                        if (email == TableDrivenAkun.getAKun(TableDrivenAkun.akun.Pemilik) || email == TableDrivenAkun.getAKun(TableDrivenAkun.akun.Penyewa))
                        {
                            app.currentState = app.getNextState(app.currentState, AuthState.Trigger.LOGIN_DITERIMA);

                        }
                        else if (email != TableDrivenAkun.getAKun(TableDrivenAkun.akun.Pemilik) || email != TableDrivenAkun.getAKun(TableDrivenAkun.akun.Penyewa))
                        {
                            Console.WriteLine("Email / Password tidak sesuai");
                        }
                        else
                        {
 
                            Console.WriteLine("Failed to login: ");
                        }
                        break;

                    case "2":
                        // Register
                        Console.WriteLine();
                        Console.Write("Email: ");
                        string newEmail = Console.ReadLine();
                        Console.Write("Password: ");
                        string newPassword = Console.ReadLine();
                        Console.Write("Role (penyewa/pemilik): ");
                        string role = Console.ReadLine();


                        if (newEmail != TableDrivenAkun.getAKun(TableDrivenAkun.akun.Pemilik) || newEmail != TableDrivenAkun.getAKun(TableDrivenAkun.akun.Penyewa))
                        {

                            Console.WriteLine("Response Register:");
                            Console.WriteLine("Register Telah Berhasil");
                        }
                        else if (newEmail != TableDrivenAkun.getAKun(TableDrivenAkun.akun.Pemilik) || newEmail != TableDrivenAkun.getAKun(TableDrivenAkun.akun.Penyewa))
                        {
                            Console.WriteLine("Failed to register: ");
                            Console.WriteLine("Email sudah terdaftar");
                        }
                        break;

                    case "0":
                        app.currentState = app.getNextState(app.currentState, AuthState.Trigger.CLOSE);
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            }
            else
            {

                Console.WriteLine("pilih Role :");
                string InputRole = Console.ReadLine();
                if (InputRole == Role.getRole(Role.Roles.Penyewa))
                {
                    _menu.mainManuRenter();
                    string menuChoice = Console.ReadLine();
                    Debug.Assert(!string.IsNullOrEmpty(menuChoice), "Inputan tidak  boleh kosong");
                    if (menuChoice == null)
                    {
                        Debug.Assert(menuChoice != null, "Inputan tidak  boleh kosong");
                    }
                    else if (menuChoice == "0")
                    {
                        app.currentState = app.getNextState(app.currentState, AuthState.Trigger.CLOSE);
                        Debug.Assert(menuChoice == "0", "PROGRAM TELAH BERAKHIR");
                    }
                    else if (menuChoice == "4")
                    {
                        app.currentState = app.getNextState(app.currentState, AuthState.Trigger.LOGOUT);
                    }
                }
                else if (InputRole == Role.getRole(Role.Roles.Pemilik))
                {
                    _menu.mainMenuOwner();
                    string menuChoice = Console.ReadLine();
                    Debug.Assert(!string.IsNullOrEmpty(menuChoice), "Inputan tidak  boleh kosong");
                    if (menuChoice == null)
                    {
                        Debug.Assert(menuChoice != null, "Inputan tidak  boleh kosong");
                    }
                    else if (menuChoice == "0")
                    {
                        app.currentState = app.getNextState(app.currentState, AuthState.Trigger.CLOSE);
                        Debug.Assert(menuChoice != "0", "PROGRAM TELAH BERAKHIR");

                    }else if(menuChoice == "5")
                    {
                        app.currentState = app.getNextState(app.currentState, AuthState.Trigger.LOGOUT);
                    }
                }
            }

        }
    }

}