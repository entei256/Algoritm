using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Algo
{
    public static class GnomeSort
    {
        public static int[] Sort(int[] arr)
        {
            int[] result = new int[arr.Length];
            arr.CopyTo(result, 0);

            int tmp;
            int offset = 1;
            
            for (int i = 0; i < result.Length - 1;)
            {
                if (result[i+offset] > result[i])
                {
                    offset = 1;
                } else
                {
                    tmp = result[i];
                    result[i+offset] = result[i];
                    result[i] = tmp;
                    offset = -1;
                }
                if (i>0 && i< result.Length-1)
                    i+=offset;
            }
                

            return result;
        }
    }
}
