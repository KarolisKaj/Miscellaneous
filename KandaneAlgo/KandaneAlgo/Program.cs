using System;

namespace KandaneAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kandane.KandaneSum(new[] { -1, 3, -4, 4 }));
            Console.Read();
        }
    }

    public class Kandane
    {
        public static int KandaneSum(int[] arr)
        {
            int max = arr[0];
            int currentMax = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                currentMax = Math.Max(arr[i], currentMax + arr[i]);
                if (currentMax > max)
                    max = currentMax;
            }
            return max;
        }

    }
}
