namespace Algorithms
{
    class Exercises2
    {
        public static void Exer2_1_2(int[] data)
        {
            for (int i = 1; i < data.Length; ++i)
            {
                int key = data[i];
                for (int j = i - 1; j >= 0; --j)  //j is "current card"
                {
                    if (key > data[j] && j >= 0)
                    {
                        data[j + 1] = data[j];
                        data[j] = key;
                    }
                }
            }
        }
        public static int? Exer2_1_3(int[] data,int value)
        {
            for (int i = 0; i < data.Length; ++i)
            {
                if (data[i] == value)
                {
                    return data[i];
                }
            }
            return null;
        }
        /*****************************
         * 初始化：A[0] 只有一个元素，必定是最小的
         * 保持：外部循环每次将A[i+1...n]中的最小值与A[i]交换
         * 终止：当n-1次循环时已对n-1与n比对交换，因此i=n-1时循环结束，此时i+1=n，数组排序完毕。
         * 最佳情况：Θ(n^2)
         * 最坏情况：Θ(n^2)
         * **************************/
        public static void Exer2_2_2(int[] data)
        {
            for (int i = 0; i < data.Length - 1; ++i)
            {
                int min = data[i];
                int minindex = i;
                for (int j = i + 1; j < data.Length; ++j)
                {
                    if (data[j] < min)
                    {
                        min = data[j];
                        minindex = j;
                    }
                }
                Program.Swap(ref data[i], ref data[minindex]);
            }
        }
    }
}
