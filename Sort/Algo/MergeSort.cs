using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Algo
{
    public static class MergeSort
    {
        public static int[] Sort(int[] arr)
        {
            int[] result = new int[arr.Length];
            int[] left = new int[arr.Length/2];
            int[] right = new int[arr.Length/2];

            arr.CopyTo(result, 0);

            if (arr.Length <= 1)
                return arr;
            else
            {
                Array.Copy(arr, 0, left, 0, arr.Length/2);
                Array.Copy(arr, arr.Length/2, right, 0, arr.Length/2);
                Sort(left);
                Sort(right);
            }

            return Merge(left, right);
        }

        private static int[] Merge(int[] ArrLeft, int[] ArrRight)
        {
            int[] result = new int[ArrLeft.Length+ArrRight.Length];
            int leftI = 0;
            int rightI = 0;

            for (int i = 0; i< result.Length; i++)
            {
                if (ArrLeft[leftI] < ArrRight[rightI])
                {
                    result[i] = ArrLeft[leftI];
                    if(leftI < ArrLeft.Length-1)
                        leftI++;
                } else
                {
                    result[i] = ArrRight[rightI];
                    if (rightI < ArrRight.Length-1)
                        rightI++;
                }
            }

            return result;
        }
    }
}
