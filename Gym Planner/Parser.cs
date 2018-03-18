using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Planner
{
    public static class Parser
    {
        public static int? ToNullableInt(this string s)
        {
            int i;
            if (int.TryParse(s, out i)) return i;
            return null;
        }
        public static decimal? ToNullableDouble(this string s)
        {
            decimal i;
            if (decimal.TryParse(s, out i)) return i;
            return null;
        }
    }
}
