using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telyukos_library.Searching
{
    public class SequentialSearch<T>
    {
        public static int Search(T[] array, T target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(target))
                {
                    return i; // Elemen ditemukan, kembalikan indeksnya
                }
            }
            return -1; // Elemen tidak ditemukan dalam array
        }
    }
}
