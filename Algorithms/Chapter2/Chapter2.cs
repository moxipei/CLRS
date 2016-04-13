namespace Algorithms
{
    class Chapter2
    {

        public static void InsertSort(int[] data)
        {
            for (int i = 1; i < data.Length; ++i)
            {
                int key = data[i];
                for (int j = i - 1; j >= 0; --j)  //j is "current card"
                {
                    if (key < data[j] && j >= 0)
                    {
                        data[j + 1] = data[j];
                        data[j] = key;
                    }
                }
            }
        }

        /// <summary>
        /// Recursion Insert sort
        /// </summary>
        /// <param name="data"></param>
        /// <param name="n">n is data's size</param>
        public static void InsertSort(int[] data, int n)
        {
            if (n > 0)
            {
                int i = n - 1;
                InsertSort(data, i);
                int key = data[n];
                if (n > 0 && key < data[n - 1])
                {
                    data[n] = data[n - 1];
                    data[n - 1] = key;
                    InsertSort(data, n - 1);
                }
            }
        }
    }
}
