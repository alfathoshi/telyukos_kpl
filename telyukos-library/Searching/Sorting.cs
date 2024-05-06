using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telyukos_library.Searching
{
    public static class SelectionSort<T> 
    {
        private static void Sort(T[] array, Func<T, IComparable> selector, IComparer<IComparable> comparer)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (comparer.Compare(selector(array[j]), selector(array[minIndex])) < 0)
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

        public static void SortAscending(T[] array, Func<T, IComparable> selector)
        {
            Sort(array, selector, Comparer<IComparable>.Default);
        }

        public static void SortDescending(T[] array, Func<T, IComparable> selector)
        {
            Sort(array, selector, Comparer<IComparable>.Create((x, y) => -x.CompareTo(y)));
        }

    }
}