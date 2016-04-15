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

        private static void Merge(int[] data, int start, int mid, int end)
        {
            int length1 = mid - start + 1;
            int length2 = end - mid;  

            var Left = new int[length1 + 1];
            var Right = new int[length2 + 1];

            int Lindex = 0, Rindex = 0; //Left array index,Right array index

            for (; Lindex < length1; ++Lindex)
            {
                Left[Lindex] = data[start + Lindex];
            }

            for (; Rindex < length2; ++Rindex)
            {
                Right[Rindex] = data[mid + Rindex + 1];
            }

            Left[length1] = int.MaxValue;
            Right[length2] = int.MaxValue;

            Lindex = Rindex = 0;
            for (int i = start; i <= end; ++i)
            {
                if (Left[Lindex] < Right[Rindex])
                {
                    data[i] = Left[Lindex];
                    ++Lindex;
                }
                else
                {
                    data[i] = Right[Rindex];
                    ++Rindex;
                }
            }
        }

        public static void MergeSort(int[] data, int start, int end)
        {
            if (end == data.Length) --end;
            if (start < end)
            {
                int mid = (end + start) / 2;
                MergeSort(data, start, mid);
                MergeSort(data, mid + 1, end);
                Merge(data, start, mid, end);
            }
        }
    }
}
