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

            while (previousStep != currentStep)
            {
                if (looking == source[currentStep - 1])
                    return currentStep;
                else if (looking > source[currentStep -1])
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
