using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Algo
{
    public static class SelectSort
    {
        public static int[] Sort(int[] arr)
        {
            int[] result = new int[arr.Length];
            arr.CopyTo(result, 0);
            int currIndex = 0;
            int minI;
            int tmp = arr[0];

            while(currIndex < result.Length)
            {
                tmp = result[currIndex];
                minI = currIndex;
                for (int i = currIndex;i < result.Length;i++)
                {
                    if (result[i] < tmp)
                    {
                        tmp = result[i];
                        minI = i;
                    }
                }
                tmp = result[currIndex];
                result[currIndex] = result[minI];
                result[minI] = tmp;
                currIndex++;
                
            }


            return result;
        }
    }
}
