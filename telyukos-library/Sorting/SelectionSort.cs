using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telyukos_library.Sorting
{
    public class SelectionSort<T> where T : IComparable<T>
    {
        public static void SortAscending(T[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (array[j].CompareTo(array[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    T temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }
            }
        }

        public static void SortDescending(T[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int maxIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (array[j].CompareTo(array[maxIndex]) > 0)
                    {
                        maxIndex = j;
                    }
                }

                if (maxIndex != i)
                {
                    T temp = array[i];
                    array[i] = array[maxIndex];
                    array[maxIndex] = temp;
                }
            }
        }
    }
}
