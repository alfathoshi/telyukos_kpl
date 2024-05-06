using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telyukos_library.Searching
{
    public static class FilterKos <T>
    {
        public static IEnumerable<T> FilterKosByPrice(T[] kosList, Func<T, int> getPrice, int minPrice, int maxPrice)
        {
            return kosList.Where(k => getPrice(k) >= minPrice && getPrice(k) <= maxPrice);
        }
    }
}
