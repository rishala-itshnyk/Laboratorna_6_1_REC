using System;

namespace Laboratorna_6_1_REC
{
    public class Program
    {
        public static void FillArray(int[] b, int index = 0)
        {
            Random random = new Random();
            if (index < 21)
            {
                b[index] = random.Next(10, 91);
                FillArray(b, index + 1);
            }
        }

        public static void PrintArray(int[] b, int index = 0)
        {
            if (index < 21)
            {
                Console.Write($"{b[index],4}");
                PrintArray(b, index + 1);
            }
            else
            {
                Console.WriteLine();
            }
        }
        
        public static void ProcessArrayRecursive(int[] b, int index, ref int count, ref int sum)
        {
            if (index < b.Length)
            {
                if (!(b[index] % 2 != 0 && b[index] % 3 == 0))
                {
                    count++;
                    sum += b[index];
                    b[index] = 0;
                }
                ProcessArrayRecursive(b, index + 1, ref count, ref sum);
            }
        }
        
        public static void ProcessArray(int[] arr, out int count, out int sum)
        {
            count = 0;
            sum = 0;
            ProcessArrayRecursive(arr, 0, ref count, ref sum);
        }
        
        public static void Main()
        {
            int[] myArray = new int[21];
            int count, sum;

            FillArray(myArray);
            Console.Write("Original Array: ");
            PrintArray(myArray);

            ProcessArray(myArray, out count, out sum);
            Console.Write("Modified Array: ");
            PrintArray(myArray);
            Console.WriteLine($"Count of elements satisfying the criteria: {count}");
            Console.WriteLine($"Sum of elements satisfying the criteria: {sum}");

             Console.ReadLine();
        }
    }
}