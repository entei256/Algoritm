namespace Sort.Algo
{
    public static class BubleSort
    {
        public static int[] Sort(int[] arr)
        {
            int[] result = new int[arr.Length];
            arr.CopyTo(result, 0);

            for(int i = result.Length -1; i>0;i--)
            {
                for(int z = 0;z<i;z++)
                {
                    if (result[z]>result[z+1])
                    {
                        result[z] = result[z+1] + result[z];
                        result[z+1] = result[z] - result[z+1];
                        result[z] = result[z] - result[z+1];
                    }
                }
            }

            return result;
        }
    }
}