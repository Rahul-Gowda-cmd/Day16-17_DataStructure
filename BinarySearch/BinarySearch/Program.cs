using System;

namespace BinarySearch
{
    class Program
    {
        public static int binarySearch(int[] inputArr, int key)
        {
            int start = 0;
            int end = inputArr.Length - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (key == inputArr[mid])
                {
                    return mid;
                }
                if (key < inputArr[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 6, 8, 9 };
            int pos = binarySearch(arr, 6);
            Console.WriteLine("key found at " + pos);
        }
    }
}
