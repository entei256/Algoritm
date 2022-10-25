using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Algo
{
    public static class CountingSort
    {
        public static int[] Sort (int[] arr)
        {
            int[] result = new int[arr.Length];
            arr.CopyTo(result, 0);



            return result;
        }
    }
}
