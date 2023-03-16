using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Algo
{
    public static class JumpedSearch
    {
        public static int Search(int[] source, int looking)
        {
            int step = (int)Math.Sqrt(source.Length);
            int currentStep = step;
            int previousStep = 0;

            Array.Sort(source);

            Console.WriteLine("***Сортируем массив, требуется для алгоритма");
            foreach (int i in source) { Console.Write(i + ", "); }
            Console.WriteLine("\nИщим цисло: {0}",looking);

            while (previousStep != currentStep)
            {
                if (looking == source[currentStep])
                    return currentStep;
                else if (looking > source[currentStep])
                {
                    previousStep = currentStep;
                    currentStep += step;
                }
                else
                {
                    return LineSearch.Search(source, looking, previousStep, currentStep);
                }
            }
            return -1;
        }
    }
}
