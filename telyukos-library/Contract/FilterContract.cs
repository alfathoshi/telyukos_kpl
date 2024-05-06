using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telyukos_library.Contract
{
    public class FilterContract
    {
        public static bool CheckContract(int price, int min, int max)
        {
            return price >= min && price <= max;
        }
    }
}
