using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telyukos_library.Searching
{
    public static class SearchKos
    {
        public static T Search<T>(T[] array, Func<T, bool> predicate)
        {
            foreach (var item in array)
            {
                if (predicate(item))
                {
                    return item;
                }
            }
            return default(T);
        }
    }
}
