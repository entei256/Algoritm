using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Algo
{
    public static class CountingSort
    {
        public static int[] Sort (int[] arr)
        {
            var maxValue = arr.Max();
            int[] tmpArr = new int[maxValue+1]; //Еще учитываем что индексы начинаяются с 0 по этому +1 к велечене массива.
            int[] result = new int[arr.Length];
            int step = 0;
            //Заполняем TMP массив
            for(int i = 0; i < arr.Length;i++)
            {
                tmpArr[arr[i]] += 1;
            }
            
            //Перебераем значения в TMP массиве и заполняем последовательно результат
            for(int i = 0; i<tmpArr.Length;i++)
            {
                if (tmpArr[i] > 0)
                {
                    for(int z = 0;z < tmpArr[i];z++)
                    {
                        result[step] = i;
                        step++;
                    }
                }
            }
            

            return result;
        }
    }
}
