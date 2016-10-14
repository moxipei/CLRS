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

        public static int? Exer2_1_3(int[] data, int value)
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
         * 初始化：i=0时 A[0] 只有一个元素，必定是最小的
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

        public static void Exer2_3_2(int[] arr, int p, int q, int r)
        {
            int n1 = q - p + 1;
            int n2 = r - q;
            int[] larr = new int[n1];
            int[] rarr = new int[n2];


            for (int i = 0; i < n1; ++i)
            {
                larr[i] = arr[p + i];
            }
            for (int i = 0; i < n2; ++i)
            {
                rarr[i] = arr[i + q + 1];
            }
            int j = 0;
            int k = 0;
            for (int i = p; i <= r; ++i)
            {
                if (j >= larr.Length)
                {
                    arr[i] = rarr[k];
                    ++k;
                    continue;
                }
                else if (k >= rarr.Length)
                {
                    arr[i] = larr[j];
                    ++j;
                    continue;
                }
                else
                {
                    if (larr[j] <= rarr[k])
                    {
                        arr[i] = larr[j];
                        ++j;
                    }
                    else
                    {
                        arr[i] = rarr[k];
                        ++k;
                    }
                }

            }
        }

        public static void Exer2_3_4(int[] data, int n)
        {
            if (n > 0)
            {
                int i = n - 1;
                Exer2_3_4(data, i);
                int key = data[n];
                if (n > 0 && key < data[n - 1])
                {
                    data[n] = data[n - 1];
                    data[n - 1] = key;
                    Exer2_3_4(data, n - 1);
                }
            }

        }


        public static int Exer2_3_5_Recursion(int[] data)
        {
            return 0;
        }

        public static int Exer2_3_5_Iteration(int[] data, int search)
        {
            int left, mid, right;
            left = 0;
            mid = data.Length / 2;
            right = data.Length - 1;

            while (left < right)
            {
                mid = (right + left) / 2;
                if (data[mid] < search)
                {
                    left = mid;
                }
                else if(data[mid] > search)
                {
                    right = mid;
                }
                else
                {
                    return mid;
                }

            }

            return 0;

        }
    }
}
