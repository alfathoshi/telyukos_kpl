using System.Runtime.InteropServices;
using telyukos_library.Searching;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] intArray = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        double[] doubleArray = { 1.2, 3.4, 5.6, 7.8, 9.0, 10.1, 12.3, 14.5, 16.7, 18.9 };
        string[] stringArray = { "apple", "banana", "cherry", "date", "grape", "kiwi", "mango" };

        Console.WriteLine("Searching in intArray:");
        Console.WriteLine("Index of 10: " + BinarySearch<int>.Search(intArray, 10));
        Console.WriteLine("Index of 13: " + BinarySearch<int>.Search(intArray, 13));

        Console.WriteLine("\nSearching in doubleArray:");
        Console.WriteLine("Index of 10.1: " + BinarySearch<double>.Search(doubleArray, 10.1));
        Console.WriteLine("Index of 11.0: " + BinarySearch<double>.Search(doubleArray, 11.0));

        Console.WriteLine("\nSearching in stringArray:");
        Console.WriteLine("Index of 'banana': " + BinarySearch<string>.Search(stringArray, "banana"));
        Console.WriteLine("Index of 'lemon': " + BinarySearch<string>.Search(stringArray, "lemon"));
    }
}