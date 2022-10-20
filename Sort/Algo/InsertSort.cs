using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Algo
{
    public static class InsertSort
    {
        public static int[] Sort(int[] arr)
        {
            int[] result = new int[arr.Length];
            arr.CopyTo(result, 0);

            int currIndex = 1;
            int tmp;

            while(currIndex < result.Length)
            {
                tmp = result[currIndex];

                for(int i = currIndex - 1;i>=0;i--)
                {
                    if (result[currIndex]<result[i])
                    {
                        result[i+1] = result[i];
                        result[i] = tmp;
                    }
                }

                currIndex++;
            }


            return result;
        }
    }
}
