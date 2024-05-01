using telyukos;
internal class Program
{
    private static void Main(string[] args)
    {
        Akun sistemAkun = new Akun();
        sistemAkun.ActiveTrigger(Akun.AkunTrigger.submit);
    }
}