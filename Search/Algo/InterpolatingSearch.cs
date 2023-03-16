using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Algo
{
    public class InterpolatingSearch
    {
        public static int Search(int[] source, int looking)
        {
            int lefti = 0;
            int righti = source.Length - 1;

            Array.Sort(source);

            Console.WriteLine("***Сортируем массив, требуется для алгоритма");
            foreach (int i in source) { Console.Write(i + ", "); }
            Console.WriteLine("\nИщим цисло: {0}", looking);

            int curri;

            while (looking >= source[lefti] && looking <= source[righti])
            {
                if (lefti == righti)
                    break;
                curri = lefti + ((looking - source[lefti])*(righti - lefti))/(source[righti] - source[lefti]);
                

                if (source[curri] == looking)
                    return curri;
                else if (source[curri] < looking)
                    lefti = curri + 1;
                else
                    righti = curri - 1;

                if (source[lefti] == looking)
                    return lefti;
                else if (source[righti] == looking)
                    return righti;
            }

            return -1;
        }

    }
}
