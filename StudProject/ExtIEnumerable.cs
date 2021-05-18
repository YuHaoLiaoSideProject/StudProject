using System;
using System.Collections.Generic;
using System.Linq;

namespace StudProject
{
    public static class ExtIEnumerable
    {
        public static bool IsContainTimes<T>(this IEnumerable<T> array, T quantity, int frequency) where T : IComparable
        {
            return array.Count(e => e.Equals(quantity)) == frequency;
        }
    }



}
