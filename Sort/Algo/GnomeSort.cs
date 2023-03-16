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

            int tmp,i = 1;
            int offset = -1;

            
            while (i < result.Length)
            {
                if (result[i+offset] < result[i])
                {
                    i++;
                } else
                {
                    tmp = result[i+offset];
                    result[i+offset] = result[i];
                    result[i] = tmp;
                    if (i > 1) 
                        i--;
                    else 
                        i = 1;
                }
            }
                

            return result;
        }
    }
}
