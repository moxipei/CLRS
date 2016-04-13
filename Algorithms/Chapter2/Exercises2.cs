namespace Algorithms
{
    class Exercises2
    {
        public static void Exer2_2(int[] data)
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
        public static int? Exer2_3(int[] data,int value)
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

    }
}
