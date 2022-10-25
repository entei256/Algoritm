using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Algo
{
    public static class ShellSort
    {
        public static int[] Sort(int[] arr)
        {
            int[] result = new int[arr.Length];
            arr.CopyTo(result, 0);

            int step = result.Length/2;
            int tmp;

            while(step >= 1)
            {
                for(int i = 0;i<= result.Length;i++)
                {
                    if (i+step < result.Length)
                    {
                        if (result[i] < result[i+step])
                        {
                            tmp = result[i];
                            result[i] = result[i+step];
                            result[i+step] = tmp;
                        }
                    }
                }
                step /= 2;
            }
            

            return result;
        }
    }
}
