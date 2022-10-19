using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Algo
{
    public static class BinarySearch
    {
        public static int Search(int[] source, int looking)
        {
            int lefti = 0;
            int righti = source.Length-1;
            int mid = (lefti + righti)/2;

            Array.Sort(source);

            while (lefti<=righti)
            {
                if (source[mid] == looking)
                {
                    return mid;
                }
                else if (source[mid] < looking)
                {
                    lefti = ++mid;
                    mid = (lefti + righti)/2;
                }
                else
                {
                    righti = --mid;
                    mid = (lefti + righti)/2;
                }
                    
            }
            return -1;
        }

        public static int Search(int[] source, int looking,int istart, int istop)
        {
            int lefti = istart;
            int righti = istop;
            int mid = (lefti + righti)/2;

            Array.Sort(source);

            while (lefti<=righti)
            {
                if (source[mid] == looking)
                {
                    return mid;
                }
                else if (source[mid] < looking)
                {
                    lefti = ++mid;
                    mid = (lefti + righti)/2;
                }
                else
                {
                    righti = --mid;
                    mid = (lefti + righti)/2;
                }

            }
            return -1;
        }

        public static int RecursiveSearch(int[] source, int looking,int lefti , int righti)
        {
            int mid = (lefti + righti)/2;

            Array.Sort(source);

            if (source[mid] == looking)
            {
                return mid;
            }
            else if (source[mid] < looking)
            {
                return RecursiveSearch(source,looking,mid +1,righti);
            }
            else
            {
                return RecursiveSearch(source, looking,lefti ,mid - 1 );
            }
        }
    }
}
