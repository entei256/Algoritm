using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Algo
{
    public class LineSearch
    {
        public static int Search (int[] source, int looking) 
        {
            for (int i = 0; i<source.Length; i++)
            {
                if (source[i] == looking)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int Search(int[] source, int looking, int istart, int istop)
        {
            for (int i = istart; i<istop; i++)
            {
                if (source[i] == looking)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
