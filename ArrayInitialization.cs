using System;
class Programm
{
    static void Main()
    {
        //int[] nums = new int[3] {1, 3, 5}; размер массива указан явно
        //int[] nums = new int[] {1, 3, 5}; не явно
        int[] nums = { 1, 3, 5, 7, 6, 5, 4 };
        char[] symbs = new char[] { 'A', 'Z', 'B', 'Y' };
        string[] txts = new string[3] { "один", "два", "три" };
        Console.WriteLine("Массив nums:");
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write(nums[i] + " ");
        }
        Console.WriteLine("\nМассив symbs:");
        for (int i = 0; i < symbs.Length; i++)
        {
            Console.Write(symbs[i] + " ");
        }
        Console.WriteLine("\nМассив txts:");
        for (int i = 0; i < txts.Length; i++)
        {
            Console.Write(txts[i] + " ");
        }
        Console.WriteLine();
    }
}