using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Algo
{
    internal class ExponentialSearch
    {
        public static int Search(int[] source, int looking)
        {
            int step = 1;//(int)Math.Sqrt(source.Length);
            int currentStep = step;
            int previousStep = 0;

            Array.Sort(source);

            Console.WriteLine("***Сортируем массив, требуется для алгоритма");
            foreach (int i in source) { Console.Write(i + ", "); }
            Console.WriteLine("\nИщим цисло: {0}", looking);

            while (previousStep != currentStep)
            {
                if (looking == source[currentStep])
                    return currentStep;
                else if (looking > source[currentStep])
                {
                    previousStep = currentStep;
                    if ((currentStep + step * 2) < source.Length)
                    {
                        step *= 2;
                        currentStep += step;
                    }
                    else
                        currentStep = source.Length-1;
                }
                else
                {
                    return BinarySearch.Search(source, looking, previousStep, currentStep);
                }
            }

            return -1;
        }
    }
}
