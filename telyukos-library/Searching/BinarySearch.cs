using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace telyukos_library.Searching
{
    public class BinarySearch<T>
    {
        public static int Search(T[] array, string target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                int compareResult = target.CompareTo(array[mid]);

                if (compareResult == 0)
                {
                    return mid; // Target ditemukan
                }
                else if (compareResult < 0)
                {
                    right = mid - 1; // Cari di bagian kiri
                }
                else
                {
                    left = mid + 1; // Cari di bagian kanan
                }
            }

            return -1; // Target tidak ditemukan
        }
    }
}
