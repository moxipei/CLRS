using System;
namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //var testdata = GetRandomArray(10);
            var testdata = new int[] {  1, 2, 3, 4, 5, 6, 7, 8, 9,10 };
            Display(testdata);
            //Chapter2.InsertSort(testdata);
            //Display(testdata);
            Console.WriteLine(Exercises2.Exer2_3_5_Iteration(testdata,3));
            Console.ReadKey();
        }
        #region Functions
        public static void Display(int[] data)
        {
            foreach (var i in data)
            {
                Console.Write(i + " ");
            }
            Console.Write('\n');
        }
        public static int[] GetRandomArray(int size, int minnumber = -1000, int maxnumber = 1000)
        {
            int[] array = new int[size];

            Random randNum = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randNum.Next(minnumber, maxnumber);
            }
            return array;
        }
        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        #endregion
    }
}
