namespace telyukos_library.Contract
{
    public static class Contract
    {
        public static void Requires(bool condition, string message)
        {
            if (!condition)
            {
                Console.WriteLine(message);
                Environment.Exit(1);
            }
        }
    }
}
